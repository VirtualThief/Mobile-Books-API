namespace MobileBook.Models.DTO
{
    using MobileBook.Models;

    class BookDetailsPartialDTO
    {
        public BookDetailsPartialDTO(BookExtended book)
        {
            this.Id = book.Id;
            this.Title = book.Title;
            this.Author = book.Author;
            this.Genre = book.Genre;
            this.Cover = book.Cover;
        }

        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Cover { get; set; }
    };
}