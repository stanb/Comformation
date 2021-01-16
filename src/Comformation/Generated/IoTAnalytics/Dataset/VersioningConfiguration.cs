using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS::IoTAnalytics::Dataset VersioningConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-versioningconfiguration.html
    /// </summary>
    public class VersioningConfiguration
    {

        /// <summary>
        /// MaxVersions
        /// How many versions of dataset contents are kept. The unlimited parameter must be false.
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 1000
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxVersions")]
        public Union<int, IntrinsicFunction> MaxVersions { get; set; }

        /// <summary>
        /// Unlimited
        /// If true, unlimited versions of dataset contents are kept.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Unlimited")]
        public Union<bool, IntrinsicFunction> Unlimited { get; set; }

    }
}
