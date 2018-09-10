using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsChash
{
  
    class Program
    {
        static void Main()
        {
             ArrayList da = new ArrayList();
            //Add
            da.Add("Visual Basic");
            da.Add(100);
            da.Add(55);
           //Remove
            da.Remove(55);

            foreach (object ob in da)
            {
                Console.WriteLine(ob);
            }
            List<string> str = new List<string>();
            str.Add("Name");
            str.Add("Address");

            foreach (object obj in str)
            {
                if(obj.Equals("Name"))
                
                Console.WriteLine(obj);
                
            }
            Console.ReadLine();
        }
    }
}