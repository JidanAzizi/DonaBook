using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonaBook_Gui.Models
{
    public class BookDonation
    {
        public string Id { get; set; }
        public string Judul { get; set; }
        public string Penulis { get; set; }
        public string Penerbit { get; set; }
        public string Donatur { get; set; }
        public string Status { get; set; } // "Tersedia", "Diminta", "Dikirim"
    }
}
