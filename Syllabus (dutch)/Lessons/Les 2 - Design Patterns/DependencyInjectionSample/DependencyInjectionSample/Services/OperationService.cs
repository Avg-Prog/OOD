using DependencyInjectionSample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionSample.Services
{
    public class OperationService
    {
        public IOperationTransient TransientOperation { get; }
        public IOperationScoped ScopedOperation { get; }
        public IOperationSingleton SingletonOperation { get;  }
        public IOperationSingletonInstance SingletonInstanceOperation { get; }


        public OperationService(IOperationTransient transientOperation, IOperationScoped scopedOperation,
            IOperationSingleton singletonOperation, IOperationSingletonInstance singletonInstaneOperation)
        {
            TransientOperation = transientOperation;
            ScopedOperation = scopedOperation;
            SingletonOperation = singletonOperation;
            SingletonInstanceOperation = singletonInstaneOperation;
        }
    }
}
