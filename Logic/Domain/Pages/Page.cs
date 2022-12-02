﻿namespace Logic.Domain.Pages
{
    public class Page
    {
        public int TotalItems { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public int StartPage { get; set; }
        public int EndPage { get; set; }    
        public Page() { }
        public Page(int totalItems, int page, int pageSize = 9)
        {
          int totalPages = (int)Math.Ceiling(totalItems / (decimal)pageSize);
          int currentPage = page;
          int startPage = currentPage - 5;
          int endPage = currentPage +4;

          if(startPage <= 0)
            {
                endPage = endPage -(startPage - 1);
                startPage = 1;
            }
          if(endPage > totalPages)
            {
                endPage = totalPages;
                if(endPage > 9)
                {
                    startPage = endPage - 8;
                }
            }
            TotalItems = totalItems;
            CurrentPage = currentPage;
            PageSize = pageSize;
            TotalPages = totalPages;
            StartPage = startPage;
            EndPage = endPage;

        }
    }
}