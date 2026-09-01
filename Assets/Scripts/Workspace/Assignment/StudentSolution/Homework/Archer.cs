using UnityEngine;

namespace Assignment03.StudentSolution
{
    public class Archer : RangeEnemy
    {
        public int accuracy;

        public override void Attack(Entity target)
        {
            AimAndShoot(target);
        }

        public void AimAndShoot(Entity target)
        {
            if (target == null)
                return;
        }
    }
}
