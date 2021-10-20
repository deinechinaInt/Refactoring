using csharp.ProductCategoriesChangers;
using System.Collections.Generic;
using System.Linq;

namespace csharp
{
    public class ChangerSelector
    {
        private readonly Dictionary<string, System.Type> changersDictionary = new Dictionary<string, System.Type>();
        public ChangerSelector()
        {
            var changers = typeof(BaseProductCategoryChanger).Assembly.GetTypes().Where(t => !t.IsAbstract && t.IsSubclassOf(typeof(BaseProductCategoryChanger))).ToList();
            
            foreach(var changer in changers)
            {               
                var attr = changer.GetCustomAttributes(typeof(ProductCategoryAttribute), false);
                if (attr.Length > 0)
                {
                    ProductCategoryAttribute productCategoryAttribute = attr[0] as ProductCategoryAttribute;
                    if (productCategoryAttribute != null)
                    {
                        changersDictionary[productCategoryAttribute.CategoryName] =changer ;
                    }
                }              
            }
        }
        public  ICategoryChanger GetChanger(string name)
        {
            ICategoryChanger changer = new BaseProductCategoryChanger();
            
            if (changersDictionary.TryGetValue(name, out var type))
            {
                changer = System.Activator.CreateInstance(type) as ICategoryChanger;
            }            
           
            return changer;
        }
    }
}
