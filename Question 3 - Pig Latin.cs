using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
    string[] words = "The quick brown fox".Split(" ");
    foreach(var st in words){
        var rt = st[1..];
        var et = st[0];
        Console.WriteLine(rt + et +"ay");
    }
        
    }
    
}
