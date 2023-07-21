using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LargeDataCollection : IDisposable
    {


        int[] data;
        public LargeDataCollection(int[] initialData)
        {
            data = new int[initialData.Length];
            initialData.CopyTo(data, 0);

        }
        public void AddElement(int element)
        {
            Array.Resize(ref data, data.Length + 1);
            data[data.Length - 1] = element;
        }

        public void Dispose()
        {
            
            data = null;
            GC.SuppressFinalize(this);
        }

        public void RemoveElement(int element)
        {
            int index = Array.IndexOf(data, element);
            if (index >= 0)
            {
                for (int i = index; i < data.Length - 1; i++)
                {
                    data[i] = data[i + 1];
                }
                Array.Resize(ref data, data.Length - 1);
            }
        }
        public void PrintElements()
        {
            Console.WriteLine("element in the collection");
            foreach (var element in data)
            {
                Console.WriteLine(element + " ");

            }
            Console.WriteLine();

        }
    
           
        }
    }


    




