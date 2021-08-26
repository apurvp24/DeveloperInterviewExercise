using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData
{
    class InvalidArgumentsException : Exception
    {
        public InvalidArgumentsException() { }

        public InvalidArgumentsException(string args)
            : base(String.Format("Invalid arguments {0}", args))
        {

        }
    }

    
}
