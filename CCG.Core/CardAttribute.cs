using System;

namespace CCG.Core
{
    public struct CardAttribute
    {
        public const int NoValue = 0;
        
        public const string NoUnits = "";   
        
        public string Name;
        public int Value;
        public string Units;
        
        public CardAttribute(string name, 
                             int value = NoValue,
                             string units = NoUnits){

            Name = name;
            Value = value;
            Units = units;

            if(name == null)
                throw (new ArgumentNullException("Name cannot be null"));            
        }
    }
}
