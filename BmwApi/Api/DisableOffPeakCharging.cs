namespace BmwApi.Core.Api
{
    internal class DisableOffPeakCharging : UpdateChargingBase
    {
        protected override bool SetOffPeakCharging
        {
            get
            {
                return false;
            }
        }
    }
}
