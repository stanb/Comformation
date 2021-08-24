using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaPackage.PackagingGroup
{
    /// <summary>
    /// AWS::MediaPackage::PackagingGroup LogConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediapackage-packaginggroup-logconfiguration.html
    /// </summary>
    public class LogConfiguration
    {

        /// <summary>
        /// LogGroupName
        /// Sets a custom Amazon CloudWatch log group name for egress logs. If a log group name isn&#39;t specified,
        /// the default name is used: /aws/MediaPackage/EgressAccessLogs.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogGroupName")]
        public Union<string, IntrinsicFunction> LogGroupName { get; set; }

    }
}
