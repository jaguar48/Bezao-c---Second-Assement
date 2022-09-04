

using System;

public class HelloWorld
{ 
        public static void pig_latin(string words) 
        {
            string[] word = words.Split(" ");
            foreach(var st in word){
                var rt = st[1..];
                var et = st[0];
                Console.WriteLine(rt + et +"ay");
            }
        }

    public static void Main(string[] args)
    {
         pig_latin("I just got executed!");
     
    }
}
