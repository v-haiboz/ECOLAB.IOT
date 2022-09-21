namespace ECOLAB.IOT.Common.Utilities
{
    using System;
    public class CallerContextBase
    {
        public static T Resolve<T>() where T : class
        {
            return Container.GetService(typeof(T)) as T;
        }
        static AsyncLocal<IServiceProvider> AsyncLocal { get; } = new AsyncLocal<IServiceProvider>();
        public static IServiceProvider Container
        {
            get => AsyncLocal.Value;

            set => AsyncLocal.Value = value;
        }
    }
}
