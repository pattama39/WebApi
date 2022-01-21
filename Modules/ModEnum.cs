namespace WebApi.Modules
{
    public class ModEnum
    {
        public enum StaffTypeID
        {          
            /// พนักงาน           
            Staff = 1,
           
            /// แพทย์            
            Doctor = 2,
           
            /// พยาบาล          
            Nurse = 3,
         
            /// ช่าง         
            Stylist = 10,
         
            /// พนักงานทั่วไป        
            GeneralStaff = 44,
       
            /// อื่นๆ       
            Other = 99
        }
    }
}