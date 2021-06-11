using System;
namespace Interface_Segregation
{
    // I made interfaces in case i wanted to expand the list with new characters/classes.
    public interface ITeleport 
    {
        void Teleport(int x, int y);
        
    }
}
