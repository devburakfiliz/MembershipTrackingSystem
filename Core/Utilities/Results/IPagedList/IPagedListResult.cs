using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.IPagedList
{
    public class IPagedListResult<T> : IResult
    {
        public IPagedListResult(List<T> data, bool success, string message, int pageNumber, int pageSize, int totalItemCount)
        {
            Data = data;
            Success = success;
            Message = message;
            PageNumber = pageNumber;
            PageSize = pageSize;
            TotalItemCount = totalItemCount;
            TotalPageCount = (int)Math.Ceiling((double)TotalItemCount / PageSize);
        }

        public List<T> Data { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalItemCount { get; set; }
        public int TotalPageCount { get; set; }
    }

}
