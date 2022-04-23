﻿using System;

namespace OS_Practice_6
{
    enum MemoryType { 
        FixedSections = 1,
        RoamingSections = 2,
        VariableSections = 3
    }
    class Program
    {
        public static MemoryType OS_SelectType()
        {
            Console.WriteLine(" Выберите алгоритм управления памятью:");
            Console.WriteLine("  1. Распределение памяти фиксированными разделами");
            Console.WriteLine("  2. Распределение памяти перемещаемыми разделами");
            Console.WriteLine("  3. Распределение памяти разделами переменной величины");
            Console.WriteLine("  4. Страничное распределение памяти");
            Console.WriteLine("  5. Страничное распределение памяти (упрощённый вариант)"); 
            Console.WriteLine("  6. Сегментное распределение памяти");
            Console.WriteLine("  7. Странично-сегметное распределение памяти");
            Console.WriteLine("  8. Свопинг");
            Console.Write(" > ");
            return (MemoryType)OS_Inputing.OS_Int(1, 8);
        }
        static void Main(string[] args)
        {
            MemoryType selection = OS_SelectType();
            switch (selection)
            {
                case MemoryType.FixedSections:
                    Console.Clear();
                    Console.WriteLine(" 1. Распределение памяти фиксированными разделами\n");
                    Console.WriteLine(" На сколько разделов вы хотите разделить оперативную память?");
                    Console.Write(" > ");
                    int c1 = OS_Inputing.OS_Int(1, OS_Inputing.Infinity);
                    _ = new FixedSections(c1);
                    break;
                case MemoryType.RoamingSections:
                    Console.Clear();
                    Console.WriteLine(" 2. Распределение памяти перемещаемыми разделами\n");
                    Console.WriteLine(" На сколько разделов вы хотите разделить оперативную память?");
                    Console.Write(" > ");
                    int c2 = OS_Inputing.OS_Int(1, OS_Inputing.Infinity);
                    _ = new RoamingSections(c2);
                    break;
                case MemoryType.VariableSections:
                    _ = new VariableSections();
                    break;
                default:
                    break;
            }
        }
    }
}
