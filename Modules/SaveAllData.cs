using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace WebApi.Modules
{
    public class SaveAllData
    {
        public static bool SaveData(dynamic pObjClass, short pMode, dynamic vettaledb, string orgCode)
        {
            pObjClass.ModByOrgCode = orgCode;
            pObjClass.ModDate = DateTime.Now;

            if (pMode == (short)ProgramMode.NewMode)
            {
                pObjClass.ParentOrgCode = orgCode;
                pObjClass.CreateByOrgCode = orgCode;
                pObjClass.CreateDate = DateTime.Now;
                vettaledb.Add(pObjClass);
            }
            else if (pMode == (short)ProgramMode.EditMode)
            {
                vettaledb.Update(pObjClass);
            }

            pObjClass = SetDefaultValue(pObjClass);
            vettaledb.SaveChanges();
            return true;
        }

        public static dynamic SetDefaultValue(dynamic pObjClass)
        {
            PropertyInfo[] properties = pObjClass.GetType().GetProperties();
            foreach (var propertyInfo in properties)
            {
                var currentValue = propertyInfo.GetValue(pObjClass);
                if (currentValue == null)
                {
                    if (propertyInfo.PropertyType == typeof(string)) // ข้อความ
                    {
                        propertyInfo.SetValue(pObjClass, String.Empty, null);
                    }
                    else if (propertyInfo.PropertyType == typeof(DateTime?)) // วันที่
                    {
                        propertyInfo.SetValue(pObjClass, DateTime.Now, null);
                    }
                    else if (propertyInfo.PropertyType == typeof(byte[])) // Image[]
                    {
                        propertyInfo.SetValue(pObjClass, null, null);
                    }
                    else // ตัวเลข
                    {
                        var typeProp = Nullable.GetUnderlyingType(propertyInfo.PropertyType) ?? propertyInfo.PropertyType;
                        var safeValue = Convert.ChangeType(0, typeProp);
                        propertyInfo.SetValue(pObjClass, safeValue, null);
                    }
                }
            }

            return pObjClass;
        }
    }
}
