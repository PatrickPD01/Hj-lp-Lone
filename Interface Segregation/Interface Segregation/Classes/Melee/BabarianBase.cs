using System;
namespace Interface_Segregation
{
    // Here I store my Babarian class with the following interfaces 
    public class BabarianBase : ICharacter, IBash, ICleave, ISlash
    {
        // The different spells / abilities for the specific class
        public void Bash()
        {
            Console.WriteLine("I'm bashing someone");
        }

        public void Cleave()
        {
            Console.WriteLine("I'm cleaving someone");
        }

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

        public void Slash()
        {
            Console.WriteLine("I'm slashing someone");
        }
    }
}