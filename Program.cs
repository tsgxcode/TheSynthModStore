﻿using System;
using System.IO;

namespace TheSynthModStore
{
    internal class Program
    {
        public static string OSC { get; set; }
        public static string GrainDelay { get; set; }



        static void Main()
        {
            Console.WriteLine("The Synth Mod Store");

            //Place an oder for Modular Synth moduals
            Console.Write("Osc? ");
            OSC = Console.ReadLine();
            Console.Write("GrainDelay? ");
            GrainDelay = Console.ReadLine();

            string fullText = (OSC + "." + GrainDelay + ".");

            File.AppendAllText(@"Data.txt", fullText + Environment.NewLine);

        }

        //Reading files 
        public static void OutPutLog()
        {
            // Reads from csv, txt, etc. and displays the current database info
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(directory.FullName, "Data.txt");
            var fileContents = ReadFile(fileName);
            string[] fileLines = fileContents.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in fileLines)
            {
                Console.WriteLine(line);
            }
        }



        public static string ReadFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }
        }




        //Check current invantory
        public static void Invantory()
        {

        }

        //Purchase more Synth moduals
        public static void PurcheseMoreMods()
        {
            
        }

        //Remover overstock
        public static void RemoveOverStock()
        {

        }
    }
}