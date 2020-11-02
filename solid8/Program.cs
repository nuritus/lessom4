using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter number:");
                int num = int.Parse(Console.ReadLine());
                num = 10 / num;
                Console.WriteLine(num);
               // throw new FormatException();
                throw;
            }
            catch (FormatException)
            {
                Console.WriteLine("The value must be numeric");
                throw;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Can't divide by zero:");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message); //"מחרוזת קלט לא היתה בתבנית הנכונה"
            }
           // catch { Console.WriteLine("Error"); }
                Console.WriteLine("help");
            }
        }
    }

Enter number:1
10
System.FormatException
אחד הפריטים הניתנים לזיהוי היה בתבנית לא חוקית.
help
Press any key to continue . . .