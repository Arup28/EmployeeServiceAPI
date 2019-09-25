using System;
using System.Collections.Generic;

namespace EmployeeService.Repository
{
    public partial class TblEmployee
    {
        public int Id { get; set; }
        public string Department { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Designation { get; set; }
        public string ManagerSName { get; set; }
        public string EmployeeType { get; set; }
        public string Notes { get; set; }
        public byte[] UploadPhoto { get; set; }
    }
}
