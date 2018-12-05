using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRental.Common.Exceptions
{
    public class DatabaseException : Exception
    {
        public DatabaseException(string message ="Could not save")
        {
        }

    }

}
