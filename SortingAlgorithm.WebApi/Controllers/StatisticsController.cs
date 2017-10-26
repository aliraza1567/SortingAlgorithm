using SortingAlgorithm.Operations.Statistics;
using SortingAlgorithm.WebApi.Models;
using System.Web.Http;

namespace SortingAlgorithm.WebApi.Controllers
{
    public class StatisticsController : ApiController
    {
        private readonly ICalculateStatistics _calculateStatistics;

        public StatisticsController()
        {
            _calculateStatistics = new CalculateStatistics();
        }

        [HttpPost]
        public IHttpActionResult SelectionSort([FromBody] RequestDto requestDto)
        {
            

            return Ok("");
        }
    }
}
