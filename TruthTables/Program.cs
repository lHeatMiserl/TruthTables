using System;
using System.Collections.Generic;

namespace TruthTables
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] functionName = { "Генератор нуля",
                "Конъюнкция",
                "Антиимпликация",
                "Переменная Х",
                "Антирепликация",
                "Переменная У",
                "Исключающее ИЛИ",
                "Дизъюнкция",
                "Функция Пирса",
                "Эквиваленция",
                "Отрицание переменной У",
                "Репликация",
                "Отрицание переменной Х",
                "Импликация",
                "Штрих Шеффера",
                "Генератор единицы"};

            Calculator calculator = new Calculator();

            while (true)
            {               
                try
                {
                    string logicFunctionName = default;
                    TableResult logicFunction = null;
                    Console.WriteLine("Список функций");
                    for (int i = 0; i < functionName.Length; i++)
                    {
                        Console.WriteLine($"{i+1}. {functionName[i]}");
                    }

                    Console.Write("\nВыберите номер функции:");
                    string functionNumber = Console.ReadLine();

                    switch (functionNumber)
                    {
                        case "1":
                            logicFunction = new ZeroGenerator();
                            break;
                        case "2":
                            logicFunction = new F2();
                            break;
                        case "3":
                            logicFunction = new F3();
                            break;
                        case "4":
                            logicFunction = new F4();
                            break;
                        case "5":
                            logicFunction = new F5();
                            break;
                        case "6":
                            logicFunction = new F6();
                            break;
                        case "7":
                            logicFunction = new F7();
                            break;
                        case "8":
                            logicFunction = new F8();
                            break;
                        case "9":
                            logicFunction = new F9();
                            break;
                        case "10":
                            logicFunction = new F10();
                            break;
                        case "11":
                            logicFunction = new F11();
                            break;
                        case "12":
                            logicFunction = new F12();
                            break;
                        case "13":
                            logicFunction = new F13();
                            break;
                        case "14":
                            logicFunction = new F14();
                            break;
                        case "15":
                            logicFunction = new F15();
                            break;
                        case "16":
                            logicFunction = new F16();
                            break;

                    }

                    if (logicFunction is null)
                    {
                        throw new Exception("Указанная функция не существует.");
                    }

                    Console.WriteLine("\nТаблица истинности");
                    Console.WriteLine("\nX\tY\tF\n");
                    for (int x = 0; x < 2; x++)
                    {
                        for (int y = 0; y < 2; y++)
                        {
                            Console.WriteLine($"{x}\t{y}\t{Calculator.CalculateValue(logicFunction, x, y)}");
                        }
                    }
                    
                    Console.ReadLine();
                    Console.Clear();
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
            }         
        }
    }
}
