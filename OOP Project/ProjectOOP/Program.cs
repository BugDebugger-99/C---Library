using System;
using System.Runtime.InteropServices;
namespace OOP
{


    //? -----------------> Encapsulation <---------------------
    public class Bank
    {
        private double balance = 3000;

        public void Deposit()
        {
            Console.Write("Enter Amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (amount > 0)
            {
                balance += amount;
               Console.Clear();
                Console.WriteLine($"Deposited: {amount}");
            }
            else
            {
                Console.WriteLine("Invalid amount");
            }
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Balance: {balance}");
        }
    }


    //? ----------> Inheritance <-----------------
    class Animal
    {
        public void Eat(){
            Console.WriteLine("It Eats");
        }
        
    }
    class Dog : Animal
    {
        public void Sound(){

        Console.WriteLine("It Barks");
        }
    }

    //? ---------> Polymorphism <---------
    class Shape
    {
        public virtual void Draw(){
            Console.WriteLine("I am Shape...");
        }
    }
    class Square : Shape
    {
        public override void Draw(){
            Console.WriteLine("I am Square...");
        }
    }
    class Cirlce : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("I am Circle...");
        }
    }





    public class Program
    {
        public static void Main()
        {
            // -------> Encapsulation <-------------
            // Bank b = new Bank();
            // b.Deposit();
            // b.CheckBalance();

            //-----------> Inheritance <----------------
            // Dog d = new Dog();
            // d.Sound();
            // d.Eat();

            //----------> Polymorphism <------------
            Shape myShape;
            myShape = new Shape();
            myShape.Draw();
            myShape = new Square();
            myShape.Draw();
            myShape = new Cirlce();
            myShape.Draw();
            
            










        }
    }

}