using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DiversityWorks.Framework.BOL;

namespace DiversityWorks.Framework.DAL
{
    public interface IRepository<T>
    {
        Task<T> OnInsert(T data);
        Task<List<T>> OnInsertMany(List<T> datas);
        Task<T> OnGetById(object id);
        Task<T> OnUpdate(T data);
        Task<List<T>> OnUpdateMany(List<T> datas);
        Task<bool> OnDelete(object id);
        Task<List<T>> OnSearch(SearchRequest<T> searchRequest);
        Task<List<T>> OnSearchAll();
    }
}
