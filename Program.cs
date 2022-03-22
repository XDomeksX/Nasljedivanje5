using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedivanje5
{
    internal class Program
    {
        class Brojevi
        {
            double broj;

            public double Broj { get => broj; set => broj = value; }

            virtual public double ApsVrijednosti()
            {
                double vrijednost = 0;
                return vrijednost;
            }
        }

        class Cijeli : Brojevi
        {
            public override double ApsVrijednosti()
            {
                if (Broj < 0)
                {
                    return Broj * (-1);
                }
                else
                {
                    return Broj;
                }
            }
        }

        class Decimalni : Brojevi
        {
            public override double ApsVrijednosti()
            {
                if (Broj < 0)
                {
                    return Broj * (-1);
                }
                else
                {
                    return Broj;
                }
            }
        }

        class Pozitivni : Cijeli
        {
            public override double ApsVrijednosti()
            {
                return base.ApsVrijednosti();
            }
        }

        class Negativni : Cijeli
        {
            public override double ApsVrijednosti()
            {
                return base.ApsVrijednosti();
            }
        }
        static void Main(string[] args)
        {
            Pozitivni x = new Pozitivni();
            x.Broj = 100;
            Console.WriteLine(x.ApsVrijednosti());

            Negativni y = new Negativni();
            y.Broj = -100;
            Console.WriteLine(y.ApsVrijednosti());

            Decimalni z = new Decimalni();
            z.Broj = 100.45;
            Console.WriteLine(z.ApsVrijednosti());

            Console.ReadKey();
        }
    }
}
