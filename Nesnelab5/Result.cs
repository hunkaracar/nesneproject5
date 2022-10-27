using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesnelab5
{
    public class Result
    {
        public bool status { get; set; }
        public string message { get; set; }


        public Result()
        {

        }

        public Result(bool status, string message)
        {
            status = status;
            message = message;
        }
    }

   
}
