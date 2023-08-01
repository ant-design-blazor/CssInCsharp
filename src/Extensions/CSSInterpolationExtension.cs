using System.Collections.Generic;

namespace CssInCs
{
    public static class CSSInterpolationExtension
    {
        public static CSSObject[] ToCssArray(this CSSInterpolation value)
        {
            if (value.IsT0)
            {
                return new[] { value.AsT0 };
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
                return new CSSObject[] { };
            }
        }
    }
}
