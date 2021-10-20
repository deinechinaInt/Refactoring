namespace csharp.ProductCategoriesChangers
{
    [ProductCategory(ProductCategories.AgedBrie)]
    public class AgedBrieCategoryChanger : BaseProductCategoryChanger
    {
        // "Aged Brie" actually increases in Quality the older it gets
        protected override int ChangedQuality(int initialQuality, int sellIn)
        {            
            return initialQuality + 1;
        }
    }
}
