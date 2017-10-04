using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start.Models
{
    class Cat: IAnimal, IInformationShower
    {
        public string Name { get; set; }
        public int Length { get; set; }
        public string Sound { get; set; }


        public Cat(string name, int length)
        {
            Name = name;
            Length = length;
            Sound = "Meow";
        }
        public void MakeSound() => Console.WriteLine($"I a a Cat and I go {Sound}");

        public void ShowInformation() => Console.WriteLine($"Cat \nName: {Name} \nLength: {Length} \nSound: {Sound}");
    }
}
