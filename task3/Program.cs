using System;


class Program
{


    static void Main(string[] args)
    {

        Car car1 = new Car();
        car1.Move();
        Bicycle bicycle1 = new Bicycle();
        bicycle1.Move();


    }


    public interface IMovable
    {
        void Move();
    }

    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("The car is moving");
        }
    }

    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("The bicycle is moving");
        }
    }



}