using ProWritingAid.SDK.Client;

namespace ProWritingAid.SDK.Api
{
    public static class ApiExtensions
    {
        public static TApi SetLicenseCode<TApi>(this TApi api, string value)
            where TApi : IApiAccessor
        {
            if (!string.IsNullOrEmpty(value))
            {
                api.Configuration.AddApiKey(ApiHeaders.Key, value);
            }
            return api;
        }

        public static TApi ClearHeaders<TApi>(this TApi api)
            where TApi : IApiAccessor
        {
            api.Configuration.DefaultHeader.Clear();
            api.Configuration.ApiKey.Clear();
            api.Configuration.ApiKeyPrefix.Clear();
            return api;
        }
    }
}