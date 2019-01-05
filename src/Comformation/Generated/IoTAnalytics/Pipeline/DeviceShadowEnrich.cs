using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Pipeline
{
    /// <summary>
    /// AWS IoT Analytics Pipeline DeviceShadowEnrich
    /// The DeviceShadowEnrich property type specifies information from the AWS IoT Device Shadows service to add to a
    /// message for an AWS IoT Analytics pipeline.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-pipeline-deviceshadowenrich.html
    /// </summary>
    public class DeviceShadowEnrich
    {

        /// <summary>
        /// Attribute
        /// The name of the attribute that is added to the message.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Attribute")]
        public Union<string, IntrinsicFunction> Attribute { get; set; }

        /// <summary>
        /// Next
        /// The next activity in the pipeline.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Next")]
        public Union<string, IntrinsicFunction> Next { get; set; }

        /// <summary>
        /// ThingName
        /// The name of the IoT device whose shadow information is added to the message.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ThingName")]
        public Union<string, IntrinsicFunction> ThingName { get; set; }

        /// <summary>
        /// RoleArn
        /// The ARN of the role that allows access to the device&#39;s shadow.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// Name
        /// The name of the &#39;deviceShadowEnrich&#39; activity.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
