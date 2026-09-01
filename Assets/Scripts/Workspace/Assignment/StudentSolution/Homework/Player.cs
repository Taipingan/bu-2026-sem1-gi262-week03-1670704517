using UnityEngine;

namespace Assignment03.StudentSolution
{
    public class Player : Entity
    {
        public int score;
        private Item[] items;

        public void CollectItem(Item item)
        {
            if (item == null)
                return;

            if (items == null)
            {
                items = new Item[] { item };
                return;
            }

            Item[] newItems = new Item[items.Length + 1];

            for (int i = 0; i < items.Length; i++)
            {
                newItems[i] = items[i];
            }

            newItems[items.Length] = item;
            items = newItems;
        }

        protected void LevelUp()
        {

        }
    }
}
