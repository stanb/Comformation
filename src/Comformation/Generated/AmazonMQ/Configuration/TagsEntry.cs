using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AmazonMQ.Configuration
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amazonmq-configuration-tagsentry.html
    /// </summary>
    public class TagsEntry
    {

        /// <summary>
        /// Value
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

        /// <summary>
        /// Key
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

    }
}
