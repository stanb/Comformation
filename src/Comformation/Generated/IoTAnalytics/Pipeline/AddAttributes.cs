using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Pipeline
{
    /// <summary>
    /// AWS IoT Analytics Pipeline AddAttributes
    /// The AddAttributes property type specifies additional attributes to be added to a message for an AWS IoT
    /// Analytics pipeline.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-pipeline-addattributes.html
    /// </summary>
    public class AddAttributes
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
        /// A list of objects that map an existing attribute to a new attribute in a message.
        /// Required: No
        /// Type: JSON object
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Attributes")]
        public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Attributes { get; set; }

        /// <summary>
        /// Name
        /// The name of the &#39;addAttributes&#39; activity.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
