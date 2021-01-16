using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Events.Rule
{
    /// <summary>
    /// AWS::Events::Rule InputTransformer
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-inputtransformer.html
    /// </summary>
    public class InputTransformer
    {

        /// <summary>
        /// InputPathsMap
        /// Map of JSON paths to be extracted from the event. You can then insert these in the template in
        /// InputTemplate to produce the output you want to be sent to the target.
        /// InputPathsMap is an array key-value pairs, where each value is a valid JSON path. You can have as
        /// many as 10 key-value pairs. You must use JSON dot notation, not bracket notation.
        /// The keys cannot start with &quot;AWS. &quot;
        /// Required: No
        /// Type: Map of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputPathsMap")]
        public Dictionary<string, Union<string, IntrinsicFunction>> InputPathsMap { get; set; }

        /// <summary>
        /// InputTemplate
        /// Input template where you specify placeholders that will be filled with the values of the keys from
        /// InputPathsMap to customize the data sent to the target. Enclose each InputPathsMaps value in
        /// brackets: &amp;lt;value&amp;gt; The InputTemplate must be valid JSON. For more information, see
        /// InputTransformer in the Amazon EventBridge API Reference.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 8192
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputTemplate")]
        public Union<string, IntrinsicFunction> InputTemplate { get; set; }

    }
}
