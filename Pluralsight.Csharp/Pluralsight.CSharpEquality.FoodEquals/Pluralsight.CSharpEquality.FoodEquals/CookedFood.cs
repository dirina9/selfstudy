
using System;

namespace Pluralsight.CSharpEquality.FoodEquals
{
    public sealed class CookedFood : Food
    {

        public static bool operator ==(CookedFood x, CookedFood y)
        {
            return object.Equals(x, y);
        }

        public static bool operator !=(CookedFood x, CookedFood y)
        {
            return !object.Equals(x, y);
        }

        public override bool Equals(object obj)
        {
            if (!base.Equals(obj))
                return false;
            CookedFood rhs = (CookedFood) obj;
            return this._cookingMethod == rhs._cookingMethod;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ this._cookingMethod.GetHashCode();
        }

        private string _cookingMethod;
        public string CookingMethod { get { return _cookingMethod; } }

        public CookedFood(string cookingMethod, string name, FoodGroup group)
            : base(name, group)
        {
            this._cookingMethod = cookingMethod;
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", _cookingMethod, Name);
        }
    }
}
