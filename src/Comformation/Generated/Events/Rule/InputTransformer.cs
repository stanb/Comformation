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
        /// many as 100 key-value pairs. You must use JSON dot notation, not bracket notation.
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
        /// brackets: &amp;lt;value&amp;gt; The InputTemplate must be valid JSON.
        /// If InputTemplate is a JSON object (surrounded by curly braces), the following restrictions apply:
        /// The placeholder cannot be used as an object key.
        /// The following example shows the syntax for using InputPathsMap and InputTemplate.
        /// &quot;InputTransformer&quot;:
        /// {
        /// &quot;InputPathsMap&quot;: {&quot;instance&quot;: &quot;$. detail. instance&quot;,&quot;status&quot;: &quot;$. detail. status&quot;},
        /// &quot;InputTemplate&quot;: &quot;&amp;lt;instance&amp;gt; is in state &amp;lt;status&amp;gt;&quot;
        /// }
        /// To have the InputTemplate include quote marks within a JSON string, escape each quote marks with a
        /// slash, as in the following example:
        /// &quot;InputTransformer&quot;:
        /// {
        /// &quot;InputPathsMap&quot;: {&quot;instance&quot;: &quot;$. detail. instance&quot;,&quot;status&quot;: &quot;$. detail. status&quot;},
        /// &quot;InputTemplate&quot;: &quot;&amp;lt;instance&amp;gt; is in state \&quot;&amp;lt;status&amp;gt;\&quot;&quot;
        /// }
        /// The InputTemplate can also be valid JSON with varibles in quotes or out, as in the following
        /// example:
        /// &quot;InputTransformer&quot;:
        /// {
        /// &quot;InputPathsMap&quot;: {&quot;instance&quot;: &quot;$. detail. instance&quot;,&quot;status&quot;: &quot;$. detail. status&quot;},
        /// &quot;InputTemplate&quot;: &#39;{&quot;myInstance&quot;: &amp;lt;instance&amp;gt;,&quot;myStatus&quot;: &quot;&amp;lt;instance&amp;gt; is in state
        /// \&quot;&amp;lt;status&amp;gt;\&quot;&quot;}&#39;
        /// }
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
