using UnityEngine;

namespace Assignment03.StudentSolution
{
    public class Equipment : Item
    {
        public virtual void Equip(Player player)
        {
            if (player == null)
                return;
        }
    }
}
