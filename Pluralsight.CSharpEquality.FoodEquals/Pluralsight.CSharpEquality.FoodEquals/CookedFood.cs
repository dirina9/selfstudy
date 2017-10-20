
using System;

namespace Pluralsight.CSharpEquality.FoodEquals
{
    public sealed class CookedFood : Food
    {
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
