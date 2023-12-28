using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct EError
{
    public string message;

    public EError(string message)
    {
         this.message = message;
    }
}

namespace JobPortal.models
{
    internal class Response<T>
    {
        public string status {  get; set; }
        public bool success { get; set; }
        public Nullable<EError> error { get; set; }
        public T Data { get; } 

       public Response(string status, bool success, EError error, T data)
        {
            this.status = status;
            this.success = success;
            this.error = error;
            this.Data = data;
        }
    }
}
