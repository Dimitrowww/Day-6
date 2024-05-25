namespace ArenaGameEngine
{
    public class Hero
    {
        public string Name { get; private set; }
        public int Health { get; protected set; }
        public int Strength { get; protected set; }
        public int Agility { get; protected set; }
        public int Intelligence { get; protected set; }
        public int Armor { get; protected set; }

        public Hero(string name)
        {
            Name = name;
            Health = 500; 
            Strength = 50; 
            Agility = 50;
            Intelligence = 50;
            Armor = 20;
        }

        public bool IsAlive => Health > 0;

        public virtual int Attack()
        {
            
            return Strength;
        }

        public virtual void TakeDamage(int incomingDamage)
        {
            
            Health -= incomingDamage;
            if (Health <= 0)
            {
                Console.WriteLine($"{Name} has been defeated!");
            }
        }
    }
}
