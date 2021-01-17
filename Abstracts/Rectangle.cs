using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts
{
    class Rectangle:GeometricShape
    {
        private decimal _short;
        private decimal _long;

        public decimal Short
        {
            get { return _short; }
            set { _short = value; }
        }

        public decimal Long
        {
            get { return _long; }
            set { _long = value; }
        }

        public override decimal Area()
        {
            return _short * _long;
        }

    }
}
