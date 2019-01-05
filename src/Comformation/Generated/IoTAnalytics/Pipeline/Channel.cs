using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Pipeline
{
    /// <summary>
    /// AWS IoT Analytics Pipeline Channel
    /// The Channel property type specifies the source of messages to be processed for an AWS IoT Analytics pipeline.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-pipeline-channel.html
    /// </summary>
    public class Channel
    {

        /// <summary>
        /// ChannelName
        /// The name of the channel from which the messages are processed.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ChannelName")]
        public Union<string, IntrinsicFunction> ChannelName { get; set; }

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
        /// Name
        /// The name of the &#39;channel&#39; activity.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
