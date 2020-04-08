namespace MobileBook.Function
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Azure.WebJobs;
    using Microsoft.Azure.WebJobs.Extensions.Http;
    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.Logging;

    using MobileBook.Data.Mock;

    public static class GetBooks
    {
        [FunctionName("GetBooks")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "book/{genre:alpha?}")] HttpRequest req,
            string genre,
            ILogger log)
        {
            if (string.IsNullOrWhiteSpace(genre))
            {
                return new OkObjectResult(BooksMock.Books);
            }

            return new OkObjectResult(
                BooksMock.Books.Where(
                    b => string.Equals(
                        b.GenreId,
                        genre,
                        StringComparison.OrdinalIgnoreCase))
                .ToImmutableArray());
        }
    }
}
