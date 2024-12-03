using System.Text.Json;
using Todo_API.Models.Helper;

namespace Todo_API.Models.Extentions
{
    public static class HttpExtensions
    {

        public static void AppPaginationHeader(this HttpResponse response, int currentPage, int itemsPerPage, int totalItems, int totalPages)
        {
            var paginationHeader = new PaginationHeader(currentPage, itemsPerPage, totalItems, totalPages);
            response.Headers.Add("Pagination", JsonSerializer.Serialize(paginationHeader));
            response.Headers.Add("Access-Control-Expose-Headers", "Pagination");

        }
    }
}
