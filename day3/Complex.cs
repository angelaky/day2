using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Complex
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }

        public Complex(int real, int imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

     
        public static Complex operator +(Complex number1, Complex number2)
        {
            return new Complex(number1.Real + number2.Real, number1.Imaginary + number2.Imaginary);
        }

        public static Complex operator -(Complex number1, Complex number2)
        {
            return new Complex(number1.Real - number2.Real, number1.Imaginary - number2.Imaginary);
        }

        public override string ToString()
        {
            if (Imaginary < 0)
            {
                return (String.Format("{0} {1}i", Real, Imaginary));
            }
            else if (Imaginary == 0)
            {
                return (String.Format("{0}", Real));
            }
            else
            {
                return (String.Format("{0} + {1}i", Real, Imaginary));
            }
            
        }


    }
}
