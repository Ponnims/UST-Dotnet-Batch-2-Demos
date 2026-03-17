using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreAnnotations.Models
{
    [Table("tbl_Products")]
    internal class Product
    {
        [Key]
        [Column(Order =0)]
        public int ProductId { get; set; }
        [Required]
        [MaxLength(100)]
        [Column("ProductName")]
        public string Name { get; set; }
        [Column(TypeName = "decimal(18,2)",Order = 2)]
        
        public decimal Price { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Column(Order = 1)]
        public DateTime Manufacturingdate { get; set; }

        [NotMapped]
        public int Dummy { get; set; }

    }
}
