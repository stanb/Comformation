using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// CloudFront Distribution S3OriginConfig
    /// S3OriginConfig is a subproperty of the Origin property that describes the Amazon Simple Storage Service (S3)
    /// origin to associate with an Amazon CloudFront origin.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-s3originconfig.html
    /// </summary>
    public class S3OriginConfig
    {

        /// <summary>
        /// OriginAccessIdentity
        /// The CloudFront origin access identity to associate with the origin. You must specify the full origin
        /// ID—for example:
        /// origin-access-identity/cloudfront/E15MNIMTCFKK4C
        /// This is used to configure the origin so that end users can access objects in an Amazon S3 bucket
        /// through CloudFront only.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("OriginAccessIdentity")]
        public Union<string, IntrinsicFunction> OriginAccessIdentity { get; set; }

    }
}
