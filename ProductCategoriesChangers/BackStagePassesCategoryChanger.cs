namespace csharp.ProductCategoriesChangers
{
    //- "Backstage passes", like aged brie, increases in Quality as its SellIn value approaches;
    // Quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less but
    // Quality drops to 0 after the concert
    [ProductCategory(ProductCategories.BackstagePasses)]
    public class BackStagePassesCategoryChanger : BaseProductCategoryChanger
    {
        protected override int ChangedQuality(int initialQuality, int sellIn)
        {
            // Quality drops to 0 after the concert
            if (sellIn < 0)
            {
                return 0;
            }

            // Quality increases  by 3 when there are 5 days or less
            if (sellIn < 6)
            {
                return initialQuality + 3;
            }
            // Quality increases by 2 when there are 10 days or less
            if (sellIn < 11)
            {
                return initialQuality + 2;
            }

            return initialQuality + 1;

        }
    }
}
