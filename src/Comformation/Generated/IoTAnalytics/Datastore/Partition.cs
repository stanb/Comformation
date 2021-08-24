using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Datastore
{
    /// <summary>
    /// AWS::IoTAnalytics::Datastore Partition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-partition.html
    /// </summary>
    public class Partition
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

    }
}
