using SortingAlgorithm.WebApi.Models;
using System.Web.Http;
using Convert = SortingAlgorithm.Operations.Conversion.Convert;

namespace SortingAlgorithm.WebApi.Controllers
{
    public class ConversionController : ApiController
    {
        [HttpPost]
        public IHttpActionResult StringToArray([FromBody] RequestDto requestDto)
        {
            var result = Convert.ArrayToString(requestDto.InputString);

            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult ArrayToStringTest([FromBody] RequestDto requestDto)
        {
            var result = Convert.ArrayToString(requestDto.InputString);

            return Ok(result);
        }
    }
}
