using System;
using System.Collections.Generic;
using System.Linq;


namespace CCG.Core
{
    public class CardBuilder
    {
        protected List<CardAttribute> Attributes = new List<CardAttribute>();
        
        protected List<Action> PlayValidations = new List<Action>();
        
        protected List<Action> PlayActions = new List<Action>();
        
        protected string Title = "";
        
        protected string Description = "";
        
        public CardBuilder WithAttribute(string name, 
                                         int value = CardAttribute.NoValue, 
                                         string units = null){
            
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
            return new Card(Title, 
            Attributes.ToArray(), 
            PlayValidations.ToArray(),
            PlayActions.ToArray(),
            Description);
        }
    }
}
