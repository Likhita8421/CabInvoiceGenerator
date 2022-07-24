using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cab_Invoice_Generator
{
    public class ExceptionHandler:Exception
    {
        public enum ExceptionType
        {
            INVALID_DISTAANCE,
            INVALID_TIME,
        }
        ExceptionType type; 
        public ExceptionHandler(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
