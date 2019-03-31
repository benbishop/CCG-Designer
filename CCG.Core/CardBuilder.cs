using System;
using System.Collections.Generic;
using System.Linq;


namespace CCG.Core
{
    public class CardBuilder
    {
        protected List<CardAttribute> Attributes = new List<CardAttribute>();
        
        protected string Title = "";
        
        protected string Description = "";
        
        public CardBuilder WithAttribute(string name, int value, string units){
            
            Attributes.Add(new CardAttribute(name, value, units));
            
            return this;
        }
        
        public CardBuilder WithTitle(string title)
        {
            Title = title;
            return this;
        }
        
        public CardBuilder WithDescription(string description)
        {
            Description = description;
            return this;
        }
        
        public Card Build(){
            return new Card(Title, Attributes.ToArray(), Description);
        }
    }
}
