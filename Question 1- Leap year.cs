using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
int cuurent_year = 2022;
int count_years = 0;
while (count_years < 20){
    cuurent_year = cuurent_year +1;
   if((cuurent_year % 4 ==0)){
       count_years ++;
        Console.WriteLine (cuurent_year);
   }
}

        
    }
}
