namespace MobileBook.Data.Mock
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;

    using MobileBook.Models;

    internal class BooksMock
    {
        public static readonly IReadOnlyCollection<BookExtended> Books = Enumerable.Range(0, 5).Select(_ => new[] 
        {
            new BookExtended {
                Id = Guid.NewGuid().ToString(),
                Title = "The Shining",
                Author = "Stephen King",
                Genre = "Horror",
                GenreId = "horror",
                Description =
                "The Shining is a 1980 psychological horror film produced and directed by Stanley Kubrick and co-written with novelist Diane Johnson. The film is based on Stephen King's 1977 novel of the same name and stars Jack Nicholson, Shelley Duvall, Scatman Crothers, and Danny Lloyd. The central character in The Shining is Jack Torrance (Nicholson), an aspiring writer and recovering alcoholic, who accepts a position as the off-season caretaker of the isolated historic Overlook Hotel in the Colorado Rockies. Wintering over with Jack are his wife, Wendy Torrance (Duvall) and young son, Danny Torrance (Lloyd). Danny possesses \"the shining\", psychic abilities that enable him to see into the hotel's horrific past. The hotel cook, Dick Hallorann (Crothers), also has this ability and is able to communicate with Danny telepathically. The hotel had a previous winter caretaker who went insane and killed his family and himself. After a winter storm leaves the Torrances snowbound, Jack's sanity deteriorates due to the influence of the supernatural forces that inhabit the hotel, placing his wife and son in danger. ",
                Cover = "the_shining"
            },
            new BookExtended{
                Id = Guid.NewGuid().ToString(),
                Title = "It",
                Author = "Stephen King",
                Genre = "Horror",
                GenreId = "horror",
                Description =
                "It is a 1986 horror novel by American author Stephen King. It was his 22nd book, and his 17th novel written under his own name. The story follows the experiences of seven children as they are terrorized by an evil entity that exploits the fears of its victims to disguise itself while hunting its prey. \"It\" primarily appears in the form of Pennywise the Dancing Clown to attract its preferred prey of young children.",
                Cover = "it"
            },
            new BookExtended{
                Id = Guid.NewGuid().ToString(),
                Title = "The Hitchhiker's Guide to the Galaxy",
                Author = "Douglas Adams",
                Genre = "Humor",
                GenreId = "humor",
                Description =
                "The Hitchhiker's Guide to the Galaxy is the first of six books in the Hitchhiker's Guide to the Galaxy comedy science fiction \"trilogy\" by Douglas Adams. The novel is an adaptation of the first four parts of Adams' radio series of the same name. The novel was first published in London on 12 October 1979.[2] It sold 250,000 copies in the first three months.[3] ",
                Cover = "hitchhikers_guide",
            },
            new BookExtended{
                Id = Guid.NewGuid().ToString(),
                Title = "The Da Vinci Code",
                Author = "Dan Brown",
                Genre = "Mystery",
                GenreId = "mystery",
                Description =
                "The Da Vinci Code is a 2003 mystery thriller novel by Dan Brown. It is Brown's second novel to include the character Robert Langdon: the first was his 2000 novel Angels & Demons. The Da Vinci Code follows \"symbologist\" Robert Langdon and cryptologist Sophie Neveu after a murder in the Louvre Museum in Paris causes them to become involved in a battle between the Priory of Sion and Opus Dei over the possibility of Jesus Christ having been a companion to Mary Magdalene. ",
                Cover = "da_vinci_code",
            },
        })
        .SelectMany(a => a)
        .ToImmutableArray();
    }
}
