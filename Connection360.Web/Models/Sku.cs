using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Connection360.Web.Models
{
    public class Sku
    {
        public int SkuId { get; set; }

        [Required]
        public string Name { get; set; }

        [StringLength(30)]
        [Required]
        public string ImageUrl { get; set; }
        public List<BrandSkuMap> BrandSkuMaps { get; set; }

    }
}