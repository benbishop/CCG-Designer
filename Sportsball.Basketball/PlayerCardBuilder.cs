using System;
using System.Collections.Generic;
using System.Linq;
using CCG.Core;

namespace Sportsball.Basketball
{
    public class PlayerCardBuilder:CardBuilder
    {
        public PlayerCardBuilder WithRebound(uint minRoll){
            
            WithAttribute(BasketballPlayer.ReboundMinRoll, (int)minRoll);
            
            return this;
        }        
        
        public PlayerCardBuilder WithStamina(uint stamina){
            //todo: add this
            return this;
        }
    }
}
