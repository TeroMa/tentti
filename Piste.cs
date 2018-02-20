using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenttitehtava2
{
    class Piste
    {
        public string Nimi { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public Piste()
        {

        }

        public Piste(string nimi,double x,double y)
        {
            this.Nimi = nimi;
            this.X = x;
            this.Y = y;
        }

    }
}
