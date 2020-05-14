using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
    public interface IPricingStrategy
    {
        Sku Sku { get; }
        double GetPrice(int count);
    }
}
