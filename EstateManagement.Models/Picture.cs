using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateManagement.Models
{
    public class Picture
    {
        public int Id { get; set; } //cheia primara in tabel
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public long Size { get; set; }
        public string Path { get; set; }
        public int EstateId { get; set; }
    }
}
