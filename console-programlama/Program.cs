﻿using System;

namespace console_programlama
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi Giriniz:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisiminizi Giriniz:");
            string surname =Console.ReadLine();
            Console.WriteLine("Merhaba" + " " + name + " " + surname);
            Console.ReadKey();
        
        
        }
    }
}