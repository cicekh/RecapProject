using Castle.DynamicProxy;
using System;
using System.Reflection;
using System.Linq;

namespace Core.Utilities.Interceptors
{
    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>
                (true).ToList();
            var methodAttributes = type.GetMethod(method.Name)
                .GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
            classAttributes.AddRange(methodAttributes);
            //classAttributes.Add(new ExceptionLogAspect(typeof(FileLogger)));
            //üstteki tüm işlemlerde loglamayı sağlar ama şu anda loglama altyapısı mevcut değil. Default olarak loglama yapmak istersen, Programcı logalama yaptı mı yapmadı mı düşünmeye gerek yok.
            return classAttributes.OrderBy(x => x.Priority).ToArray();
        }
    }
}
 