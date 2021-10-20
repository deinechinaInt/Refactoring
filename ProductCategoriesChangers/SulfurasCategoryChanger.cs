namespace csharp.ProductCategoriesChangers
{
    [ProductCategory(ProductCategories.Sulfuras)]
    // "Sulfuras", being a legendary item, never has to be sold or decreases in Quality
    public class SulfurasCategoryChanger : BaseProductCategoryChanger
    {
        protected override int MaxQuality()
        {
            return 80;
        }
        protected override int ChangedQuality(int initialQuality, int sellIn)
        {
            return MaxQuality();
        }

        protected override int ChangeSellIn(int initSellInn)
        {
            return initSellInn;
        }
    }
}
