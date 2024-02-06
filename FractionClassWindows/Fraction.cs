using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionClassWindows
{
    public class Fraction
    {
        public int N { get; }
        public int D { get; }

        public Fraction(int n, int d)
        {
            Semplifica(ref n, ref d);             
                N = n;
                D = d;
        }

        private void Semplifica(ref int n, ref int d)
        {
            int mcd = MCD(n, d);
            n = n / mcd;
            d = d / mcd;
        }

        private int MCD(int a, int b)
        {
            while(b!= 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;

        }

        public Fraction Somma(Fraction other)
        {
            return new Fraction(this.N * other.D + this.D * other.N, this.D * other.D);
        }
        public Fraction sottrai(Fraction other)
        {
            return new Fraction(this.N * other.D - this.D * other.N, this.D * other.D);
        }

        public Fraction Moltiplica(Fraction other)
        {
            return new Fraction(this.N * other.N, this.D * other.D);
        }

        public Fraction Dividi(Fraction other)
        {
            return new Fraction(this.N * other.D, this.D * other.N);
        }

        public override string ToString()
        {
            return $"{N}/{D}";
        }

        public static Fraction Parse(string s)
        {
            string[] parts = s.Split('/');
            return new Fraction(int.Parse(parts[0]), int.Parse(parts[1]));
        }
    }
}
