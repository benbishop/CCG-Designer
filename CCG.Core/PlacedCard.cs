using System;
using System.Collections.Generic;
using System.Linq;


namespace CCG.Core
{
    public class PlacedCard
    {
        private bool faceUp = false;
	    public bool IsFaceUp{ get => faceUp; }
	    
	    public void TurnFaceUp() => faceUp = true;
	    
	    public void TurnFaceDown() => faceUp = false;
	    
	    protected Dictionary<Guid, Counter> CounterMap = new Dictionary<Guid, Counter>();
	    
	    
	    public Guid AddCounter(Counter counter){
	        var id = Guid.NewGuid();
	        CounterMap[id] = counter;
	        return id;
	       
	    }
	    
	    public void RemoveCounter(Guid counterId){
	        CounterMap.Remove(counterId);
	    }
    }
}
