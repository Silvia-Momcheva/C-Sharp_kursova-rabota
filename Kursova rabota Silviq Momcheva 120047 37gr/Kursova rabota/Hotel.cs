using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_rabota
{
    [Serializable]public class Hotel
    {
        public string ime { get; set; }
        public string nomer { get; set; }
        public string tip { get; set; }
        public int dni { get; set; }
        public double suma { get; set; }
    }
}
