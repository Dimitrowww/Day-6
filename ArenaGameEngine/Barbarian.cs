using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class Barbarian : Hero
    {
        public Barbarian(string name) : base(name)
        {
            
            Health = 700;
            Strength = 100;
        }

        public override int Attack()
        {
            
            int baseDamage = Strength * 3; 
            return baseDamage;
        }

        public override void TakeDamage(int incomingDamage)
        {
            
            base.TakeDamage(incomingDamage);
        }
    }
}
