using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atelier3.ViewModels
{
    public class CreateViewModel
    {
        public string Name { get; set; }
        public string Departement { get; set; }
        public int Salary { get; set; }
        public IFormFile Photo { get; set; }
    }
}
