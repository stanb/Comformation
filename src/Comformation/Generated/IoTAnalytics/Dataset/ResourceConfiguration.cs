using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS::IoTAnalytics::Dataset ResourceConfiguration
    /// The configuration of the resource used to execute the &quot;containerAction&quot;.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-resourceconfiguration.html
    /// </summary>
    public class ResourceConfiguration
    {

        /// <summary>
        /// VolumeSizeInGB
        /// The size (in GB) of the persistent storage available to the resource instance used to execute the
        /// &quot;containerAction&quot; (min: 1, max: 50).
        /// Required: Yes
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 50
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VolumeSizeInGB")]
        public Union<int, IntrinsicFunction> VolumeSizeInGB { get; set; }

        /// <summary>
        /// ComputeType
        /// The type of the compute resource used to execute the &quot;containerAction&quot;. Possible values are: ACU_1
        /// (vCPU=4, memory=16GiB) or ACU_2 (vCPU=8, memory=32GiB).
        /// Required: Yes
        /// Type: String
        /// Allowed Values: ACU_1 | ACU_2
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ComputeType")]
        public Union<string, IntrinsicFunction> ComputeType { get; set; }

    }
}
