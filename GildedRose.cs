using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        private readonly ChangerSelector _changeSelector;     

        IList<Item> Items;
        public GildedRose(IList<Item> Items, ChangerSelector changerSelector)
        {
            this.Items = Items;
            _changeSelector = changerSelector;
        }

        public void UpdateQuality()
        {                       
            foreach (var item in Items)
            {
                var changer = _changeSelector.GetChanger(item.Name);
                changer.ChangeItem(item);
            }
        }
    }
}
