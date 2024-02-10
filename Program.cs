using System;
using System.Collections.Generic;
using System.Drawing;

namespace Ducks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>() {
       new Duck() { Kind = KindOfDuck.Mallard, Size = 17 },
       new Duck() { Kind = KindOfDuck.Muscovy, Size = 18 },
       new Duck() { Kind = KindOfDuck.Loon, Size = 14 },
       new Duck() { Kind = KindOfDuck.Muscovy, Size = 11 },
       new Duck() { Kind = KindOfDuck.Mallard, Size = 14 },
       new Duck() { Kind = KindOfDuck.Loon, Size = 13 },

       };
          DuckComparer comparer = new DuckComparer();
            Console.WriteLine("\nSorting by kind then size\n");
            comparer.SortBy = SortCriteria.KindThenSize;
            ducks.Sort(comparer);
            PrintDucks(ducks);
            Console.WriteLine("\nSorting by size then kind\n");
            comparer.SortBy = SortCriteria.SizeThenKind;
            ducks.Sort(comparer);
            PrintDucks(ducks);
        }

        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
            {

                Console.WriteLine($"{duck.Size} inch {duck.Kind}");

            }
        }

    }
    class Duck : IComparable<Duck>
    {
        public int Size
        {
            get; set;
        }
        public KindOfDuck Kind
        {
            get; set;
        }
        public int CompareTo(Duck duckToCompare)
        {
            if (this.Size > duckToCompare.Size) return 1;
            else if (this.Size < duckToCompare.Size) return -1;
            else return 0;
        }
    }
    class DuckComparerBySize : IComparer<Duck>
    {
        public int Compare(Duck x, Duck y)
        {
            if (x.Size < y.Size) return -1;
            if (x.Size > y.Size) return 1;
            return 0;
        }
    }
    class DuckCompareryByKind : IComparer<Duck>
    {
        public int Compare(Duck x, Duck y)
        {
            if (x.Kind < y.Kind) return -1;
            if (x.Kind > y.Kind) return 1;
            else return 0;
        }
    }
    enum KindOfDuck
    {
        Mallard,
        Muscovy,
        Loon,
    }
    enum SortCriteria
    {
        SizeThenKind,
        KindThenSize,
    }
    class DuckComparer : IComparer<Duck>
    {
        public SortCriteria SortBy = SortCriteria.SizeThenKind;

        public int Compare(Duck x, Duck y)
        {
            if (SortBy == SortCriteria.SizeThenKind)

                if (x.Size > y.Size) return 1;
                else if (x.Size < y.Size) return -1;
                else
                if (x.Kind > y.Kind) return 1;
                else if (x.Kind < y.Kind) return -1;
                else return 0;

            else
                if (x.Kind > y.Kind)
                return 1;
            else if (x.Kind < y.Kind)
                return -1;
            else
                if (x.Size > y.Size)
                return 1;
            else if (x.Size < y.Size)
                return -1;
            else return 0;
        }
    }
}

