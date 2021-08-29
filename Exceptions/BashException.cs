using System;

namespace deployer.Exceptions
{
    public class BashException: Exception
    {
        public int ExitCode { get; set; }
        public BashException (int code, string message): base(message)
        {
            this.ExitCode = code;
        }
    }
}