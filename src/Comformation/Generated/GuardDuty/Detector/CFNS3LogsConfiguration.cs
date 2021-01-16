using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GuardDuty.Detector
{
    /// <summary>
    /// AWS::GuardDuty::Detector CFNS3LogsConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-detector-cfns3logsconfiguration.html
    /// </summary>
    public class CFNS3LogsConfiguration
    {

        /// <summary>
        /// Enable
        /// The status of S3 data event logs as a data source.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enable")]
        public Union<bool, IntrinsicFunction> Enable { get; set; }

    }
}
