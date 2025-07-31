using System;
using System.Security.Cryptography.X509Certificates;


class Program
{
    static void Main(string[] args)
    {
        Dog dog1 = new Dog();
        dog1.makeSound();
        Cat cat1 = new Cat();
        cat1.makeSound();
    }

    public class Animal
    {
        public virtual void makeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    public class Dog : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    public class Cat : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Meow");
        }
    }



    
}