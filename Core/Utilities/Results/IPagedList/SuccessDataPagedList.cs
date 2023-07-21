using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.IPagedList
{
    public class SuccessDataPagedList<T> : IPagedListResult<T>
    {
        public SuccessDataPagedList(List<T> data, string message, int pageNumber, int pageSize, int totalItemCount)
            : base(data, true, message, pageNumber, pageSize, totalItemCount)
        {
        }

        public SuccessDataPagedList(List<T> data, int pageNumber, int pageSize, int totalItemCount)
            : this(data, "Data fetched successfully.", pageNumber, pageSize, totalItemCount)
        {
        }
    }

}
