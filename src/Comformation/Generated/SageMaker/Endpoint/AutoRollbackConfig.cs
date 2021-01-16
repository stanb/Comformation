using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SageMaker.Endpoint
{
    /// <summary>
    /// AWS::SageMaker::Endpoint AutoRollbackConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-autorollbackconfig.html
    /// </summary>
    public class AutoRollbackConfig
    {

        /// <summary>
        /// Alarms
        /// Required: Yes
        /// Type: List of Alarm
        /// Maximum: 10
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Alarms")]
        public List<Alarm> Alarms { get; set; }

    }
}
