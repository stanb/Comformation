using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.StreamingDistribution
{
    /// <summary>
    /// AWS::CloudFront::StreamingDistribution S3Origin
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-streamingdistribution-s3origin.html
    /// </summary>
    public class S3Origin
    {

        /// <summary>
        /// DomainName
        /// 		
        /// The DNS name of the Amazon S3 origin.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DomainName")]
        public Union<string, IntrinsicFunction> DomainName { get; set; }

        /// <summary>
        /// OriginAccessIdentity
        /// 		
        /// The CloudFront origin access identity to associate with the distribution. Use an origin 			access
        /// identity to configure the distribution so that end users can only access objects in an 			Amazon S3
        /// bucket through CloudFront.
        /// 		
        /// If you want end users to be able to access objects using either the CloudFront URL or the 			Amazon
        /// S3 URL, specify an empty OriginAccessIdentity element.
        /// 		
        /// To delete the origin access identity from an existing distribution, update the 			distribution
        /// configuration and include an empty OriginAccessIdentity 			element.
        /// 		
        /// To replace the origin access identity, update the distribution configuration and 			specify the new
        /// origin access identity.
        /// 		
        /// For more information, see Using an Origin Access 				Identity to Restrict Access to Your Amazon S3
        /// Content in the 				Amazon CloudFront Developer Guide.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OriginAccessIdentity")]
        public Union<string, IntrinsicFunction> OriginAccessIdentity { get; set; }

    }
}
