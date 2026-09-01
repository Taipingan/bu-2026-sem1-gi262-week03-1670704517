using UnityEngine;

namespace Assignment03.StudentSolution
{
    public class Entity
    {
        public string name;
        private Vector3 position;
        protected int health;

        public virtual void Update()
        {
        }

        protected virtual void TakeDamage(int damage)
        {
            health -= damage;

            if (health < 0)
                health = 0;
        }

        private void Move(Vector3 direction)
        {
            position += direction;
        }
    }
}
