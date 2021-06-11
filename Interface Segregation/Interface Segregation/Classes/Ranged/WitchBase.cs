using System;
namespace Interface_Segregation
{
    // Here I store my Witch class with the following interfaces 
    public class WitchBase : ICharacter, IFrostNova, ITeleport
    {
        // The different spells / abilities for the specific class
        public void Die()
        {
            Console.WriteLine("I'm dying");
        }

        public void Fight()
        {
            Console.WriteLine("I'm fighting");
        }

        public void Heal()
        {
            Console.WriteLine("I'm healing");
        }

        public void Teleport(int x, int y)
        {
            Console.WriteLine("I'm teleporting to " + x + " " + y);
        }

        public void ThrowFrostNova()
        {
            throw new NotImplementedException();
        }
    }
}