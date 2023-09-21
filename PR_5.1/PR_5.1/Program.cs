//************************
//*Проверочная Работа №5 *
//*Поогудин Павел 2ИСП   *
//************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая работа №5";

            int N, M;

            Console.WriteLine("Здраствуйте!");
            Console.Write("Введите N = ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите M = ");
            M = Convert.ToInt32(Console.ReadLine());

            Console.Write("Это карта ");
            if (N < 7)
                Console.Write("Шесть");
            else { if (N < 8)
                    Console.Write("Семь");
                else { if (N < 9)
                      Console.Write("Восемь");
                    else { if (N < 10)
                            Console.Write("Девять");
                        else { if (N < 11)
                                Console.Write("Десять");
                            else { if (N < 12)
                                    Console.Write("Валет");
                                else { if (N < 13)
                                        Console.Write("Дама");
                                    else { if (N < 13)
                                            Console.Write("Король");
                                        else {
                                            Console.Write("Туз");
                             
                                        }; 
                                    }; 
                                }; 
                            }; 
                        }; 
                    }; 
                }; 
            };
            if (M < 2)
                Console.Write(" бубны");
            else
            {
                if (M < 3)
                    Console.Write(" трефы");
                else
                {
                    if (M < 4)
                        Console.Write(" черви");
                    else
                        Console.Write(" пики");
                }
            }
            Console.ReadKey();
        }
    }
}