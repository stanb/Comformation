using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.SecurityProfile
{
    /// <summary>
    /// AWS::IoT::SecurityProfile MachineLearningDetectionConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-machinelearningdetectionconfig.html
    /// </summary>
    public class MachineLearningDetectionConfig
    {

        /// <summary>
        /// ConfidenceLevel
        /// The model confidence level.
        /// There are three levels of confidence, &quot;high&quot;, &quot;medium&quot;, and &quot;low&quot;.
        /// The higher the confidence level, the lower the sensitivity, and the lower the alarm frequency will
        /// be.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConfidenceLevel")]
        public Union<string, IntrinsicFunction> ConfidenceLevel { get; set; }

    }
}
