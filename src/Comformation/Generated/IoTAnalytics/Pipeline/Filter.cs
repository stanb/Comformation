using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Pipeline
{
    /// <summary>
    /// AWS IoT Analytics Pipeline Filter
    /// The Filter property type specifies a filter for a message based on its attributes for an AWS IoT Analytics
    /// pipeline.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-pipeline-filter.html
    /// </summary>
    public class Filter
    {

        /// <summary>
        /// Filter_
        /// </summary>
        [JsonProperty("Filter")]
        public Union<string, IntrinsicFunction> Filter_ { get; set; }

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
        /// The name of the &#39;filter&#39; activity.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
