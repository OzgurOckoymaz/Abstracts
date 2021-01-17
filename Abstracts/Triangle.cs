using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts
{
    class Triangle:GeometricShape
    {
        private decimal _height;
        private decimal _floor;

        public decimal Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public decimal Floor
        {
            get { return _floor; }
            set { _floor = value; }
        }

        public override decimal Area()
        {
            return (_floor * _height / 2);
        }
    }
}
