using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.LicenseManager.License
{
    /// <summary>
    /// AWS::LicenseManager::License Entitlement
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-licensemanager-license-entitlement.html
    /// </summary>
    public class Entitlement
    {

        /// <summary>
        /// Name
        /// Entitlement name.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Value
        /// Entitlement resource. Use only if the unit is None.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// MaxCount
        /// Maximum entitlement count. Use if the unit is not None.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxCount")]
        public Union<int, IntrinsicFunction> MaxCount { get; set; }

        /// <summary>
        /// Overage
        /// Indicates whether overages are allowed.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Overage")]
        public Union<bool, IntrinsicFunction> Overage { get; set; }

        /// <summary>
        /// Unit
        /// Entitlement unit.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Unit")]
        public Union<string, IntrinsicFunction> Unit { get; set; }

        /// <summary>
        /// AllowCheckIn
        /// Indicates whether check-ins are allowed.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AllowCheckIn")]
        public Union<bool, IntrinsicFunction> AllowCheckIn { get; set; }

    }
}
