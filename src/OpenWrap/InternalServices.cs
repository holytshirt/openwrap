namespace OpenRasta.Wrap.Build.Services
{
    public static class InternalServices
    {
        public static void Initialize()
        {
            WrapServices.TryRegisterService<IWrapDescriptorMonitoringService>(() => new WrapDescriptorMonitor());
        }
    }
}