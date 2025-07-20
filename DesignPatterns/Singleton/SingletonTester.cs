using System;

namespace DesignPatterns.Singleton
{
    public static class SingletonTester
    {
        public static bool IsSingleton(Func<object> func)
        {
            object obj1 = func();
            object obj2 = func();

            if (obj1 != obj2)
                return false;

            return obj1 == obj2;
        }
    }
}
