namespace MobileBook.Models.DTO
{
    class BookDetailsFullDTO
    {
        public BookDetailsFullDTO(BookExtended book)
        {
            this.Id = book.Id;
            this.Title = book.Title;
            this.Author = book.Author;
            this.Genre = book.Genre;
            this.Description = book.Description;
            this.Cover = book.Cover;
        }

        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public string Cover { get; set; }
    };
}