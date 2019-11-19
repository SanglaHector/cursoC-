using System;

namespace Entities.Exceptions
{
    public class WhatsappException :Exception
    {
        public WhatsappException(string e) : base(e)
        {
        }
    }
}
