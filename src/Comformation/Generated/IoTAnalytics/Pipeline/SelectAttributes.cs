using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Pipeline
{
    /// <summary>
    /// AWS IoT Analytics Pipeline SelectAttributes
    /// The SelectAttributes property type creates a new message using only the specified attributes from the original
    /// message for an AWS IoT Analytics pipeline.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-pipeline-selectattributes.html
    /// </summary>
    public class SelectAttributes
    {

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
        /// Attributes
        /// A list of the attributes to select from the message.
        /// Required: No
        /// Type: List of String values
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Attributes")]
        public List<Union<string, IntrinsicFunction>> Attributes { get; set; }

        /// <summary>
        /// Name
        /// The name of the &#39;selectAttributes&#39; activity.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
