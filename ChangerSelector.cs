using csharp.ProductCategoriesChangers;

namespace csharp
{
    public static class ChangerSelector
    {
        public static ICategoryChanger GetChanger(string name)
        {                        

            ICategoryChanger changer;

            switch (name)
            {
                case ProductCategories.AgedBrie:
                    changer = new AgedBrieCategoryChanger();
                    break;

                case ProductCategories.Sulfuras:
                    changer = new SulfurasCategoryChanger();
                    break;

                case ProductCategories.BackstagePasses:
                    changer = new BackStagePassesCategoryChanger();
                    break;

                case ProductCategories.Conjured:
                    changer = new ConjuredCategoryChanger();
                    break;

                default:
                    changer = new BaseProductCategoryChanger();
                    break;
            }

            return changer;
        }
    }
}
