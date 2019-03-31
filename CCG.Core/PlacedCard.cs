using System;
using System.Collections.Generic;
using System.Linq;


namespace Library
{
    public class PlacedCard
    {
        private bool faceUp = false;
	    public bool IsFaceUp{ get => faceUp; }
	    
	    public void TurnFaceUp() => faceUp = true;
	    
	    public void TurnFaceDown() => faceUp = false;
	    
	    
    }
}
