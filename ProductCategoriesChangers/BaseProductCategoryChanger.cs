namespace csharp.ProductCategoriesChangers
{
    public class BaseProductCategoryChanger : ICategoryChanger
    {
        // The Quality of an item is never more than 50             
        protected virtual int MaxQuality()
        {
            return 50;
        }
 
        // качество наших товаров постоянно ухудшается по мере приближения
        // к максимальному сроку хранения       
        protected virtual int ChangedQuality(int initialQuality, int sellIn)
        {                                   
            // После того, как срок храния прошел, качество товара ухудшается в два раза быстрее;
            if (sellIn < 0)
            {
                return initialQuality - 2;
            }
            return initialQuality - 1;
        }

        protected virtual int ChangeSellIn(int initSellInn)
        {
            return initSellInn - 1;
        }

        public  virtual void ChangeItem(Item item)
        {           
            item.SellIn = ChangeSellIn(item.SellIn);
           
            item.Quality = GetNewQuality(item.Quality, item.SellIn);
        }

        private int GetNewQuality(int initialQuality, int sellIn)
        {
            var newQuality = ChangedQuality(initialQuality, sellIn);
            // Качество товара никогда не может быть отрицательным;
            if (newQuality < 0)
            {
               return 0;
            }
            //товар никогда не может иметь качество выше чем 50, 
            //однако легендарный товар «Sulfuras» имеет качество 80
            if (newQuality > MaxQuality())
            {
                return MaxQuality();
            }
            return newQuality;
        }
    }
}
