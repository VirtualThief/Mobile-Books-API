namespace MobileBook.Data.Mock
{
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using MobileBook.Models;

    internal class GenresMock
    {
        public static readonly IReadOnlyCollection<Genre> Genres = new[]
        {
            new Genre { Name = "Horror", Id = "horror" },
            new Genre { Name = "Humor", Id = "humor" },
            new Genre { Name = "Mystery", Id = "mystery" },
            new Genre { Name = "Drama", Id = "drama" },
            new Genre { Name = "Fantasy", Id = "fantasy" },
            new Genre { Name = "Mythology", Id = "mythology" },
            new Genre { Name = "Sci-Fi", Id = "scifi" },
            new Genre { Name = "Comic", Id = "comic" },
        }.ToImmutableArray();
    }
}