using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkShale.Repo.Sort
{
    public class FieldSortCriteria<T> : ISortCriteria<T> where T : class
    {
        //-----------------------------------------------------------------------
        public String Name { get; set; }

        //-----------------------------------------------------------------------
        public SortDirection Direction { get; set; }

        //-----------------------------------------------------------------------
        public FieldSortCriteria()
        {
            this.Direction = SortDirection.Ascending;
        }

        //-----------------------------------------------------------------------
        public FieldSortCriteria(String name, SortDirection direction)
            : base()
        {
            Name = name;
            Direction = direction;
        }

        //-----------------------------------------------------------------------
        public IOrderedQueryable<T> ApplyOrdering(IQueryable<T> qry, Boolean useThenBy)
        {
            IOrderedQueryable<T> result = null;
            var descending = this.Direction == SortDirection.Descending;
            result = !useThenBy ? qry.OrderBy(Name, descending) : qry.ThenBy(Name, descending);
            return result;
        }
    }
}
