using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid9a
{
    public class MyList<T> : IEnumerable<T>
    {
        List<T> list;
        public MyList()
        {
            list = new List<T>();
        }
        public bool Add(T t)
        {
            list.Add(t);
            return true;
        }

        public bool remove(T t)
        {
            return list.Remove(t);
        }

        public override string ToString()
        {
            string str = "[";
            foreach (var item in list)
            {
                str += item + "] -> [";
            }
            return str.Substring(0, str.Length - 1);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in list)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> listus = new MyList<int>();
            for (int i = 0; i < 4; i++)
                listus.Add(i);
            foreach(var item in listus)
                Console.Write(item + "] -> [");
            

        }
    }
}
