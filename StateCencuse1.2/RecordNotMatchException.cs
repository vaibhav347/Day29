using System;
using System.Collections.Generic;
using System.Text;

namespace StateCencuse
{
    public class RecordNotMatchException:Exception
    {
        public RecordNotMatchException(string msg):base(msg)
        {

        }
    }
}
