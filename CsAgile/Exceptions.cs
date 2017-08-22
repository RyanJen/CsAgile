using System;
using System.Runtime.Serialization;

namespace CsAgile
{
    public class ServiceExceptions : Exception, ISerializable
    {
        public ServiceExceptions()
        : base("show message") { }
        public ServiceExceptions(string message)
        : base(message) { }
        public ServiceExceptions(string message, Exception inner)
        : base(message, inner) { }
        protected ServiceExceptions(SerializationInfo info, StreamingContext context)
        : base(info, context) { }
    }

    public class DomainException : Exception, ISerializable
    {
        //public DomainException()
        //: base("show message") { }
        //public DomainException(string message) 
        //: base(message) { }
        //public DomainException(string message, Exception inner) 
        //: base(message, inner) { }
        //protected DomainException(SerializationInfo info, StreamingContext context) 
        //: base(info, context) { }
    }
}