using UnityEngine;

namespace Assignment03.StudentSolution
{
    public class Bow : Weapon
    {
        public int range;

        public void Shoot()
        {

        }

        public override void Equip(Player player)
        {
            if (player == null)
                return;
        }

        public override void DealDamage(Entity target)
        {
            if (target == null)
                return;
        }
    }
}
