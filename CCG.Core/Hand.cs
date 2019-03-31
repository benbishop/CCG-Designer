using System;
using System.Collections.Generic;
using System.Linq;


namespace CCG.Core
{
    public class Hand
    {
        private static Random Ran = new Random();
        
        protected readonly List<Card> Cards = new List<Card>();
        
        public int Count{ get => Cards.Count; }
        
        public void Add(Card card) => Cards.Add(card);
        
        public void Remove(Card card) => Cards.Remove(card);
        
        public Card PickRandom() => Cards[Ran.Next(0, Cards.Count)];
        
        public Card Card(int index) => Cards[index];
        
        
        
    }
}
