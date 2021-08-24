using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.PublicKey
{
    /// <summary>
    /// AWS::CloudFront::PublicKey PublicKeyConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-publickey-publickeyconfig.html
    /// </summary>
    public class PublicKeyConfig
    {

        /// <summary>
        /// CallerReference
        /// 		
        /// A string included in the request to help make sure that the request can’t be 			replayed.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CallerReference")]
        public Union<string, IntrinsicFunction> CallerReference { get; set; }

        /// <summary>
        /// Comment
        /// 		
        /// A comment to describe the public key. The comment cannot be longer than 128 			characters.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Comment")]
        public Union<string, IntrinsicFunction> Comment { get; set; }

        /// <summary>
        /// EncodedKey
        /// 		
        /// The public key that you can use with signed URLs and signed cookies, or with field-level encryption.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EncodedKey")]
        public Union<string, IntrinsicFunction> EncodedKey { get; set; }

        /// <summary>
        /// Name
        /// 		
        /// A name to help identify the public key.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
