using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.LicenseManager.License
{
    /// <summary>
    /// AWS::LicenseManager::License ConsumptionConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-license-consumptionconfiguration.html
    /// </summary>
    public class ConsumptionConfiguration
    {

        /// <summary>
        /// RenewType
        /// Renewal frequency.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RenewType")]
        public Union<string, IntrinsicFunction> RenewType { get; set; }

        /// <summary>
        /// ProvisionalConfiguration
        /// Details about a provisional configuration.
        /// Required: No
        /// Type: ProvisionalConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ProvisionalConfiguration")]
        public ProvisionalConfiguration ProvisionalConfiguration { get; set; }

        /// <summary>
        /// BorrowConfiguration
        /// Details about a borrow configuration.
        /// Required: No
        /// Type: BorrowConfiguration
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BorrowConfiguration")]
        public BorrowConfiguration BorrowConfiguration { get; set; }

    }
}
