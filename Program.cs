using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Start.Models;
using Start.CustomExceptions;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            //Products p = new Products("iPad", 800, "A tablet for the whole family", 1);

            //p.ShowInformation();

            //p.ChangePrice(750);

            ////p.ShowInformation();

            //Products d = p;

            ////d.ShowInformation();

            //d.SetPrice(100);

            //p.ShowInformation();

            //Create an interface called IAnimal
            //Give it properties for Name, length, 
            //give it one method, MakeSound()

            //create another interface called InformationShower that contains one method 
            //One for ShowInformation()

            //Create two animals that inherit from the interfaces and implement all members

            //Cat c = new Cat("Charles", 30);
            //Dog d = new Dog("Ruffus", 80);

            //d.ShowInformation();

            //c.MakeSound();

            //NumberDivider d = new NumberDivider();

            //d.Divide(25, 0);

            //d.Divide(6, 6);

            //Temperature t = new Temperature(20);

            //t.ChangeTemp(0);

            //Using a try catch and a custom exception, Create a program that asks 
            //a user to how many eggs they would like to purchase. 
            //the user should be able to buy no more than 10 eggs at a time 
            //If the user tries to purchase more than 10 eggs, the should be given 

            //a TooManyEggs exception that you created yourself 


            bool orderAccepted = false;

            while (orderAccepted == false)
            {
                int acceptableOrder;
                Console.WriteLine("Welcom to Egg Central: \nHow many eggs do you want to buy? (Only 10 at a time):");
                acceptableOrder = int.Parse(Console.ReadLine());

                try
                {
                    if (acceptableOrder < 10)
                    {
                        Console.WriteLine("Congratulations! You have bought {0} eggs", acceptableOrder);

                        orderAccepted = true;
                    }
                    else
                    {
                        throw (new TooManyEggsException("Whoa, thats way too many eggs. Please enter an amount of eggs between 1-10"));
                    }
                }
                catch (TooManyEggsException ex)
                {

                    Console.WriteLine(ex.Message.ToString());
                }

            }
        }
    }
}
