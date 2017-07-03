using System;
using System.IO;

namespace ProWritingAid.SDK.Model
{
    public class AnalysisRequestBase
    {
        internal RequestCredentials Credentials { get; }

        public AnalysisRequestBase(RequestCredentials credentials)
        {
            Credentials = credentials;
        }
    }

    public class RequestCredentials
    {
        public readonly string LicenseCode;
        
        public RequestCredentials(string liceneCode)
        {
            if (string.IsNullOrEmpty(liceneCode))
            {
                throw new ArgumentException("Value cannot be null or empty.", nameof(liceneCode));
            }
            LicenseCode = liceneCode;
        }
    }
}