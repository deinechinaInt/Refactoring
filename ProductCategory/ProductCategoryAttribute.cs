using System;

namespace csharp
{
    public class ProductCategoryAttribute :Attribute
    {
        public string CategoryName { get; set; }
        public ProductCategoryAttribute(string categoryName)
        {
            CategoryName = categoryName;
        }
    }
}
