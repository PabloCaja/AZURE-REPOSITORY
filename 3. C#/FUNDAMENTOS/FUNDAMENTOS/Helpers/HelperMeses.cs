using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FUNDAMENTOS.Models;

namespace FUNDAMENTOS.Helpers
{
    public class HelperMeses
    {
        //ESTA CLASE TENDRA UNA COLECCION CON TODOS LOS MESES
        public List<TemperaturaMes> Meses { get; set; }

        //AL CREAR LA CLASE, QUEREMOS QUE YA VENGAN UNOS MESES 
        //CREADOS
        public HelperMeses()
        {
            this.GenerarNuevosDatosMeses();
        }

        public void GenerarNuevosDatosMeses()
        {
            this.Meses = new List<TemperaturaMes>();
            Random random = new Random();
            for (int i = 1; i <= 12; i++)
            {
                TemperaturaMes mes = new TemperaturaMes();
                mes.Maxima = random.Next(20, 60);
                mes.Minima = random.Next(-15, 15);
                mes.NombreMes = "Mes " + i;
                this.Meses.Add(mes);
            }
        }

        //METODO PARA LA MEDIA ANUAL
        public int GetMediaAnual()
        {
            int media = 0;
            foreach (TemperaturaMes mes in this.Meses)
            {
                media += mes.GetMediaMes();
            }
            return media / this.Meses.Count;
        }

        public int GetMaximaAnual()
        {
            int maxima = 0;
            foreach (TemperaturaMes mes in this.Meses)
            {
                maxima = Math.Max(maxima, mes.Maxima);
            }
            return maxima;
        }

        public int GetMinimaAnual()
        {
            int minima = 0;
            foreach (TemperaturaMes mes in this.Meses)
            {
                minima = Math.Min(minima, mes.Minima);
            }
            return minima;
        }
    }
}
