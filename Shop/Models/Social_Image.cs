using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Social_Image
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        [NotMapped]
        public IFormFile NameFile { get; set; }
        [ForeignKey("Social")]
        public int Social_Id { get; set; }
        public Social Social { get; set; }
    }
}
