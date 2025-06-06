using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonaBook_Gui.Models
{
    public class BookRequest
    {
        public string BookId { get; set; }
        public string NamaPenerima { get; set; }
        public string Alamat { get; set; }
        public string Catatan { get; set; }
    }
}
