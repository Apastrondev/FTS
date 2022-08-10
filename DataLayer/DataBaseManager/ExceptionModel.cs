using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataBaseManager
{
    public class ExceptionModel
    {
        public ExceptionModel(Exception ex, int? userId = null, string exceptionURL = null)
        {
            Exception = ex;
            UserId = userId;
            ExceptionURL = ExceptionURL;
        }

        public Exception Exception;
        public int? UserId { get; internal set; }
        public string ExceptionURL { get; internal set; }
    }
}
