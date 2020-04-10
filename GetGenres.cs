namespace MobileBook.Function
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Azure.WebJobs;
    using Microsoft.Azure.WebJobs.Extensions.Http;
    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.Logging;

    using MobileBook.Data.Mock;

    public static class GetGenres
    {
        [FunctionName("GetGenres")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "genre")] HttpRequest req,
            ILogger log)
        {
            return new OkObjectResult(GenresMock.Genres);
        }
    }
}
