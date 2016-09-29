using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            double inputValue;
            int inputType = 0;
            int convertType = 0;
            String[] Types = { "Celcius", "Kelvin", "Reamur", "Fahrenheit" };
            double outputValue = 0;

            Console.WriteLine("Please enter input value: ");
            inputValue = Int32.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Please choose input type:\n[1] for Celcius\n[2] for Kelvin\n[3] for Reamur\n[4] for Fahrenheit");

                inputType = Int32.Parse(Console.ReadLine());

            } while (inputType < 1 || inputType > 4);

            do
            {
                Console.WriteLine("Please choose type to convert to:\n[1] for Celcius\n[2] for Kelvin\n[3] for Reamur\n[4] for Fahrenheit");
                convertType = Int32.Parse(Console.ReadLine());

            } while (convertType < 1 || convertType > 4);

            if(inputType == convertType)
            {
                outputValue = inputValue;
            }
            else if(inputType == 1 && convertType == 2)
            {
                outputValue = inputValue + 273.15;
            }
            else if(inputType == 2 && convertType == 1)
            {
                outputValue = inputValue - 273.15;
            }
            else if(inputType == 1 && convertType == 3)
            {
                outputValue = inputValue * 0.8;
            }
            else if (inputType == 3 && convertType == 1)
            {
                outputValue = inputValue * 1.25;
            }
            else if (inputType == 1 && convertType == 4)
            {
                outputValue = (9 / 5) * (inputValue - 32);
            }
            else if (inputType == 4 && convertType == 1)
            {
                outputValue = (5 / 9) * (inputValue + 32);
            }
            else if (inputType == 2 && convertType == 3)
            {
                outputValue = (inputValue - 273.15) * 0.8;
            }
            else if (inputType == 3 && convertType == 2)
            {
                outputValue = (inputValue * 1.25) + 273.15;
            }
            else if (inputType == 2 && convertType == 3)
            {
                outputValue = (inputValue - 273.15) * 0.8;
            }
            else if (inputType == 3 && convertType == 2)
            {
                outputValue = (inputValue * 1.25) + 273.15;
            }
            else if (inputType == 2 && convertType == 4)
            {
                outputValue = (inputValue * 1.8) - 459.67;
            }
            else if (inputType == 4 && convertType == 2)
            {
                outputValue = (inputValue + 459.67) * (5/9);
            }
            else if (inputType == 3 && convertType == 4)
            {
                outputValue = (inputValue * 2.25) + 32;
            }
            else if (inputType == 4 && convertType == 3)
            {
                outputValue = (inputValue - 32) * (4 / 9);
            }

            Console.WriteLine(inputValue + Types[inputType - 1] + " = " + outputValue + Types[convertType - 1]);
            Console.ReadLine();



        }
    }
}
