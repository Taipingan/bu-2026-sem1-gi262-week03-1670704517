using UnityEngine;

namespace Assignment03.StudentSolution
{
    public class Sword : Weapon
    {
        public int bladeLength;

        public void Slash()
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
