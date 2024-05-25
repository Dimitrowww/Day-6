using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{

    public class Knight : Hero
    {
        public Knight(string name) : base(name)
        {
            
            Health = 600;
            Strength = 80;
        }

        public override int Attack()
        {
            
            int baseDamage = Strength * 2; 
            return baseDamage;
        }

        public override void TakeDamage(int incomingDamage)
        {
            
            int mitigatedDamage = incomingDamage - (Armor * 2);
            base.TakeDamage(mitigatedDamage);
        }
    }
}
