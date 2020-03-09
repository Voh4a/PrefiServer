using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Prefi.Common.Controllers
{
    [ApiController]
    //[Authorize(Policy = "ApiUser")]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        //private IMediator _mediator;
        private IHttpContextAccessor _httpContextAccessor;

        //protected IMediator Mediator => _mediator ?? (_mediator = HttpContext.RequestServices.GetService<IMediator>());
        protected IHttpContextAccessor HttpContextAccessor => _httpContextAccessor ?? (_httpContextAccessor = HttpContext.RequestServices.GetService<IHttpContextAccessor>());


        //protected string UserId => HttpContextAccessor.GetUserId();

        //protected bool IsInRole(string roleName)
        //{
        //    return HttpContextAccessor.IsInRole(roleName.ToUpper());
        //}

        /// <summary>
        /// Creates Project specific JSON response
        /// </summary>
        /// <param name="success">true if result is succeed</param>
        /// <param name="message">response message</param>
        /// <param name="data">response object</param>
        /// <param name="statusCode">Response Status code</param>
        /// <returns>extended Json result</returns>
        protected Json BaseJsonResult(bool success, string message = null, object data = null, BaseStatusCode statusCode = BaseStatusCode.Ok)
        {
            //if (data is string str)
            //{
            //    data = JObject.Parse(str);
            //}

            var result = new JsonResult(new ResponseResult(success, message, data))
            {
                StatusCode = (int)statusCode,
                ContentType = "application/json"
            };

            return result;
        }
    }
}
