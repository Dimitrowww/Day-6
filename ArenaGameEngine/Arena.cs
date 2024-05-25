using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class Arena
    {
        private List<Hero> teamA;
        private List<Hero> teamB;
        public GameEventListener EventListener { get; set; }

        public Arena(List<Hero> teamA, List<Hero> teamB)
        {
            this.teamA = teamA;
            this.teamB = teamB;
        }

        public Hero Battle()
        {
            while (true)
            {
                foreach (var attacker in teamA)
                {
                    foreach (var defender in teamB)
                    {
                        int damage = attacker.Attack();
                        defender.TakeDamage(damage);

                        if (EventListener != null)
                        {
                            EventListener.GameRound(attacker, defender, damage);
                        }

                        if (!defender.IsAlive)
                        {
                            teamB.Remove(defender);
                            break;
                        }
                    }
                    if (teamB.Count == 0)
                    {
                        return teamA[0];
                    }
                }

                // Swap teams for the next round
                var temp = teamA;
                teamA = teamB;
                teamB = temp;
            }
        }
    }
}