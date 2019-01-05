using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS IoT Analytics Dataset ResourceConfiguration
    /// The ResourceConfiguration property type specifies the configuration of the resource which executes the
    /// &#39;containerAction&#39; for an AWS IoT Analytics dataset.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-resourceconfiguration.html
    /// </summary>
    public class ResourceConfiguration
    {

        /// <summary>
        /// VolumeSizeInGB
        /// The size of the persistent storage available to the resource instance used to execute the
        /// &#39;containerAction&#39;.
        /// Required: Yes
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VolumeSizeInGB")]
        public Union<int, IntrinsicFunction> VolumeSizeInGB { get; set; }

        /// <summary>
        /// ComputeType
        /// The type of the compute resource used to execute the &#39;containerAction&#39; (ACU_1|ACU_2).
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ComputeType")]
        public Union<string, IntrinsicFunction> ComputeType { get; set; }

    }
}
