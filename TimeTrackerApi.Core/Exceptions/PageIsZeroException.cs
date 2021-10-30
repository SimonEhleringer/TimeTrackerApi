using System;
using System.Collections.Generic;
using System.Text;

namespace TimeTrackerApi.Core.Exceptions
{
    public class PageIsZeroException : Exception
    {
        public PageIsZeroException() : base("Page is 0")
        {
        }
    }
}
