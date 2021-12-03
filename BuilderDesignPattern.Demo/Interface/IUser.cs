using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Demo.Interface
{
    public interface IUser
    {
        string Name { get; }
        string Address { get; }
        int Age { get; }
    }
}
