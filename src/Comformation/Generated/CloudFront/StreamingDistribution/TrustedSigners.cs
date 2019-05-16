using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.StreamingDistribution
{
    /// <summary>
    /// AWS::CloudFront::StreamingDistribution TrustedSigners
    /// A complex type that specifies the AWS accounts, if any, that you want to allow to 			create signed URLs for
    /// private content.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-streamingdistribution-trustedsigners.html
    /// </summary>
    public class TrustedSigners
    {

        /// <summary>
        /// Enabled
        /// 		
        /// Specifies whether you want to require viewers to use signed URLs to access the files 			specified by
        /// PathPattern and TargetOriginId.
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
        /// An AWS account that is included in the TrustedSigners complex type for 			this distribution. Valid
        /// values include:
        /// 		
        /// 			 			 		 self, which is the AWS account used to create the distribution. An AWS account number.
        /// 	
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AwsAccountNumbers")]
        public List<Union<string, IntrinsicFunction>> AwsAccountNumbers { get; set; }

    }
}
