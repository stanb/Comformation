using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.StreamingDistribution
{
    /// <summary>
    /// Amazon CloudFront StreamingDistribution S3Origin
    /// The S3Origin property type specifies information about the Amazon S3 bucket from which you want Amazon
    /// CloudFront to get your media files for distribution. For more information, see S3Origin in the Amazon
    /// CloudFront API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-streamingdistribution-s3origin.html
    /// </summary>
    public class S3Origin
    {

        /// <summary>
        /// DomainName
        /// The DNS name of the Amazon S3 origin.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DomainName")]
        public Union<string, IntrinsicFunction> DomainName { get; set; }

        /// <summary>
        /// OriginAccessIdentity
        /// The CloudFront origin access identity to associate with the RTMP distribution. Use an origin access
        /// identity to configure the distribution so that end users can only access objects in an Amazon S3
        /// bucket through CloudFront. For more information, see the OriginAccessIdentity property for S3Origin
        /// in Amazon CloudFront API Reference.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OriginAccessIdentity")]
        public Union<string, IntrinsicFunction> OriginAccessIdentity { get; set; }

    }
}
