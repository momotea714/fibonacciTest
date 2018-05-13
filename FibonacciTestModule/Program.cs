using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciTestModule
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }


    public static class Test1_static_class
    {
        public static int Test1_int_property { get; set; }

        public static int Test1Method_static_int(int a)
        {
            return a + Test1_int_property;
        }

        public static List<int> Test1Method_static_int(List<int> a)
        {
            a.ForEach(x => x = x + Test1_int_property);
            return a;
        }
    }

    public class Test2_class
    {
        public int Test2_int_property { get; set; }

        public int Test2_int(int a)
        {
            return a + Test2_int_property;
        }

        public List<int> Test1Method_static_int(List<int> a)
        {
            a.ForEach(x => x = x + Test2_int_property);
            return a;
        }
    }

    public class Test3_ModelClass
    {
        public int Test3_int_property { get; set; }
        public string Test3_string_property { get; set; }
    }

    public class Test3_Class
    {
        public Test3_ModelClass Test3_RerutnModelClass(int a,string b)
        {
            return new Test3_ModelClass {Test3_int_property = a,Test3_string_property =  b};
        }

    }

}
