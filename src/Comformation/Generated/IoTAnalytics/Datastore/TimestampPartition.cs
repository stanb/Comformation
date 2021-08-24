using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Datastore
{
    /// <summary>
    /// AWS::IoTAnalytics::Datastore TimestampPartition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-timestamppartition.html
    /// </summary>
    public class TimestampPartition
    {

        /// <summary>
        /// AttributeName
        /// Not currently supported by AWS CloudFormation.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AttributeName")]
        public Union<string, IntrinsicFunction> AttributeName { get; set; }

        /// <summary>
        /// TimestampFormat
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimestampFormat")]
        public Union<string, IntrinsicFunction> TimestampFormat { get; set; }

    }
}
