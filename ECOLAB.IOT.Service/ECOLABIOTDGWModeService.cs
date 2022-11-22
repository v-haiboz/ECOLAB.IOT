namespace ECOLAB.IOT.Service
{
    using ECOLAB.IOT.Entity;
    using System.Collections.Generic;

    public interface IECOLABIOTDGWModeService
    {
        List<DGWModeConfig> GetDGWMode();

        bool AddOrUpdateDGWMode(DGWModeConfig dGWMode);

        bool RemoveDGWMode(DGWModeConfig dGWMode);

    }

    public class ECOLABIOTDGWModeService : IECOLABIOTDGWModeService
    {
        public bool AddOrUpdateDGWMode(DGWModeConfig dGWModen)
        {

            return CallerContext.ECOLABIOTDGWModeProvider.AddOrUpdateDGWMode(dGWModen);
        }

        public List<DGWModeConfig>? GetDGWMode()
        {

            var list = CallerContext.ECOLABIOTDGWModeProvider.GetDGWMode();
            return list;
        }

     
        public bool RemoveDGWMode(DGWModeConfig dGWMode)
        {
            return CallerContext.ECOLABIOTDGWModeProvider.RemoveDGWMode(dGWMode);
        }

    }
}
