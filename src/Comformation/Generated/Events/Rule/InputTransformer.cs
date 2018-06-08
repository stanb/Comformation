using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Events.Rule
{
    /// <summary>
    /// Amazon CloudWatch Events Rule InputTransformer
    /// The InputTransformer property type specifies settings that provide custom input to an Amazon CloudWatch Events
    /// rule target based on certain event data.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-inputtransformer.html
    /// </summary>
    public class InputTransformer
    {

        /// <summary>
        /// InputPathsMap
        /// The map of JSON paths to extract from the event, as key-value pairs where each value is a JSON path.
        /// You must use JSON dot notation, not bracket notation. Duplicates aren't allowed.
        /// Required: No
        /// Type: String-to-string map
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputPathsMap")]
        public Union<Dictionary<string, string>, IntrinsicFunction> InputPathsMap { get; set; }

        /// <summary>
        /// InputTemplate
        /// The input template where you can use the values of the keys from InputPathsMap to customize the data
        /// that's sent to the target.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputTemplate")]
        public Union<string, IntrinsicFunction> InputTemplate { get; set; }

    }
}
