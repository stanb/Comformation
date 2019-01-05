using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Pipeline
{
    /// <summary>
    /// AWS IoT Analytics Pipeline DeviceRegistryEnrich
    /// The DeviceRegistryEnrich property type specifies data from the AWS IoT device registry which you can add to
    /// your message for an AWS IoT Analytics pipeline.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-pipeline-deviceregistryenrich.html
    /// </summary>
    public class DeviceRegistryEnrich
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
        /// The name of the IoT device whose registry information is added to the message.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ThingName")]
        public Union<string, IntrinsicFunction> ThingName { get; set; }

        /// <summary>
        /// RoleArn
        /// The ARN of the role that allows access to the device&#39;s registry information.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// Name
        /// The name of the &quot;deviceRegistryEnrich&quot; activity.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
