using System;
using System.Collections.Generic;
using System.Linq;


namespace CCG.Core
{
    public struct Card
    {
        public string Title;
        
        public string Description;
        
        public CardAttribute[] Attributes;
        
        public Card(string title,
                    string description, 
                    CardAttribute[] attributes){
            Title = title;
            Description = description;
            Attributes = attributes;
        }
    }
}
