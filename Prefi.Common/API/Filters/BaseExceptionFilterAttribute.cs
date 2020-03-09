using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace Prefi.Common.API.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class BaseExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            //BaseStatusCode statusCode;
            //JsonResult responseResult;

            //switch (context.Exception)
            //{
            //    case ValidationException exception:
            //        statusCode = BaseStatusCode.BadRequest;
            //        responseResult = FormingResponse(new ResponseResult(exception.Errors, exception.Message), statusCode);
            //        break;
            //    case NotFoundException _:
            //        statusCode = BaseStatusCode.NotFound;
            //        responseResult = FormingResponse(new ResponseResult(context.Exception.Message, context.Exception.Message), statusCode);
            //        break;
            //    case UserExistException _:
            //        statusCode = BaseStatusCode.BadRequest;
            //        responseResult = FormingResponse(new ResponseResult(false, context.Exception.Message), statusCode);
            //        break;
            //    case FailureCreateException _:
            //        statusCode = BaseStatusCode.BadRequest;
            //        responseResult = FormingResponse(new ResponseResult(false, context.Exception.Message), statusCode);
            //        break;
            //    case DeleteFailureException _:
            //        statusCode = BaseStatusCode.Forbidden;
            //        responseResult = FormingResponse(new ResponseResult(false, context.Exception.Message), statusCode);
            //        break;
            //    case EmailSenderException _:
            //        statusCode = BaseStatusCode.BadRequest;
            //        responseResult = FormingResponse(new ResponseResult(false, context.Exception.Message), statusCode);
            //        break;
            //    case DeniedUploadFileException _:
            //        statusCode = BaseStatusCode.BadRequest;
            //        responseResult = FormingResponse(new ResponseResult(false, context.Exception.Message), statusCode);
            //        break;
            //    case TutorAvailabilityException exception:
            //        statusCode = BaseStatusCode.BadRequest;
            //        responseResult = FormingResponse(new ResponseResult(false, exception.Message, exception.Periods), statusCode);
            //        break;
            //    case PaymentFailureException exception:
            //        statusCode = (BaseStatusCode)exception.StatusCode;
            //        responseResult = FormingResponse(new ResponseResult(false, exception.Message), statusCode);
            //        break;
            //    case WizIqException exception:
            //        statusCode = BaseStatusCode.BadRequest;
            //        responseResult = FormingResponse(new ResponseResult(false, $"{exception.Message} wiziq code: {exception.wizIqCode}"), statusCode);
            //        break;
            //    default:
            //        statusCode = BaseStatusCode.ServerError;
            //        responseResult = FormingResponse(new ResponseResult("Something went wrong. Try later.", context.Exception.Message), statusCode);
            //        break;
            //}


            //context.HttpContext.Response.StatusCode = (int)statusCode;
            //context.Result = responseResult;

            //TODO: If need StackTrace
            //context.Result = new JsonResult(new
            //{
            //    error = new[] { context.Exception.Message },
            //    stackTrace = context.Exception.StackTrace
            //});
        }

        //private JsonResult FormingResponse(ResponseResult result, BaseStatusCode statusCode)
        //{
        //    var jsonResult = new JsonResult(result)
        //    {
        //        StatusCode = (int)statusCode,
        //        ContentType = "application/json"
        //    };

        //    return jsonResult;
        //}
    }
}
