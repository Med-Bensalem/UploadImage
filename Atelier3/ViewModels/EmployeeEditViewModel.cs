using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atelier3.ViewModels
{
    public class EmployeeEditViewModel : CreateViewModel
    {
        public int Id { get; set; }
        public string ExistingPhotoPath { get; set; }
    }
}
