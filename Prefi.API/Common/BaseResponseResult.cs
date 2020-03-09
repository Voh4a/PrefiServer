using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Prefi.API.Common
{
    public class BaseResponseResult : IActionResult
    {
        private object _data;

        public BaseResponseResult(object data)
        {
            _data = data;
        }

        public async Task ExecuteResultAsync(ActionContext context)
        {
            //var objectResult = new ObjectResult(_result.Exception ?? _Data)
            //{
            //    StatusCode = _result.Exception != null
            //    ? StatusCodes.Status500InternalServerError
            //    : StatusCodes.Status200OK
            //};

            var objectResult = new ObjectResult(_data)
            {
                StatusCode = StatusCodes.Status200OK
            };

            await objectResult.ExecuteResultAsync(context);
        }
    }
}
