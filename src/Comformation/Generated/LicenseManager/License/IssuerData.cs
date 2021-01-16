using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.LicenseManager.License
{
    /// <summary>
    /// AWS::LicenseManager::License IssuerData
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-license-issuerdata.html
    /// </summary>
    public class IssuerData
    {

        /// <summary>
        /// Name
        /// Issuer name.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// SignKey
        /// Asymmetric CMK from AWS Key Management Service. The CMK must have a key usage of sign and verify,
        /// and support the RSASSA-PSS SHA-256 signing algorithm.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SignKey")]
        public Union<string, IntrinsicFunction> SignKey { get; set; }

    }
}
