using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.Thing
{
    /// <summary>
    /// AWS IoT Thing AttributePayload
    /// The AttributePayload property specifies up to three attributes for an AWS IoT as key–value pairs.
    /// AttributePayload is a property of the AWS::IoT::Thing resource.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-thing-attributepayload.html
    /// </summary>
    public class AttributePayload
    {

        /// <summary>
        /// Attributes
        /// A string that contains up to three key–value pairs. Maximum length of 800. Duplicates not allowed.
        /// Required: No
        /// Type: String to string map
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Attributes")]
        public Dictionary<string, Union<string, IntrinsicFunction>> Attributes { get; set; }

    }
}
