//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int employeeId { get; set; }
        public string employeeName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string gender { get; set; }
        public Nullable<System.DateTime> dateOfJoin { get; set; }
        public Nullable<bool> verificationStatus { get; set; }
        public Nullable<bool> isDeleted { get; set; }
        public Nullable<bool> isManager { get; set; }
        public Nullable<int> employeeRoleId { get; set; }
        public Nullable<int> attendanceId { get; set; }
        public Nullable<int> leaveId { get; set; }
        public Nullable<int> reportsId { get; set; }
    }
}
