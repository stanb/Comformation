using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.StreamingDistribution
{
    /// <summary>
    /// AWS::CloudFront::StreamingDistribution TrustedSigners
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-streamingdistribution-trustedsigners.html
    /// </summary>
    public class TrustedSigners
    {

        /// <summary>
        /// Enabled
        /// 		
        /// This field is true if any of the AWS accounts have public keys that CloudFront can 			use to verify
        /// the signatures of signed URLs and signed cookies. If not, this field is 			false.
        /// 	
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

        /// <summary>
        /// AwsAccountNumbers
        /// 		
        /// An AWS account number that contains active CloudFront key pairs that CloudFront can use to verify
        /// the 			signatures of signed URLs and signed cookies. If the AWS account that owns the key pairs
        /// 			is the same account that owns the CloudFront distribution, the value of this field is 			self.
        /// 	
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AwsAccountNumbers")]
        public List<Union<string, IntrinsicFunction>> AwsAccountNumbers { get; set; }

    }
}
