using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTEvents.DetectorModel
{
    /// <summary>
    /// AWS::IoTEvents::DetectorModel Payload
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-payload.html
    /// </summary>
    public class Payload
    {

        /// <summary>
        /// ContentExpression
        /// The content of the payload. You can use a string expression that includes quoted strings
        /// (&#39;&amp;lt;string&amp;gt;&#39;), variables ($variable. &amp;lt;variable-name&amp;gt;), input values ($input.
        /// &amp;lt;input-name&amp;gt;. &amp;lt;path-to-datum&amp;gt;), string concatenations, and quoted strings that contain
        /// ${} as the content. The recommended maximum size of a content expression is 1 KB.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ContentExpression")]
        public Union<string, IntrinsicFunction> ContentExpression { get; set; }

        /// <summary>
        /// Type
        /// The value of the payload type can be either STRING or JSON.
        /// Required: No
        /// Type: String
        /// Allowed values: JSON | STRING
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
