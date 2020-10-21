using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var lstNumber = new List<string>();

            for (int k =0; k <=5; k++)
            {

                string s = string.Empty;
                for (int i = 0; i < 18; i++)
                {
                    s = String.Concat(s, random.Next(10).ToString());
                    
                }
                lstNumber.Add(s);
            }

            
        }



    }
}
