using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.KeyGroup
{
    /// <summary>
    /// AWS::CloudFront::KeyGroup KeyGroupConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-keygroup-keygroupconfig.html
    /// </summary>
    public class KeyGroupConfig
    {

        /// <summary>
        /// Comment
        /// 		
        /// A comment to describe the key group. The comment cannot be longer than 128 			characters.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Comment")]
        public Union<string, IntrinsicFunction> Comment { get; set; }

        /// <summary>
        /// Items
        /// 		
        /// A list of the identifiers of the public keys in the key group.
        /// 	
        /// Required: Yes
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Items")]
        public List<Union<string, IntrinsicFunction>> Items { get; set; }

        /// <summary>
        /// Name
        /// 		
        /// A name to identify the key group.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
