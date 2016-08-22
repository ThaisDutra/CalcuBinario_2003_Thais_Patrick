using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcuBinario_2003_Thais_Patrick
{
    static class HexDecBin
    {
        public static string DecToHex(int x)
        {
            string result = "";

            while (x != 0)
            {
                if ((x % 16) < 10)
                    result = x % 16 + result;
                else
                {
                    string temp = "";

                    switch (x % 16)
                    {
                        case 10: temp = "A"; break;
                        case 11: temp = "B"; break;
                        case 12: temp = "C"; break;
                        case 13: temp = "D"; break;
                        case 14: temp = "E"; break;
                        case 15: temp = "F"; break;
                    }

                    result = temp + result;
                }

                x /= 16;
            }

            return result;
        }

        public static int HexToDec(string x)
        {
            int result = 0;
            int count = x.Length - 1;
            for (int i = 0; i < x.Length; i++)
            {
                int temp = 0;
                switch (x[i])
                {
                    case 'A': temp = 10; break;
                    case 'B': temp = 11; break;
                    case 'C': temp = 12; break;
                    case 'D': temp = 13; break;
                    case 'E': temp = 14; break;
                    case 'F': temp = 15; break;
                    default: temp = -48 + (int)x[i]; break;
                }

                result += temp * (int)(Math.Pow(16, count));
                count--;
            }

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region Decibina
            Console.WriteLine("Decimal p/ Binário e vice&versa");

            int Deci;
            string Bina;
            string Binar;
            int Decim;

            Console.WriteLine("Digite o decimal que irá ser convertido");
            Deci = Convert.ToInt32(Console.ReadLine());

            Bina = Convert.ToString(Deci, 2);

            Console.WriteLine("O binário deste deste decimal é " + Bina);

            Console.WriteLine("Digite o binário que irá ser convertido");
            Binar = Convert.ToString(Console.ReadLine());

            Decim = Convert.ToInt32(Binar, 2);

            Console.WriteLine("O decimal deste binário é" + " " + Decim);

            Console.ReadKey();

            Console.Clear();

            #endregion

            #region HexDec
            Console.WriteLine("Decimal p/ Hexadecimal e vice&versa");

            Console.WriteLine("Digite o decimal que irá ser convertido");
            int Dec = int.Parse(Console.ReadLine());

            Console.WriteLine("Decimal {0} é o Hexadecimal {1}", Dec, HexDecBin.DecToHex(Dec));

            Console.WriteLine("Digite o hexadecimal que irá ser convertido");
            string Hex = Console.ReadLine().ToUpper();

            Console.WriteLine("Hexadecimal {0} é o Decimal {1}", Hex, HexDecBin.HexToDec(Hex));

            Console.ReadKey();

            Console.Clear();

            #endregion

            #region HexBin

            Console.WriteLine("Binário p/ hexadecimal e vice&versa");

            Console.WriteLine(" Digite o binário que irá ser convertido");

            string MyBin = Convert.ToString(Console.ReadLine());

            int MyDec = Convert.ToInt32(MyBin, 2);

            string MyHex = MyDec.ToString("X");

            Console.WriteLine("O hexadecimal deste binário é" + " " + MyHex);


            Console.WriteLine("Digite o hexadecimal que irá ser convertido");

            string MioHex = Console.ReadLine().ToUpper();

            int MioDec = Convert.ToInt32(MioHex, 16);

            string MioBin = Convert.ToString(Deci, 2);

            Console.WriteLine("O binário deste hexadecimal é" + " " + MioBin);

            Console.ReadKey();

            #endregion
        }
    }
}
