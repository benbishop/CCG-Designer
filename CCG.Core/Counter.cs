using System;
using System.Collections.Generic;
using System.Linq;


namespace CCG.Core
{
    public class Counter
    {
        protected uint Count = 0;
        
        public readonly string Name;
        
        public uint Value{ get => Count; }
        
        public Counter(string name, uint initialValue = 0){
            if(string.IsNullOrEmpty(name))
                throw new ArgumentException("Counter name cannot be null or empty");
               
            
            Name = name;
            
            Count = initialValue;
        }
        
        public void Increment(uint amount = 1) => Count += amount;
        
        public void Decrement(uint amount = 1){
            if(Count - amount < 0)
                throw new CounterException();
                
            Count -= amount;
        }
    }
    
    public class CounterException:Exception{
        public CounterException():base("Counter cannot have a value less than 0"){
            
        }
    }
}
