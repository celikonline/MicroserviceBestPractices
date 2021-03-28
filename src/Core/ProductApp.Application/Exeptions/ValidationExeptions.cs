using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Exeptions
{
    public class ValidationExeption : Exception
    {
        public ValidationExeption() : this("This validation Exeption")
        {

        }

        public ValidationExeption(string message) : base(message)
        {
        }
        public ValidationExeption(Exception ex) : this(ex.Message)
        {

        }
    }
}
