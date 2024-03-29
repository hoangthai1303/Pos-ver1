using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helpers.Paging
{
    public class PagingModel
    {
        /// <summary>
        /// Gets or sets the total records.
        /// </summary>
        public long TotalRecords { get; set; }

        /// <summary>
        /// Gets or sets the current page.
        /// </summary>
        public long CurrentPage { get; set; }

        /// <summary>
        /// Gets or sets the number of record per page.
        /// </summary>
        public long PageSize { get; set; }

        public int PageBlock { get; set; }
    }
}