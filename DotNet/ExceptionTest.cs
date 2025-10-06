using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet
{
    public class ExceptionTest
    {
        public void InnerExeption()
        {
           
                Console.WriteLine("inside try inner");
                throw new Exception();
        }

        public void ExeptionHandling()
        {
            try
            {
                InnerExeption();
                int number1 = 10;
                int number2 = 0;
                int[] array = new int[2] ;
                array[0]= number1;
                array[1]= number2;
                int resut = (number1 / number2);
                Console.WriteLine(resut);
            }
          
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (StackOverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"from parent {ex.ToString()}");
            }

        }
    }
}
