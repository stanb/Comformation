using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Dataset
{
    /// <summary>
    /// AWS::IoTAnalytics::Dataset IotEventsDestinationConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-dataset-ioteventsdestinationconfiguration.html
    /// </summary>
    public class IotEventsDestinationConfiguration
    {

        /// <summary>
        /// InputName
        /// The name of the AWS IoT Events input to which dataset contents are delivered.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Pattern: ^[a-zA-Z][a-zA-Z0-9_]*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputName")]
        public Union<string, IntrinsicFunction> InputName { get; set; }

        /// <summary>
        /// RoleArn
        /// The ARN of the role that grants AWS IoT Analytics permission to deliver dataset contents to an AWS
        /// IoT Events input.
        /// Required: Yes
        /// Type: String
        /// Minimum: 20
        /// Maximum: 2048
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

    }
}
