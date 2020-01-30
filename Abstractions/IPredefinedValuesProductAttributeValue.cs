using System;
using System.Collections.Generic;
using System.Text;

namespace OrchardCore.Commerce.Abstractions
{
    public interface IPredefinedValuesProductAttributeValue : IProductAttributeValue
    {
        public object UntypedPredefinedValue { get; }
    }

    public interface IPredefinedValuesProductAttributeValue<T> : IPredefinedValuesProductAttributeValue
    {
        public T PredefinedValue { get; }
    }
}
