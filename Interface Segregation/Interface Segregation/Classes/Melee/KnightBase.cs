using System;
namespace Interface_Segregation
{
    // Here I store my Knight class with the following interfaces 
    public class KnightBase : ICharacter, IBash, ISlash, IRaiseShield, IShieldGlare
    {
        // The different spells / abilities for the specific class
        public void Bash()
        {
            Console.WriteLine("I'm bashing someone");
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

        public void RaiseShield()
        {
            Console.WriteLine("I'm raising my shield");
        }

        public void ShieldGlare()
        {
            Console.WriteLine("I'm throwing shield glare");
        }

        public void Slash()
        {
            Console.WriteLine("I'm slashing someone");
        }
    }
}