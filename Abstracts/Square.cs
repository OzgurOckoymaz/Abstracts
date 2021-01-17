using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts
{
    class Square:GeometricShape
    {
        private decimal _edge;

        public decimal Edge
        {
            get { return _edge; }
            set { _edge = value; }
        }

        public override decimal Area()
        {
            return _edge * _edge;
        }
    }
}
