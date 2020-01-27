using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAbstrack
{
    class Area
    {
        private double _width;
        private double _length;

        public double Width { 
            get
            {
                return _width;
            }
            set
            {
                if(value <= 0)
                {
                    Console.WriteLine("Menfi eded daxil etmek olmaz!");
                    return;
                }
                _width = value;
            }
        }

        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Menfi eded daxil etmek olmaz!");
                    return;
                }
                _length = value;
            }
        }

        public void AreaK()
        {
            if (_width * _length == 0)
            {
                Console.WriteLine("Zehmet olmasa en ve uzunu set edin!!!");
                return;
            }
            Console.WriteLine(_length*_width);
        }
    }
}
