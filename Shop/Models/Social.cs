using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Social
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(30)]
        public string Icon { get; set; }
        [MaxLength(250)]
        public string Link { get; set; }
        public List<Social_Image> Social_Images { get; set; }
    }
}
