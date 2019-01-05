using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTAnalytics.Pipeline
{
    /// <summary>
    /// AWS IoT Analytics Pipeline Math
    /// The Math property type specifies an arithmetic expression which is computed using the message&#39;s attributes and
    /// whose result is added to the message for an AWS IoT Analytics pipeline.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-pipeline-math.html
    /// </summary>
    public class Math
    {

        /// <summary>
        /// Attribute
        /// The name of the attribute that will contain the result of the math operation.
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
        /// Math_
        /// </summary>
        [JsonProperty("Math")]
        public Union<string, IntrinsicFunction> Math_ { get; set; }

        /// <summary>
        /// Name
        /// The name of the &#39;math&#39; activity.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
