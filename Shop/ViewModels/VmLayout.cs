using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModels
{
    public class VmLayout
    {
        public Setting setting { get; set; }

        public List<Social> Social { get; set; }
    }
}
