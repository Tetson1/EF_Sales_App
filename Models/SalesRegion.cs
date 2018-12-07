using SalesAppEF.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesAppEF.Models
{
    class SalesRegion : BaseModel, IActive                   //SalesRegion will inherit information from the BaseModel
    {
        [Required]
        public bool Active { get; set; }

        [Required]
        [StringLength(100)]
        public String Name { get; set; }

        [Required]
        [StringLength(3)]
        public string Code { get; set; }

        public virtual ObservableListSource<SalesPerson> People { get; set; }
        /*public virtual ICollection<SalesPerson> People { get; set; } 
        This is enough when doing web apps, but since there's more involved this ObservableListSource method and class are required. */
    }
}
