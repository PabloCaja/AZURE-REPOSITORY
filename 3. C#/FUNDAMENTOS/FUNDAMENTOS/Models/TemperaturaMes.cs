using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNDAMENTOS.Models
{
    public class TemperaturaMes
    {
        public string NombreMes { get; set; }
        public int Maxima { get; set; } 
        public int Minima { get; set; }

        public int GetMediaMes() 
        { 
            return (this.Maxima + this.Minima)/2;

        }

    }
}
