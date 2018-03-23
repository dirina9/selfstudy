using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Pluralsight.collectionInterfaces
{
    public class Dictionary
    {
        public void DictionaryExample()
        {
            var primeMinisters = new SortedDictionary<string, PrimeMinister>(StringComparer.InvariantCultureIgnoreCase)
            {
                {"JC", new PrimeMinister("James Callaghan", 1976)},
                {"MT", new PrimeMinister("Margaret Thetcher", 1979)}
            };

            Console.WriteLine("Prime minister with [mt]");
            Console.WriteLine(primeMinisters["mt"]);

            foreach (var pm in primeMinisters.Values)
            {
                Console.WriteLine(pm);
            }


            var primeMinistersWithIntKey = new PrimeMinistersWithIntKey()
            {
                new PrimeMinister("James Callaghan", 1976),
                new PrimeMinister("Margaret Thetcher", 1979)
            };

            foreach (var pm in primeMinistersWithIntKey)
            {
                Console.WriteLine(pm);
            }
        }
        class PrimeMinistersWithIntKey : KeyedCollection<int, PrimeMinister>
        {
            protected override int GetKeyForItem(PrimeMinister item)
            {
                return item.YearElected;
            }
        }
    }
}