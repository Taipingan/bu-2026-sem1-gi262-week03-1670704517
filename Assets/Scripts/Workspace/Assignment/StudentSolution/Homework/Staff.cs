using UnityEngine;

namespace Assignment03.StudentSolution
{
    public class Staff : Weapon
    {
        public int magicPower;

        public void CastSpell()
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
