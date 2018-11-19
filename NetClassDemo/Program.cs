using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //FUNC-封装一个具有一个参数并返回TRESULT参数指定的类型值的方法 一种委托
            Func<int, bool> f1 = IsNumberLessThen5;
            bool flag = f1(4);

            Func<int, bool> f2 = i => i < 5;

            Func<int, bool> f3 = (i) => { return i < 5; };

            Func<int, bool> f4 = delegate (int i) { return i < 5; };
            Console.WriteLine(f4(5));

            Console.Read();
        }

        private static bool IsNumberLessThen5(int number)
        {
            if (number<5)
            {
                return true;
            }
            return false;
        }
    }
}
