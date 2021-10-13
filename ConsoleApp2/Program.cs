using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("aaa");
            list.RemoveAt(0);

            MyList<string> myList = new MyList<string>();
            myList.Add("AAA");
            myList.Add("BBB");
            myList.Add("CCC");
            myList.RemoveFirst();
            myList.Clear();

            List<int> list2 = new List<int>();
            MyList<int> myList2 = new MyList<int>();
            myList2.Add(2);
            myList2.Add(3);
            myList2.Add(4);
            myList2.RemoveFirst();
            myList2.Clear();
            double x = -2;
            double result;
            
            try
            {
                result = Sqrt(x);
            }
            catch
            {
                x = -x;
            }
            finally
            {
                result = Sqrt(x);
            }
            Console.ReadLine();
        }

        static double Sqrt(double x)
        {
            if (x < 0) throw new IndexOutOfRangeException("Нельзя сотворить здесь");
            return Math.Sqrt(x);
        }
    }
}
