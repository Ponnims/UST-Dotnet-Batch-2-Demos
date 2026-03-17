using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreAnnotations.Models
{
    internal class Author
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)] // Non Identity Primary Key
        public int AuthorId { get; set; }
        public string AUthorName { get; set; }
    }
}
