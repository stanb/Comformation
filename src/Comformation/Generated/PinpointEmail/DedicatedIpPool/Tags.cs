using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.PinpointEmail.DedicatedIpPool
{
    /// <summary>
    /// AWS::PinpointEmail::DedicatedIpPool Tags
    /// An object that defines the tags (keys and values) that you want to associate with the dedicated IP pool.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-dedicatedippool-tags.html
    /// </summary>
    public class Tags
    {

        /// <summary>
        /// Value
        /// The optional part of a key-value pair that defines a tag. The maximum length of a tag value is 256
        /// characters. The minimum length is 0 characters. If you don’t want a resource to have a specific tag
        /// value, don’t specify a value for this parameter. Amazon Pinpoint will set the value to an empty
        /// string.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// Key
        /// One part of a key-value pair that defines a tag. The maximum length of a tag key is 128 characters.
        /// The minimum length is 1 character.
        /// If you specify tags for the dedicated IP pool, then this value is required.
        /// Required: Conditional
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

    }
}
