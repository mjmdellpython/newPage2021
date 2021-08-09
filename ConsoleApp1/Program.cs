using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using static System.Console;

namespace ConsoleApp1
{

        class Program
    {

        public enum Color
        {
            Red, Green, Blue
        }

        public enum Size
        {
            Small, Medium, Large, Yuge
        }

        public class product
        {
            public string Name;
            public Color color;
            public Size size;

            public product(string n,Color c , Size s)
            {
                Name = n;
                color = c;
                size = s;
            }
        }


        //public class filter
        //{
        //    public IEnumerable<product> filterSize(IEnumerable<product>products, Color color) 
        //    {
        //        foreach (var item in products)
        //        {
        //            if (item.color == color)
        //            {
        //                yield return item;
        //            }

        //        }
        //    }
        //}


        public class Filter
        {
            public IEnumerable<product> fliterColor(IEnumerable<product>p, Color color)
            {
                foreach (var item in p)
                {
                    if (item.color == color)
                    {
                        yield return item;
                    }
                }
                
            }

            
        } 

        public interface ISspecification<T>
        {
            bool IsSpecificatoin(product p);
        }

        public interface Ifilter<T>
        {
            IEnumerable<T> Filter(IEnumerable<T> items, ISspecification<T> spec);
        }

        public class ColorSpecification:ISspecification<product>
        {
            private Color color;
            public ColorSpecification(Color c)
            {
                color = c;
            }

            public bool IsSpecificatoin(product p)
            {
                return p.color==color;
            }


        }

        public class BetterFilter : Ifilter<product>
        {
            public IEnumerable<product> Filter(IEnumerable<product> items, ISspecification<product> spec)
            {
                foreach (var i in items)
                    if (spec.IsSpecificatoin(i))
                        yield return i;
            }
        }


        static void Main(string[] args)
        {

            var apple = new product("Apple", Color.Green, Size.Small);
            var tree = new product("Tree", Color.Green, Size.Large);
            var house = new product("House", Color.Blue, Size.Large);

            var fp = new Filter();

            product[] pros = {apple, tree, house };

            //foreach (var i in fp.fliterColor(pros,Color.Green))
            //{
            //    Console.WriteLine(i.Name);
            //}

            var bf = new BetterFilter();
            WriteLine("Green products (new):");
            foreach (var p in bf.Filter(pros, new ColorSpecification(Color.Green)))
                WriteLine($" - {p.Name} is green");
        }
    }
}
