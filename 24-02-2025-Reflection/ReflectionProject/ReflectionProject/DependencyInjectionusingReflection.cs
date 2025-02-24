using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionProject
{
    [AttributeUsage(AttributeTargets.Constructor)]
    class InjectAttribute : Attribute { }

    interface IService
    {
        void Serve();
    }

    class ServiceA : IService
    {
        public void Serve() => Console.WriteLine("ServiceA is serving.");
    }

    class Client
    {
        private readonly IService _service;

        [Inject]
        public Client(IService service) => _service = service;

        public void DoWork() => _service.Serve();
    }

    class DIContainer
    {
        private Dictionary<Type, Type> _registrations = new Dictionary<Type, Type>();

        public void Register<TInterface, TImplementation>() where TImplementation : TInterface
        {
            _registrations[typeof(TInterface)] = typeof(TImplementation);
        }

        public T Resolve<T>()
        {
            Type type = typeof(T);
            ConstructorInfo constructor = type.GetConstructors()[0];

            if (constructor.GetCustomAttribute<InjectAttribute>() != null)
            {
                ParameterInfo[] parameters = constructor.GetParameters();
                object[] args = new object[parameters.Length];

                for (int i = 0; i < parameters.Length; i++)
                {
                    args[i] = Activator.CreateInstance(_registrations[parameters[i].ParameterType]);
                }

                return (T)Activator.CreateInstance(type, args);
            }
            return (T)Activator.CreateInstance(type);
        }
    }

    class DependencyInjectionusingReflection
    {
        static void Main()
        {
            DIContainer container = new DIContainer();
            container.Register<IService, ServiceA>();

            Client client = container.Resolve<Client>();
            client.DoWork(); 
        }
    }
}
