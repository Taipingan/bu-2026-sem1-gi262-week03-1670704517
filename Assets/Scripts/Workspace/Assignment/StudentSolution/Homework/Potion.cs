using UnityEngine;

namespace Assignment03.StudentSolution
{
    public class Potion : Item
    {
        public int healingAmount;

        public override void Use(Player player)
        {
            if (player == null)
                return;
        }
    }
}
