using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionPartTwo
{
    internal class PermiumMember: GymMember,IGmMemberShip
    {
        public PermiumMember(string name, int age) : base(name, age) { }
        public override void DisplayMembershipDetails()
        {
            Console.WriteLine($"Permium Member: {Name}, Age: {Age}");
            Console.WriteLine("Access all gym facilities Personalized training session");
            Console.WriteLine("Specialized Classes include");
        }
    }
}
