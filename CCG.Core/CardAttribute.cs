using System;
using System.Collections.Generic;
using System.Linq;


namespace CCG.Core
{
    public struct CardAttribute
    {
        public string Name;
        public int Value;
        
        public CardAttribute(string name, int value){
            Name = name;
            Value = value;
        }
    }
}
