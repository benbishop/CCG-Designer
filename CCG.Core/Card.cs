using System;
using System.Collections.Generic;
using System.Linq;


namespace CCG.Core
{
    public struct Card
    {
        public const string NoDescription = "";
        

        
        public string Title;
        
        public string Description;
        
        public CardAttribute[] Attributes;
        
        public Card(string title,
                    CardAttribute[] attributes,
                    string description = NoDescription){
            Title = title;
            Description = description;
            Attributes = attributes ?? new CardAttribute[0];
           
            
            if(title == null)
                throw new ArgumentNullException("Title cannot be null");                                
                
        }
    }
}
