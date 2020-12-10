using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Atelier3.Models
{
    public class ListeDep
    {
        public static List<string> Depts = new List<string>
        { "RH","Informatique","Finance"};
    }
    public class Employee
    {
        public int Id { get; set; }
        [Required][MaxLength(50,ErrorMessage ="Taille Max 50 cc ")]
        public string Name { get; set; }
        public string Departement { get; set; }
        [Range(300,5000,ErrorMessage ="Doit etre entre 300 et 5000")]
        public int Salary { get; set; }
        public string PhotoPath { get; set; }
    }
}
