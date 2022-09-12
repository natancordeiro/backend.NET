﻿using System;
//                                VÍDEO PAULSADO M07A08 - 3:12
namespace StopWatch 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Menu();
        }

        static void Menu() 
        {
            Console.Clear();
            Console.WriteLine("S - Segundo => 10s = 10 segundos");
            Console.WriteLine("M - Minuto => 1m = 1 minuto");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Quanto tempo deseja contar? ");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length -1, 1)); // Substring fraciona string (inicio, fim)
            int time = int.Parse(data.Substring(0, data.Length -1));

            int multiplier = 1;

            if(time == 'm') 
                multiplier = 60;

            if(time == 0)
                System.Environment.Exit(0);

            Start(time * multiplier);
        }

        static void Start(int time) 
        {
            int currentTime = 0;
        //  tempo atual

            while (currentTime != time) 
            {
                Console.Clear();
                currentTime ++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000); // Parâmetro em milisegundos 1000 = 1s
            }

            Console.Clear();
            Console.WriteLine("StopWatch finalizado!");
            Thread.Sleep(2500);
        }
    }
}