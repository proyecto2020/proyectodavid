using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public  class Areas
    {

        int _idArea;
        string _Area;

        public int idArea
        {
            get { return _idArea; }
            set { _idArea = value; }
        }

        public string Area
        {
            get { return _Area; }
            set { _Area = value; }
        }

        public Areas(int idArea, string Area)
        {
            _idArea = idArea;
            _Area = Area;
        }
        public Areas() : this(0, "")
        {
        }
    }
}
