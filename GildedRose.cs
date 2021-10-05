﻿using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {

        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                var changer = ChangerSelector.GetChanger(item.Name);
                changer.ChangeItem(item);
            }

        }
    }
}
