using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Managemnet_System.Model
{
    public class Patient
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string  Name { get; set; }
        public string Phone {  get; set; }
        public string Address { get; set; }
        public bool Insurance { get; set; }
        public bool IsDeleted {  get; set; }
    }
}
