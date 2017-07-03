using System.Collections.Generic;
using ProWritingAid.SDK.Model;

namespace ProWritingAid.SDK.Api
{
    public class ApiBase
    {
        protected void SetRequestCredentials(
            Dictionary<string, string> localVarHeaderParams,
            AnalysisRequestBase request)
        {
            if (request.Credentials != null)
            {
                localVarHeaderParams["licenseCode"] = request.Credentials.LicenseCode;
            }
        }

        protected void SetRequestCredentials(
            Dictionary<string, string> localVarHeaderParams,
            RequestCredentials credentials)
        {
            if (credentials != null)
            {
                localVarHeaderParams["licenseCode"] = credentials.LicenseCode;
            }
        }
    }
}