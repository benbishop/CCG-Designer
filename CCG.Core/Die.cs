using System;
using System.Collections.Generic;
using System.Linq;


namespace CCG.Core
{
    public class Die
    {
        private static Random Ran = new Random();
        
        protected readonly uint Sides;
        
        public Die(uint sides = 6){
            Sides = sides;
        }   
        
        public uint Roll(){
            return (uint)Ran.Next(1, (int)Sides + 1);
        }
    }
}
