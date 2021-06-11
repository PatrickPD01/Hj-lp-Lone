using System;
namespace Interface_Segregation
{
    // This is where I store my interface that all characters has in common, heal, die and fight
    // I made interfaces in case i wanted to expand the list with new characters/classes. Interfaces 
    // makes it easier for us to keep a cleaner code and skip duplications of the same code.
    public interface ICharacter
    {
        void Heal();
        void Die();
        void Fight();
    }
}
