using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inchirieri
{
    internal class Data
    {
        private int zi;
        private int luna;
        private int an;

        public int Zi {
            get { return zi; }
            set { zi = value; }
        }
        public int Luna
        {
            get { return luna; }
            set { luna = value; }
        }
        public int An
        {
            get { return an; }
            set { an = value; }
        }
        public Data()
        {
            zi = 0;
            luna = 0;
            an = 0;
        }
        public Data(int _zi, int _luna, int _an)
        {
            zi = _zi;
            luna = _luna;
            an = _an;
        }

    }
}
