using System;
using System.Linq.Expressions;

namespace DiversityWorks.Framework.BOL
{
    public class Request<TModel>
    {
        public TModel Model { get; set; } 

        public Request()
        {
        }

        public Request(TModel data)
        {
            this.Model = data;
        }
    }

    public class SearchRequest<TModel>
    {
        public Expression<Func<TModel, bool>> Filter { get; set; }
        public int Skip { get; set; }
        public int Limit { get; set; }
    }
}
