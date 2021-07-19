using System;

namespace Damage
{
    public class DamageSystem
    {
        IGetDamage person;

        public DamageSystem(IGetDamage person)
        {
            this.person = person;
        }

        public int TakeDamege(int damage)
        {
            person.Health -= damage;    
            return person.Health;
        }
    }
}