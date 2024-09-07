using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1_MVC.DAL.Models
{
    public class Department
    {
        
        public int id { get; set; } //pk Identity(1,1)
        [Required(ErrorMessage = "Code Is Required!")]
        public string Code { get; set; } //.Net 5 (Allow Null)
        [Required(ErrorMessage = "Name Is Required!")]
        public string Name { get; set; }
        public DateTime DataOfCreation { get; set; }
    }
}
