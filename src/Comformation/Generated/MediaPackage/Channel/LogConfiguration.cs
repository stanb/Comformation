using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaPackage.Channel
{
    /// <summary>
    /// AWS::MediaPackage::Channel LogConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-channel-logconfiguration.html
    /// </summary>
    public class LogConfiguration
    {

        /// <summary>
        /// LogGroupName
        /// Sets a custom Amazon CloudWatch log group name.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogGroupName")]
        public Union<string, IntrinsicFunction> LogGroupName { get; set; }

    }
}
