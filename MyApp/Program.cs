using System;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            printName("Jonas");
        }

        public static string printName(string name){
            return name;
        }

        public static bool isLeapYear(int year){
            if((year % 400) == 0){
                return true;
            }else if((year % 100) == 0){
                return false;
            }else if((year % 4) == 0){
                return true;
            }else{
                return false;
            }
        }

    }

    
}

