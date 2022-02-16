using System;
namespace Mission7.Models.ViewModels
{
    public class PageInfo
    {
        public int TotalNumBooks { get; set; }
        public int BooksPerPage { get; set; }
        public int CurrentPage { get; set; }

        //Casting
        public int TotalPages => (int)(Math.Ceiling((decimal) TotalNumBooks / BooksPerPage));
    }
}
