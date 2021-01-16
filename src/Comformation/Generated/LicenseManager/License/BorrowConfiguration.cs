using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.LicenseManager.License
{
    /// <summary>
    /// AWS::LicenseManager::License BorrowConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-license-borrowconfiguration.html
    /// </summary>
    public class BorrowConfiguration
    {

        /// <summary>
        /// MaxTimeToLiveInMinutes
        /// Maximum time for the borrow configuration, in minutes.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxTimeToLiveInMinutes")]
        public Union<int, IntrinsicFunction> MaxTimeToLiveInMinutes { get; set; }

        /// <summary>
        /// AllowEarlyCheckIn
        /// Indicates whether early check-ins are allowed.
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AllowEarlyCheckIn")]
        public Union<bool, IntrinsicFunction> AllowEarlyCheckIn { get; set; }

    }
}
