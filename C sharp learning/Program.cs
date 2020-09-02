using System;
using System.Collections.Generic; //массив, списки.
using System.ComponentModel;
using System.Globalization;
using System.Net;

namespace C_sharp_learning
{

    class Animal
    {

        public string name = "";
        public string vid = "";
        public int age = 7;
        public float hapiness = 0.6f;
        public static int level = 0;

        /*public Animal()
        {
            name = "";
            vid = "";
            age = ' ';
            hapiness = ' ';
        }*/




        public void Output()
        {
            Console.WriteLine("Animal is " + vid);
            Console.WriteLine("The name yours animal is " + name);
            Console.WriteLine("The age yours animal is " + age);
            Console.WriteLine("The hapiness yours animal is " + hapiness);
        }

        

        public void Print()
        {
            Console.WriteLine("Enter animals :");
            vid = Console.ReadLine();
            Console.WriteLine("Enter animal name :");
            name = Console.ReadLine();
            Console.WriteLine("Enter animal age :");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter animal hapiness :");
            hapiness = Convert.ToInt32(Console.ReadLine());
        }
    }



    class MainClass
    {
        static void Main(string[] args) //метод срабатывает при старте программы
        {
            Animal cat = new Animal();
            Animal dog = new Animal();
            cat.Print();
            cat.Output();
            Console.WriteLine("Animals: " + Animal.level++);
            Console.WriteLine(Animal.level);
            Console.ReadKey();           
        }
    }
     

}
