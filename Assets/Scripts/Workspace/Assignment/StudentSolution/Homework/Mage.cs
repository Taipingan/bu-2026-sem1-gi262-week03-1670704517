using UnityEngine;

namespace Assignment03.StudentSolution
{
    public class Mage : RangeEnemy
    {
        public int mana;

        public override void Attack(Entity target)
        {
            CastSpell(target);
        }

        public void CastSpell(Entity target)
        {
            if (target == null)
                return;
        }
    }
}
