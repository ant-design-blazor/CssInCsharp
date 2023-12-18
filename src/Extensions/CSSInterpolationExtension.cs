using System;
using System.Collections.Generic;

namespace CssInCSharp
{
    public static class CSSInterpolationExtension
    {
        public static CSSObject[] ToCssArray(this CSSInterpolation value)
        {
            if (value.IsT0)
            {
                if (value.AsT0 == null)
                {
                    return Array.Empty<CSSObject>();
                }
                return new CSSObject[] { value.AsT0 };
            }
            else if (value.IsT1)
            {
                var list = new List<CSSObject>();
                foreach (var item in value.AsT1)
                {
                    list.AddRange(item.ToCssArray());
                }
                return list.ToArray();
            }
            else
            {
                return Array.Empty<CSSObject>();
            }
        }
    }
}
