namespace FED.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        public int ProductID { get; set; }
        
        [Required]
        [Display(Name = "Product name")]
        public string Name { get; set; }

        public int? Quantiry { get; set; }

        [DataType(DataType.Date)]
        [Display(Name="Expiration date")]
        public DateTime DateOfExp { get; set; }

        [Required]
        [StringLength(128)]
        public string userID { get; set; }
    }
}
