namespace MobileBook.Function
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Azure.WebJobs;
    using Microsoft.Azure.WebJobs.Extensions.Http;
    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.Logging;

    using MobileBook.Data.Mock;
    using MobileBook.Models;
    using MobileBook.Models.DTO;

    public static class GetBooks
    {
        [FunctionName("GetBooks")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "book/list/{genre:alpha?}")] HttpRequest req,
            string genre,
            ILogger log)
        {
            IEnumerable<BookExtended> books = string.IsNullOrWhiteSpace(genre)
                ? BooksMock.Books 
                : BooksMock.Books
                    .Where(b => string.Equals(b.GenreId, genre, StringComparison.OrdinalIgnoreCase));
            return new OkObjectResult(
                books.Select(b => new BookDetailsPartialDTO(b))
                    .ToImmutableArray());
        }
    }
}
