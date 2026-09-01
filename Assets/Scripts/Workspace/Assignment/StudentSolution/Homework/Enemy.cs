using UnityEngine;

namespace Assignment03.StudentSolution
{
    public class Enemy : Entity
    {
        public int damage;
        protected int aiLevel;

        public virtual void Attack(Entity target)
        {
            if (target == null)
                return;
        }

        protected virtual void Patrol()
        {
        }
    }
}
