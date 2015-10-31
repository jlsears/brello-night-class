using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brello.Models
{
    // What is an interface? Just a list of methods
    // Cannot create an instance of an interface
    public interface ICar
    {
        string Honk();
    }



    public class Car
    {
        // In order for Moq to change behavior, method must be virtual
        public virtual string Horn()
        {
            ReadyEngines();
            return "HONK!";
        }

        // Even when counting method calls, methods should be virtual
        public virtual void ReadyEngines() { }
    }
}