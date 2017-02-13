using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Connection360.Web.Models
{
    public class Brand
    {
        public int BrandId { get; set; }

        [Required(ErrorMessage = "Brand name is required.")]
        [StringLength(30)]
        public string Name { get; set; }

       
        public string LogoUrl { get; set; }

        [Required(ErrorMessage = "Brand description is required.")]
        public string Description { get; set; }
        public ICollection<BrandSkuMap> Maps { get; set; }
        
    }
}