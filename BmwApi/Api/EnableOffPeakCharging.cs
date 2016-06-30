namespace BmwApi.Core.Api
{
    internal class EnableOffPeakCharging : UpdateChargingBase
    {
        protected override bool SetOffPeakCharging
        {
            get
            {
                return true;
            }
        }
    }
}
