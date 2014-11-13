using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StructureMapMVC5.Models
{
    public interface IMessageFactory
    {
        string GetMessage();
    }
    public class MessageFactory : IMessageFactory
    {
        public string GetMessage()
        {
            return "Class: " + GetType().FullName;
        }
    }
}