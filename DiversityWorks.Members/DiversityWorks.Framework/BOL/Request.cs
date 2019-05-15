using System;
using System.Linq.Expressions;

namespace DiversityWorks.Framework.BOL
{
    public class Request<T>
    {
        public T Model { get; set; }

        public Request()
        {
        }

        public Request(T data)
        {
            this.Model = data;
        }
    }

    public class SearchRequest<T>
    {
        public Expression<Func<T,bool>> Filter { get; set; }
        public int Limit { get; set; }
        public int Skip { get; set; }
    }
}
