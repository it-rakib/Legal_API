using System.Collections.Generic;

namespace Common.Service.Responses
{
    public class BaseResponse
    {
        public BaseResponse()
        {
            Success = true;
        }
        public BaseResponse(string message = null)
        {
            Success = true;
            Message = message;
        }
        public BaseResponse(string message, bool sucess,string statusCode)
        {
            Success = sucess;
            Message = message;
            StatusCode = statusCode;
        }
        public bool Success { get; set; }
        public string Message { get; set; }
        public string StatusCode { get; set; }
        public List<string> ValidationErrors { get; set; }
    }
}
