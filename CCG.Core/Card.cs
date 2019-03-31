using System;
using System.Collections.Generic;
using System.Linq;


namespace CCG.Core
{
    public struct Card
    {
        public string Title;
        
        public CardAttribute[] Attributes;
        
        public Card(string title, CardAttribute[] attributes){
            Title = title;
            Attributes = attributes;
        }
    }
}
