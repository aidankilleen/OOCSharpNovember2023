using System;
using System.Collections.Generic;
using System.Text;

namespace MemberDao
{
    public class MemberDaoException : Exception
    {
        public MemberDaoException(string message) 
            : base(message)
        { 
        }
    }
}
