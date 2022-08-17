using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace WebAPIModelBinding
{
    public class EmployeeEducation
    {
            public int empId { get; set; }
            public string? empEducation { get; set; }
            public int passingYear { get; set; }
            public int marksPercentage { get; set; }

        
    }
}
