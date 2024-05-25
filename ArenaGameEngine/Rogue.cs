using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{

    public class Rogue : Hero
    {
        public Rogue(string name) : base(name)
        {
            
            Health = 400;
            Agility = 100;
        }

        public override int Attack()
        {
            
            int baseDamage = Agility * 3; 
            return baseDamage;
        }

        public override void TakeDamage(int incomingDamage)
        {
            
            int evaded = Random.Shared.Next(0, 100); 
            if (evaded <= 30)
            {
                Console.WriteLine($"{Name} evaded the attack!");
                return;
            }
            base.TakeDamage(incomingDamage);
        }
    }
}
