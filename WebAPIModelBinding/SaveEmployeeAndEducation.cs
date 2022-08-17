using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace WebAPIModelBinding
{
    public class SaveEmployeeAndEducation
    {
        public Employee? Employee { get; set; }
        public EmployeeEducation? EmpEducation { get; set; }
    }
}
