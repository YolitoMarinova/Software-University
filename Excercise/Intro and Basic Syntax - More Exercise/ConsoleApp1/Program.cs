using System;

namespace _5.Messages
{
    class Program
    {
        static void Main()
        {
            string number = (Console.ReadLine());
            string letter = "";
            while (number!="")
            {
                int lenght = number.ToString().Length;
                int mainDigit = int.Parse(number) % 10;
                int offsetNumber = 0;
                if (mainDigit == 8 || mainDigit == 9)
                {
                    offsetNumber = ((mainDigit - 2) * 3) + 1;
                }
                else
                {
                    offsetNumber = (mainDigit - 2) * 3;
                }
                int index = 0;
                if (number != null)
                {
                    index = (offsetNumber + lenght - 1);
                }
                else
                {
                    index = ((Math.Abs(offsetNumber)+21) + lenght - 1);
                }
                

                switch (index)
                {
                    case 0:
                        char a = Convert.ToChar(97);
                        letter += a;
                        number = Console.ReadLine();
                        break;
                    case 1:
                        char b = Convert.ToChar(98);
                        letter += b;
                        number = Console.ReadLine();
                        break;
                    case 2:
                        char c = Convert.ToChar(99);
                        letter += c;
                        number = Console.ReadLine();
                        break;
                    case 3:
                        char d = Convert.ToChar(100);
                        letter += d;
                        number = Console.ReadLine();
                        break;
                    case 4:
                        char e = Convert.ToChar(101);
                        letter += e;
                        number = Console.ReadLine();
                        break;
                    case 5:
                        char f = Convert.ToChar(102);
                        letter += f;
                        number = Console.ReadLine();
                        break;
                    case 6:
                        char g = Convert.ToChar(103);
                        letter += g;
                        number = Console.ReadLine();
                        break;
                    case 7:
                        char h = Convert.ToChar(104);
                        letter += h;
                        number = Console.ReadLine();
                        break;
                    case 8:
                        char i = Convert.ToChar(105);
                        letter += i;
                        number = Console.ReadLine();
                        break;
                    case 9:
                        char j = Convert.ToChar(106);
                        letter += j;
                        number = Console.ReadLine();
                        break;
                    case 10:
                        char k = Convert.ToChar(107);
                        letter += k;
                        number = Console.ReadLine();
                        break;
                    case 11:
                        char l = Convert.ToChar(108);
                        letter += l;
                        number = Console.ReadLine();
                        break;
                    case 12:
                        char m = Convert.ToChar(109);
                        letter += m;
                        number = Console.ReadLine();
                        break;
                    case 13:
                        char n = Convert.ToChar(110);
                        letter += n;
                        number = Console.ReadLine();
                        break;
                    case 14:
                        char o = Convert.ToChar(111);
                        letter += o;
                        number = Console.ReadLine();
                        break;
                    case 15:
                        char p = Convert.ToChar(112);
                        letter += p;
                        number = Console.ReadLine();
                        break;
                    case 16:
                        char q = Convert.ToChar(113);
                        letter += q;
                        number = Console.ReadLine(); 
                        break;
                    case 17:
                        char r = Convert.ToChar(114);
                        letter += r;
                        number = Console.ReadLine();
                        break;
                    case 18:
                        char s = Convert.ToChar(115);
                        letter += s;
                        number = Console.ReadLine();
                        break;
                    case 19:
                        char t = Convert.ToChar(116);
                        letter += t;
                        number = Console.ReadLine();
                        break;
                    case 20:
                        char u = Convert.ToChar(117);
                        letter += u;
                        number = Console.ReadLine();
                        break;
                    case 21:
                        char v = Convert.ToChar(118);
                        letter += v;
                        number = Console.ReadLine();
                        break;
                    case 22:
                        char w = Convert.ToChar(119);
                        letter += w;
                        number = Console.ReadLine();
                        break;
                    case 23:
                        char x = Convert.ToChar(120);
                        letter += x;
                        number = Console.ReadLine();
                        break;
                    case 24:
                        char y = Convert.ToChar(121);
                        letter += y;
                        number = Console.ReadLine();
                        break;
                    case 25:
                        char z = Convert.ToChar(122);
                        letter += z;
                        number = Console.ReadLine();
                        break;
                    case 27:
                        char space = Convert.ToChar(32);
                        letter += space;
                        number = Console.ReadLine();
                        break;
                }

            }
            Console.WriteLine(letter);

        }
    }
}
