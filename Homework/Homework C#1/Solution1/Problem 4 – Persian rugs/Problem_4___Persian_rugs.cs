using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4___Persian_rugs
{
    class Problem_4___Persian_rugs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int wight = (2 * n) + 1;
            int height = (2 * n) + 1;
            int spase = ((2 * n) + 1) - 2;

            if (d >= n)
            {
                Console.Write(new String('\\', 1));
                Console.Write(new String(' ', spase));
                Console.Write(new String('/', 1));
                Console.WriteLine();

                for (int i = 1; i < (wight / 2); i++)
                {
                    spase -= 2;
                    Console.Write(new String('#', i));
                    Console.Write(new String('\\', 1));
                    Console.Write(new String(' ', spase));
                    Console.Write(new String('/', 1));
                    Console.Write(new String('#', i));
                    Console.WriteLine();
                }

                Console.Write(new String('#', (wight / 2)));
                Console.Write(new String('X', 1));
                Console.Write(new String('#', (wight / 2)));
                Console.WriteLine();

                for (int i = wight / 2; i > 0; i--)
                {

                    Console.Write(new String('#', i - 1));
                    Console.Write(new String('/', 1));
                    Console.Write(new String(' ', spase));
                    Console.Write(new String('\\', 1));
                    Console.Write(new String('#', i - 1));
                    Console.WriteLine();
                    spase += 2;
                }
            }
            else
            {
                spase = d;
                int dot = wight - (2 * d) - 4;
                Console.Write(new String('\\', 1));
                Console.Write(new String(' ', spase));
                Console.Write(new String('\\', 1));
                Console.Write(new String('.', dot));
                Console.Write(new String('/', 1));
                Console.Write(new String(' ', spase));
                Console.Write(new String('/', 1));
                Console.WriteLine();

                int l = (2 * d) + 1;
                for (int i = 1; i < wight / 2; i++)
                {
                    dot -= 2;
                    if (dot > 0)
                    {
                        spase = d;
                        Console.Write(new String('#', i));
                        Console.Write(new String('\\', 1));
                        Console.Write(new String(' ', spase));
                        Console.Write(new String('\\', 1));
                        Console.Write(new String('.', dot));
                        Console.Write(new String('/', 1));
                        Console.Write(new String(' ', spase));
                        Console.Write(new String('/', 1));
                        Console.Write(new String('#', i));
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write(new String('#', i));
                        Console.Write(new String('\\', 1));
                        Console.Write(new String(' ', l));
                        Console.Write(new String('/', 1));
                        Console.Write(new String('#', i));
                        Console.WriteLine();
                        l -= 2;
                    }
                }

                Console.Write(new String('#', (wight / 2)));
                Console.Write(new String('X', 1));
                Console.Write(new String('#', (wight / 2)));
                Console.WriteLine();

                spase = 1;
                for (int i = wight / 2; i > 0; i--)
                {
                    Console.Write(new String('#', i - 1));
                    Console.Write(new String('/', 1));
                    Console.Write(new String(' ', spase));
                    Console.Write(new String('\\', 1));
                    Console.Write(new String('#', i - 1));
                    Console.WriteLine();
                    spase += 2;

                    if (spase > (2 * d) + 1)
                    {
                        break;
                        
                    }
                }

                int o = 1;
                for (int j = (wight / 2) - 1 - d; j > 0; j--)
                {
                    Console.Write(new String('#', j - 1));
                    Console.Write(new String('/', 1));
                    Console.Write(new String(' ', d));
                    Console.Write(new String('/', 1));

                    Console.Write(new String('.', o));

                    Console.Write(new String('\\', 1));
                    Console.Write(new String(' ', d));
                    Console.Write(new String('\\', 1));
                    Console.Write(new String('#', j - 1));
                    Console.WriteLine();
                    o += 2;
                }
            }
        }
    }
}

