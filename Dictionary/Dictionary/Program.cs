using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionaryy<int, int> dict= new Dictionaryy<int, int>(5);
            dict.Add(1, 2);
            dict.Add(2, 2);
            dict.Add(3, 2);
            dict.Add(4, 2);
            dict.Add(1, 2);
            dict.Update(2, 5);
            dict.Delete(2);
            for (int i = 0; i < dict.Count; i++)
            {
                Console.WriteLine($"{dict.Key[i]}, {dict.Value[i]}");
            }
        }
    }
}
