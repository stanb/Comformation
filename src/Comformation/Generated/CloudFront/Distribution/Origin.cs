using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// CloudFront Distribution Origin
    /// Origin is a property of the DistributionConfig property that describes an Amazon CloudFront distribution
    /// origin.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origin.html
    /// </summary>
    public class Origin
    {

        /// <summary>
        /// OriginCustomHeaders
        /// Custom headers that CloudFront includes when it forwards a request to your origin.
        /// Required: No
        /// Type: List of OriginCustomHeader type
        /// </summary>
        [JsonProperty("OriginCustomHeaders")]
        public List<OriginCustomHeader> OriginCustomHeaders { get; set; }

        /// <summary>
        /// DomainName
        /// The DNS name of the Amazon Simple Storage Service (S3) bucket or the HTTP server from which you want
        /// CloudFront to get objects for this origin.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("DomainName")]
        public Union<string, IntrinsicFunction> DomainName { get; set; }

        /// <summary>
        /// S3OriginConfig
        /// Origin information to specify an S3 origin.
        /// Required: Conditional. You cannot use S3OriginConfig and CustomOriginConfig in the same Origin, but
        /// you must specify one or the other.
        /// Type: S3Origin type
        /// </summary>
        [JsonProperty("S3OriginConfig")]
        public S3OriginConfig S3OriginConfig { get; set; }

        /// <summary>
        /// OriginPath
        /// The path that CloudFront uses to request content from an S3 bucket or custom origin. The combination
        /// of the DomainName and OriginPath properties must resolve to a valid path. The value must start with
        /// a slash mark (/) and cannot end with a slash mark.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("OriginPath")]
        public Union<string, IntrinsicFunction> OriginPath { get; set; }

        /// <summary>
        /// Id
        /// An identifier for the origin. The value of Id must be unique within the distribution.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// CustomOriginConfig
        /// Origin information to specify a custom origin.
        /// Required: Conditional. You cannot use CustomOriginConfig and S3OriginConfig in the same Origin, but
        /// you must specify one or the other.
        /// Type: CustomOriginConfig type
        /// </summary>
        [JsonProperty("CustomOriginConfig")]
        public CustomOriginConfig CustomOriginConfig { get; set; }

    }
}
