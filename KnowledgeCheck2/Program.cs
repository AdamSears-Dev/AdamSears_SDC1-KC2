using System;
using System.Collections.Generic;

namespace KnowledgeCheck2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<Shure>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var shure = new Shure();

                Console.WriteLine("Enter the model for Shure mic #" + (i + 1));
                shure.Model = Console.ReadLine();

                Console.WriteLine("Enter the sensitivity for Shure mic #" + (i + 1));
                shure.Sensitivity = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the low frequency response for Shure mic #" + (i + 1));
                shure.FrequencyResponseLow = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the high frequency response for Shure mic #" + (i + 1));
                shure.FrequencyResponseHigh = int.Parse(Console.ReadLine());

                recordList.Add(shure);
            }

            // Print out the list of records using Console.WriteLine()
            foreach (var shure in recordList)
            {
                Console.WriteLine($"Model: {shure.Model}, Sensitivity: {shure.Sensitivity}, Low Frequency Response: {shure.FrequencyResponseLow}, High Frequency Response: {shure.FrequencyResponseHigh}");
            }
        }
    }
}
