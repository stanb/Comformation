using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTEvents.Input
{
    /// <summary>
    /// AWS::IoTEvents::Input Attribute
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-input-attribute.html
    /// </summary>
    public class Attribute
    {

        /// <summary>
        /// JsonPath
        /// An expression that specifies an attribute-value pair in a JSON structure. Use this to specify an
        /// attribute from the JSON payload that is made available by the input. Inputs are derived from
        /// messages sent to AWS IoT Events (BatchPutMessage). Each such message contains a JSON payload. The
        /// attribute (and its paired value) specified here are available for use in the condition expressions
        /// used by detectors.
        /// Syntax: &amp;lt;field-name&amp;gt;. &amp;lt;field-name&amp;gt;. . .
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 128
        /// Pattern: ^((`[\w\- ]+`)|([\w\-]+))(\. ((`[\w- ]+`)|([\w\-]+)))*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("JsonPath")]
        public Union<string, IntrinsicFunction> JsonPath { get; set; }

    }
}
