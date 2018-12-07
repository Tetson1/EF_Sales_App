using SalesAppEF.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesAppEF.Models
{
    class SalesPerson : BaseModel, IActive                           //SalesPerson will inherit information from the BaseModel
    {
        [Required]
        public bool Active { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }
        public virtual SalesRegion Region { get; set; }

        [Required]
        public int RegionId { get; set; }
    }
}
