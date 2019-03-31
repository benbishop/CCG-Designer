using System;
using System.Collections.Generic;
using System.Linq;


namespace CCG.Core
{
    public class Hand
    {
        private static Random Ran = new Random();
        
        protected readonly List<Card> Cards = new List<Card>();
        
        public void Add(Card card){
            Cards.Add(card);
        }
        
        public void Discard(Card card){
            Cards.Remove(card);
        }
        
        public Card PickRandom(){
            return Cards[Ran.Next(0, Cards.Count)];
        }
    }
}
