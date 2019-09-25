using EmployeeService.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeService.BusinessLayer.Interfaces
{
    interface IEmployeeBusiness
    {
        IEnumerable<TblEmployee> GetTblEmployee();
        Task<IActionResult> GetTblEmployee(int id);


    }
}
