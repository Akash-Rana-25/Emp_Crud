using System.ComponentModel.DataAnnotations;

namespace Employee_Managment.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal BasicAndDA { get; set; }
        public decimal PerDay { get; set; }
        public int TotalDays { get; set; }
        public int PresentDays { get; set; }
        public int AbsentDays { get; set; }
        public int SundayHoliday { get; set; }
        public int CL { get; set; }
        public int TotalPayableDays { get; set; }
        public decimal PayableAmount { get; set; }
        public decimal ProfessionalTax { get; set; }
        public decimal PF { get; set; }
        public decimal ESIC { get; set; }
        public decimal ExtraDeduction { get; set; }
        public decimal NetAmountPayable { get; set; }


      
        //public string EmpCode { get; set; }

        //[DataType(DataType.Password)]
        //public string Password { get; set; }
        public bool IsDeleted { get; set; } // New property for soft delete
    }

}
