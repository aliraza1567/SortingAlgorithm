using SortingAlgorithm.Operations.Sortings;
using SortingAlgorithm.WebApi.Models;
using System.Web.Http;

namespace SortingAlgorithm.WebApi.Controllers
{
    public class SortingController : ApiController
    {
        private readonly ISorting _sorting;

        public SortingController()
        {
            _sorting = new Sorting();
        }

        [HttpPost]
        public IHttpActionResult SelectionSort([FromBody] SortingRequestDto requestDto)
        {
            var result = _sorting.SelectionSort(requestDto.InputString);

            return Ok(result);
        }
    }
}
