using System.ComponentModel.DataAnnotations;

namespace Employee_TaskCoreWebApis.Models
{
    public class TblEmployees
    {
        [Key]
        public int EmployeeId { get; set;}
        [Required(ErrorMessage = "EmployeeName is required.")]
        public string EmployeeName { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string EmailAddress { get; set; }

        [Phone(ErrorMessage = "Invalid Mobile Number.")]
        public string MobileNumber { get; set; }

        [Required(ErrorMessage =" Gender is Required.")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Designation is required.")]
        public string Designation { get; set; }

        [Range(0, float.MaxValue, ErrorMessage = "Salary must be a positive number.")]
        public float Salary { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime JoiningDate{ get;set; }

    }
}

