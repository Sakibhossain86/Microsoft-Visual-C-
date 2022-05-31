using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Places
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Country { get; set; }
        public DateTime PackageDate { get; set; }
        public string Picture { get; set; }
        public string PackageDateON { get => this.PackageDate.ToString("yyyy-MMM-dd"); }
    }
}
