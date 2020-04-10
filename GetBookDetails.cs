namespace MobileBook.Function
{
    using System;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Azure.WebJobs;
    using Microsoft.Azure.WebJobs.Extensions.Http;
    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.Logging;

    using MobileBook.Data.Mock;
    using MobileBook.Models.DTO;

    public static class GetBookDetails
    {
        [FunctionName("GetBookDetails")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "book/details/{id}")] HttpRequest req,
            string id,
            ILogger log)
        {
            if (!Guid.TryParse(id, out var guidId))
            {
                return new BadRequestResult();
            }

            var bookDetails = BooksMock.Books.FirstOrDefault(b => new Guid(b.Id) == guidId);
            if (bookDetails == null)
            {
                return new NotFoundObjectResult(new { Details = "BOOK_NOT_FOUND" });
            }

            return new OkObjectResult(new BookDetailsFullDTO(bookDetails));
        }
    }
}
