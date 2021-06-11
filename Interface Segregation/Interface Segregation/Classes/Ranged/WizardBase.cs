using System;
namespace Interface_Segregation
{
    // Here I store my Wizard class with the following interfaces 
    public class WizardBase : ICharacter, IFrostNova, ITeleport, IMagicMissile
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
            Console.WriteLine("I'm throwing my frost nova");
        }

        public void ThrowMagicMisile()
        {
            Console.WriteLine("I'm throwing a magic misile");
        }
    }
}