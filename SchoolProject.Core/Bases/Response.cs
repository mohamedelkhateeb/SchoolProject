using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Bases
{
    public class Response<T>
    {
        public Response()
        {

        }
        //public Response(T data, string message = null)
        //{
        //    IsSuccess = true;
        //    Data = data;
        //}
        //public Response(string message)
        //{
        //    IsSuccess = false;
        //    Message = message;
        //}
        //public Response(string message, bool succeeded)
        //{
        //    IsSuccess = succeeded;
        //    Message = message;
        //    Message = message;
        //}

        public HttpStatusCode StatusCode { get; set; }
        public object Meta { get; set; }

        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }
        //public Dictionary<string, List<string>> ErrorsBag { get; set; }
        public T Data { get; set; }
    }

}
