using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Models
{
    public abstract class Animal

    {
        public int AnimalLeg { get; set; }
        public bool AnimalTail { get; set; }
        public bool AnimalHorn { get; set; }
        public int HornCount { get; set; }
        public Animal() { }
        
        
   
        
    }

    public sealed class Elephant : Animal
    {

        public Elephant(int AnimalLeg, int HornCount, bool AnimalTail, bool AnimalHorn) : base()
        {
            Console.WriteLine("This Animal has {0} legs.",AnimalLeg);
           if (AnimalTail == true)
            {
                Console.WriteLine("This Animal has a tail.");
            }
            else
            {
                Console.WriteLine("This animal doesnt have a tail.");
            }
            if(AnimalHorn== true&&HornCount>1)
            {
                Console.WriteLine("This Animal has {0} horns.",HornCount);
            }
            else if(AnimalHorn==true&&HornCount ==1) 
            {
                Console.WriteLine("This Animal has a horn.");
            }
            else if (AnimalHorn == false)
            {
                Console.WriteLine("This Animal doesnt have a horn.");
            }
                
        }

    }
}
