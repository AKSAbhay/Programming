using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLayer.Models
{
    public class Employee
    {
        [Key]
        public int employeeId { get; set; }
        public string employeeName { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public DateTime dateOfJoin { get; set; }
        public bool verificationStatus { get; set; }
        public bool isDeleted { get; set; }
        public bool isManager { get; set; }
        public int employeeRoleId { get; set; }
        public int attendanceId { get; set; }
        public int leaveId { get; set; }
        public int reportsId { get; set; }
    }
}
