using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start.Models
{
    class Dog : IAnimal, IInformationShower
    {
        public string Name { get ; set ; }
        public int Length { get; set ; }
        public string Sound { get; set; }


        public Dog(string name, int length)
        {
            Name = name;
            Length = length;
            Sound = "Woof";
        }
        public void MakeSound()
        {
            Console.WriteLine($"I a a dog and I go {Sound}");
        }

        public void ShowInformation()
        {
            Console.WriteLine($"Dog \nName: {Name} \nLength: {Length} \nSound: {Sound}");
        }
    }
}
