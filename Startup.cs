using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using WebApi.Models;
using WebApi.Services;

namespace WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                // การเปลี่ยนข้อมูลส่วนหัวข้อข้างบน
                c.SwaggerDoc("v1", new OpenApiInfo { 
                    Title = "Web API", 
                    Version = "v1",
                    Description = "เป็นระบบทำการส่งข้อมูลไปแสดงผลบนเว็บไซต์"
                    // TermsOfService = new Uri("https://example.com/terms"),
                    // Contact = new OpenApiContact {
                    //     Name = "Pattama Pramkamon",
                    //     Email = "Pattama@izpal.com",
                    //     Url = new Uri("https://twitter.com/iamsamit"),
                    // },
                    // License = new OpenApiLicense {
                    //     Name = "Store API LICX",
                    //     Url = new Uri("https://example.com/license"),
                    // }
                });

                // เรียกใช้ Authentication ------------------------------------------------------------   
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()  
                {  
                    Name = "Authorization",  
                    Type = SecuritySchemeType.ApiKey,  
                    Scheme = "Bearer",  
                    BearerFormat = "JWT",  
                    In = ParameterLocation.Header,  
                    Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 12345abcdef\"",  
                });  

                c.AddSecurityRequirement(new OpenApiSecurityRequirement  
                {  
                    {  
                          new OpenApiSecurityScheme  
                            {  
                                Reference = new OpenApiReference  
                                {  
                                    Type = ReferenceType.SecurityScheme,  
                                    Id = "Bearer"  
                                }  
                            },  
                            new string[] {}  
  
                    }  
                });
                // ----------------------------------------------------------------------------------
            });
            
            // เรียกใช้ izdbDataModelSyncContext -------------------------------------------------------
            services.AddDbContext<IdentityContext>(options => options.UseSqlServer(Configuration.GetConnectionString("CentralConnection")));
            services.AddDbContext<izdbWebCenterContext>(options => options.UseSqlServer(Configuration.GetConnectionString("CentralConnection")));

            BuildServiceProvider(services);

            services.AddIdentity<IdentityUser, Roles>(options =>
            {
                //options.Password.RequiredLength = 7;
                //options.Password.RequireLowercase = false;
                //options.Password.RequireUppercase = false;
                //options.Password.RequireNonAlphanumeric = false;
                //options.Password.RequireDigit = false;
                //options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(60);
                //options.SignIn.RequireConfirmedEmail = true;
                //options.User.RequireUniqueEmail = true;
            })
            .AddEntityFrameworkStores<IdentityContext>()
            .AddDefaultTokenProviders();
            // --------------------------------------------------------------------------------------

            // เรียกใช้ ApplicationDbContext -----------------------------------------------------------
            // services.AddDbContext<ApplicationDbContext>(options =>
            // {
            //     options.UseSqlServer(Configuration.GetConnectionString("CentralConnection"));
            // });

            // For Identity  
            // services.AddIdentity<ApplicationUser, IdentityRole>()
            //     .AddEntityFrameworkStores<ApplicationDbContext>()
            //     .AddDefaultTokenProviders();
            
            // Adding Authentication
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })

            // Adding Jwt Bearer
            .AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = Configuration["JWT:ValidAudience"],
                    ValidIssuer = Configuration["JWT:ValidIssuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:Secret"]))
                };
            });            
            // --------------------------------------------------------------------------------------
        }

        private void BuildServiceProvider(IServiceCollection services)
        {
            Dictionary<string, string> connStrs = new Dictionary<string, string>();
            //ClinicLive
            var contextClinicLive = services.BuildServiceProvider().GetService<izdbWebCenterContext>();
            var mDatabaseClinicLive = contextClinicLive.Mdatabases.ToList();
            if (mDatabaseClinicLive != null)
            {
                //add DB By U 04/02/2019
                foreach (var item in mDatabaseClinicLive)
                {
                    connStrs.Add(item.DatabaseId, item.ConnectionString);
                }
                DbContextFactory.SetConnectionString(connStrs);
                //end
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // เปลี่ยนลิงค์
            app.UseStaticFiles();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger(c => {
                    c.RouteTemplate ="clinic/{documentName}/docs.json";
                });

                app.UseSwaggerUI(c => {
                    c.SwaggerEndpoint("/clinic/v1/docs.json", "Web API v1");
                    c.RoutePrefix = "clinic";
                    c.DocumentTitle ="Web API";
                    c.InjectStylesheet("/docs-ui/custom.css");
                    c.InjectJavascript("/docs-ui/custom.js");                    
                });
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(config => config.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

            // สำหรับเรียกใช้ Authentication --------------------------------------------------------
            app.UseAuthentication(); // Add this for Authentication
            // ----------------------------------------------------------------------------------

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
