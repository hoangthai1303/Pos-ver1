using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helpers.Paging
{
    public class Paging
    {
        protected long totalPages = 0;
        protected long totalRecords = 0;
        protected List<Pager> listPagers = new List<Pager>();
        public string AjaxUrl { get; set; }
        public string AjaxParameter { get; set; }

        /// <summary>
        /// Gets or sets the total records.
        /// </summary>
        public long TotalRecords
        {
            get { return totalRecords; }
            set
            {
                totalRecords = value;
                CreateListPager();
            }
        }

        /// <summary>
        /// Gets or sets the current page.
        /// </summary>
        public int CurrentPage { get; set; }

        /// <summary>
        /// Gets or sets the number of record per page.
        /// </summary>
        public int PageSize { get; set; }

        public long PageBlock { get; set; }

        public long TotalPages
        {
            get { return totalPages; }
            set { totalPages = value; }
        }

        public List<Pager> ListPagers
        {
            get { return listPagers; }
            set { listPagers = value; }
        }

        public Paging()
        {
            CurrentPage = 1;
            PageSize = 50;
            PageSize = ConfigManagement.GetInstance.PageSize;
            PageBlock = ConfigManagement.GetInstance.PageBlock;
        }

        public Paging(int totalRecords, int currentPage, int pageSize, int pageBlock)
        {
            TotalRecords = totalRecords;
            CurrentPage = currentPage;
            PageSize = pageSize;
            PageBlock = pageBlock;
        }

        protected void UpdateInformation()
        {
            totalPages = PageSize > 0 ? (TotalRecords / PageSize) + ((TotalRecords % PageSize) == 0 ? 0 : 1) : 0;
            listPagers = new List<Pager>();
        }

        protected void CreateListPager()
        {
            UpdateInformation();

            long startIndex = 0;
            long endIndex = TotalPages;

            if (TotalPages > PageBlock)
            {
                startIndex = CurrentPage - PageBlock / 2;
                endIndex = CurrentPage + PageBlock / 2;

                if (startIndex < 0)
                {
                    startIndex = 0;
                    endIndex = startIndex + PageBlock;
                }
                if (endIndex > TotalPages)
                {
                    startIndex = TotalPages - PageBlock;
                    endIndex = TotalPages;
                }
            }

            ListPagers.Add(new Pager { Title = "««", PageNum = "1", CurrentPage = false });

            if (CurrentPage == 1)
                listPagers.Add(new Pager { Title = "«", PageNum = CurrentPage.ToString(), CurrentPage = false });
            else
                listPagers.Add(new Pager { Title = "«", PageNum = (CurrentPage - 1).ToString(), CurrentPage = false });

            for (long i = startIndex; i < endIndex; i++)
            {
                //long test = CurrentPage - 1;
                listPagers.Add(new Pager { Title = (i+1).ToString(), PageNum = (i+1).ToString(), CurrentPage = i == (CurrentPage - 1) });
            }

            if (CurrentPage == TotalPages)
                listPagers.Add(new Pager { Title = "»", PageNum = CurrentPage.ToString(), CurrentPage = false });
            else
                listPagers.Add(new Pager { Title = "»", PageNum = (CurrentPage + 1).ToString(), CurrentPage = false });

            listPagers.Add(new Pager { Title = "»»", PageNum = TotalPages.ToString(), CurrentPage = false });
        }
    }

    public class Pager
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the page number.
        /// </summary>
        /// <value>The page num.</value>
        public string PageNum { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this page is the current page.
        /// </summary>
        /// <value><c>true</c> if [current page]; otherwise, <c>false</c>.</value>
        public bool CurrentPage { get; set; }
    }
}