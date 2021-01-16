using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.LicenseManager.License
{
    /// <summary>
    /// AWS::LicenseManager::License ProvisionalConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-license-provisionalconfiguration.html
    /// </summary>
    public class ProvisionalConfiguration
    {

        /// <summary>
        /// MaxTimeToLiveInMinutes
        /// Maximum time for the provisional configuration, in minutes.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxTimeToLiveInMinutes")]
        public Union<int, IntrinsicFunction> MaxTimeToLiveInMinutes { get; set; }

    }
}
