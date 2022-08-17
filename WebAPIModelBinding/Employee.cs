using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace WebAPIModelBinding
{
    public class Employee
    {
        public int id { get; set; }
        public string? name { get; set; }
        public int age { get; set; }
        public string? address { get; set; }


    }
}
