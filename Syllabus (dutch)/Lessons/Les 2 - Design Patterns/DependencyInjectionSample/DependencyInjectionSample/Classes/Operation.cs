using DependencyInjectionSample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionSample.Classes
{
    public class Operation : IOperationTransient, IOperationScoped, IOperationSingleton, IOperationSingletonInstance
    {
        Guid _guid;
        public Operation() : this(Guid.NewGuid())
        {

        }

        public Operation(Guid guid)
        {
            _guid = guid;
        }

        public Guid OperationId => _guid;
    }

    public class Operation1 : IOperationTransient, IOperationScoped, IOperationSingleton, IOperationSingletonInstance
    {
        Guid _guid;
        public Operation1() : this(new Guid("e3ae581f-d36c-4e05-8d37-633585253633"))
        {

        }

        public Operation1(Guid guid)
        {
            _guid = guid;
        }

        public Guid OperationId => _guid;
    }
}
