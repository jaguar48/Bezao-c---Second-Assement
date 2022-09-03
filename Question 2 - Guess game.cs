
using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {   
        int user_tries = 0;
        while (user_tries <= 5)
        {
            user_tries +=1;
            
        Console.WriteLine("Guess secret number between range 1-5");
        int enter_number = int.Parse(Console.ReadLine());
        Random rd = new Random();
        int rand_num = rd.Next(5);
       if (enter_number < rand_num){
            Console.WriteLine("Mininum than target");
        }
        
        else if ( enter_number > rand_num ){
            Console.WriteLine("Maxmimum than target");
        }
       else{
            Console.WriteLine($"that's correct Secret number is:{rand_num}");
            break;
       }
       
        Console.WriteLine($"random number is {rand_num}");
                Console.WriteLine($"Try {user_tries}");
        }
        
        
        Console.WriteLine($"Total tries {user_tries}");
        
    }
}
