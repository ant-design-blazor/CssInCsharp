using OneOf;
using System.Reflection;

namespace CssInCsLab
{
    public abstract class Enumeration : IComparable
    {
        public string Name { get; private set; }

        public int Id { get; private set; }

        protected Enumeration(int id, string name) => (Id, Name) = (id, name);

        public override string ToString() => Name;

        public static IEnumerable<T> GetAll<T>() where T : Enumeration =>
            typeof(T).GetFields(BindingFlags.Public |
                                BindingFlags.Static |
                                BindingFlags.DeclaredOnly)
                .Select(f => f.GetValue(null))
                .Cast<T>();

        public override bool Equals(object obj)
        {
            if (obj is not Enumeration otherValue)
            {
                return false;
            }

            var typeMatches = GetType().Equals(obj.GetType());
            var valueMatches = Id.Equals(otherValue.Id);

            return typeMatches && valueMatches;
        }

        public int CompareTo(object other) => Id.CompareTo(((Enumeration)other).Id);

        // Other utility methods ...
    }

    public class ButtonSize : Enumeration
    {
        public static ButtonSize Primary = new(1, nameof(Primary));
        public static ButtonSize Default = new(2, nameof(Default));

        public ButtonSize(int id, string name)
            : base(id, name)
        {
        }
    }

    public class StringOrNumber : OneOfBase<string, int>
    {
        StringOrNumber(OneOf<string, int> input) : base(input)
        {
        }

        public static implicit operator StringOrNumber(string _) => new StringOrNumber(_);
        public static implicit operator StringOrNumber(int _) => new StringOrNumber(_);

        public (bool isNumber, int number) TryGetNumber() =>
            Match(
                s => (int.TryParse(s, out var n), n),
                i => (true, i)
            );
    }

    public class StringOrButtonSize : OneOfBase<string, ButtonSize>
    {
        public static implicit operator StringOrButtonSize(string _) => new StringOrButtonSize(_);
        public static implicit operator StringOrButtonSize(ButtonSize _) => new StringOrButtonSize(_);
        StringOrButtonSize(OneOf<string, ButtonSize> input) : base(input)
        {
        }
    }

    public struct Test<T0>
    {
        private readonly T0 _func;

        private Test(int index, T0 value)
        {
            _func = value;
        }
        public static implicit operator Test<T0>(T0 t) => new(1, t);
    }

    public class Demo
    {
       //  public Test<Func<string>> Width { get; set; } = () => "123";

        public Func<string> Height { get; set; } = () => "123";

        public void Test()
        {
            var s = () => "123";
            Width = (Func<string>)(() => "123");
        }

        public OneOf<int, Func<string>> Width { get; set; }
    }
}
