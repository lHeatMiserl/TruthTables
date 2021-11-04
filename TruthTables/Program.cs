using System;

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
                            logicFunction = new Conjunction();
                            break;
                        case "3":
                            logicFunction = new AntiImplication();
                            break;
                        case "4":
                            logicFunction = new XVariable();
                            break;
                        case "5":
                            logicFunction = new AntiReplication();
                            break;
                        case "6":
                            logicFunction = new YVariable();
                            break;
                        case "7":
                            logicFunction = new ExclusiveOr();
                            break;
                        case "8":
                            logicFunction = new Disjunction();
                            break;
                        case "9":
                            logicFunction = new PierFunction();
                            break;
                        case "10":
                            logicFunction = new Equivalence();
                            break;
                        case "11":
                            logicFunction = new NegateVariableY();
                            break;
                        case "12":
                            logicFunction = new Replication();
                            break;
                        case "13":
                            logicFunction = new NegateVariableX();
                            break;
                        case "14":
                            logicFunction = new Implication();
                            break;
                        case "15":
                            logicFunction = new SchaeffersStroke();
                            break;
                        case "16":
                            logicFunction = new OneGenerator();
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
