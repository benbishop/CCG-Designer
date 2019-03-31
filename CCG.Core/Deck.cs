using System;
using System.Collections.Generic;
using System.Linq;


namespace CCG.Core
{
    public class Deck
    {
        private static Random rng = new Random();  
        
        protected readonly List<Card> Cards = new List<Card>();
        
        public void Add(Card card) => Cards.Add(card);
        
        
        public bool CanDraw{ get => Cards.Any(); }
        
        
        public void Shuffle(){
            int n = Cards.Count;  
            while (n > 1) {  
                n--;  
                int k = rng.Next(n + 1);  
                Card value = Cards[k];  
                Cards[k] = Cards[n];  
                Cards[n] = value;  
            }    
        }
        
        public List<Card> Draw(int n){
            var drawnCards = new List<Card>();
            while(drawnCards.Count < n)
                drawnCards.Add(Draw());
            return drawnCards;
        }
        
        public Card Draw(){
            
            if(!CanDraw)
                throw new DrawException();
            
            var topCard = Cards.First();
            Cards.Remove(topCard);
            return topCard;
           
        }


          
    }
    
    public class DrawException:Exception{
        public DrawException():base("No cards are left to draw"){
            
        }
    }
}
