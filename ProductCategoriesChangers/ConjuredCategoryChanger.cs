namespace csharp.ProductCategoriesChangers
{
    [ProductCategory(ProductCategories.Conjured)]
    public class ConjuredCategoryChanger : BaseProductCategoryChanger
    {
        protected override int ChangedQuality(int initialQuality, int sellIn)
        {           
            // После того, как срок храния прошел, качество товара ухудшается в два раза быстрее;
            if (sellIn < 0)
            {
                return initialQuality - 4;
            }
            return initialQuality - 2;
        }
    }
}
