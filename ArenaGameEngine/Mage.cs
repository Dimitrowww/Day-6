using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class Mage : Hero
    {
        public Mage(string name) : base(name)
        {
           
            Health = 450;
            Intelligence = 120;
        }

        public override int Attack()
        {
            
            int baseDamage = Intelligence * 4;
            return baseDamage;
        }

        public override void TakeDamage(int incomingDamage)
        {
           
            base.TakeDamage(incomingDamage);
        }
    }
}
