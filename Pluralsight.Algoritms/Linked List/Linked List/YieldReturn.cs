using System.Collections.Generic;

namespace Linked_List
{
    public class YieldReturn
    {
        public IEnumerable<int> GetNumbers()
        {
            var number = 0;
            while (true)
            {
                if (number > 10) yield break;

                yield return number++;
            }
        }
    }
}