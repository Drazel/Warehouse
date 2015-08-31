using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Data.Result
{
    public class BoolResult
    {
        public bool Succes { get; set; }
        public string Message { get; set; }
        public string FullMessage { get; set; }

        public BoolResult()
        {
            Succes = false;
        }

        public void SetSucces()
        {
            Succes = true;
        }

        public void SetError(string message)
        {
            Message = message;
        }

        public void SetError(Exception ex)
        {
            Message = ex.Message;
            FullMessage = ex.ToString();
        }
    }
}
