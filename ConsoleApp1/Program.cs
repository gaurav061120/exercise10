using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

class program
{
    static void Main(string[]args)
    {
        int[] initialData = { 10, 20, 30, 40, 50 };
        using (var largeDataCollection = new LargeDataCollection(initialData))
        {
            largeDataCollection.PrintElements();
            largeDataCollection.AddElement(60);
            largeDataCollection.AddElement(70);
            largeDataCollection.PrintElements();
           
            largeDataCollection.RemoveElement(30);
            largeDataCollection.PrintElements();
           
            Console.WriteLine("program complete");
        }
    }
}

  
    
    
        