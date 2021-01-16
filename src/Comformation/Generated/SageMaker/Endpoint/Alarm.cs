using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.Endpoint
{
    /// <summary>
    /// AWS::SageMaker::Endpoint Alarm
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-alarm.html
    /// </summary>
    public class Alarm
    {

        /// <summary>
        /// AlarmName
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 255
        /// Pattern: ^(?!\s*$). +
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AlarmName")]
        public Union<string, IntrinsicFunction> AlarmName { get; set; }

    }
}
