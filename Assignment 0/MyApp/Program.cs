using System;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine("Enter Year: ");
            try{
                int year = Convert.ToInt32(Console.ReadLine());
                if(isLeapYear(year)){
                Console.WriteLine("yay");
                }else{
                Console.WriteLine("nay");
                }
            } catch (Exception e){
                Console.WriteLine("Input must be an integer after 1582");
            }
        }

        public static string printName(string name){
            return name;
        }

        public static bool isLeapYear(int year){
            if(year < 1582){
                throw new Exception();
            }
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

