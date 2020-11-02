using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// מקביל לדוגמא Ex2
/// אילוצים
/// </summary>
namespace solid12
{/// <summary>
/// דוגמא 1  - אילוץ שמחלקה יורשת ממחלקה
/// U  הוא האבא, ולכן אפשר לעשות מערך משותף לשניהם
/// </summary>
/// <typeparam name="T"></typeparam>
/// <typeparam name="U"></typeparam>
    public class GenericWhere1<T, U> where T : U
    {
        U[] arr;
        public GenericWhere1(T t, U u)
        {
            arr = new U[] { t, u };
        }
    }
    /// <summary>
    /// דוגמא 2: הפרמטר הגנרי הוא מחלקה, ולכן יכול היות מאותחל ב
    /// NULL
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericWhere2<T> where T : class
    {
        T t;
        public GenericWhere2()
        {
            t = null;
        }
    }

    class Animal { }
    class Fish : Animal { }
    class Program
    {
        static void Main(string[] args)
        {
            Animal a =new Animal();
            Fish b = new Fish();
            GenericWhere1<Animal, Fish > my= new GenericWhere1<Fish,Animal>(b,a);
        }
    }
}


