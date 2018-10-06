using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.StreamingDistribution
{
    /// <summary>
    /// Amazon CloudFront StreamingDistribution StreamingDistributionConfig
    /// The StreamingDistributionConfig property type specifies the configuration of an RMTP streaming distribution
    /// for Amazon CloudFront.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-streamingdistribution-streamingdistributionconfig.html
    /// </summary>
    public class StreamingDistributionConfig
    {

        /// <summary>
        /// Logging
        /// Whether access logs are written for the streaming distribution.
        /// Required: No
        /// Type: CloudFront StreamingDistribution Logging
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Logging")]
        public Logging Logging { get; set; }

        /// <summary>
        /// Comment
        /// Any comments you want to include about the streaming distribution.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Comment")]
        public Union<string, IntrinsicFunction> Comment { get; set; }

        /// <summary>
        /// PriceClass
        /// The price class for this streaming distribution.
        /// Valid values include PriceClass_100, PriceClass_200, and PriceClass_All.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PriceClass")]
        public Union<string, IntrinsicFunction> PriceClass { get; set; }

        /// <summary>
        /// S3Origin
        /// Information about the Amazon S3 bucket from which you want CloudFront to get your media files for
        /// distribution.
        /// Required: Yes
        /// Type: CloudFront StreamingDistribution S3Origin
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Origin")]
        public S3Origin S3Origin { get; set; }

        /// <summary>
        /// Enabled
        /// Whether the streaming distribution is enabled to accept user requests for content.
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

        /// <summary>
        /// Aliases
        /// Lists the CNAMEs (alternate domain names), if any, for this streaming distribution.
        /// Required: No
        /// Type: StringList
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Aliases")]
        public List<Union<string, IntrinsicFunction>> Aliases { get; set; }

        /// <summary>
        /// TrustedSigners
        /// Specifies any AWS accounts that you want to permit to create signed URLs for private content. If you
        /// want the distribution to use signed URLs, include this element; if you want the distribution to use
        /// public URLs, remove this property. For more information, see Serving Private Content through
        /// CloudFront in the Amazon CloudFront Developer Guide.
        /// Required: Yes
        /// Type: CloudFront StreamingDistribution TrustedSigners
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TrustedSigners")]
        public TrustedSigners TrustedSigners { get; set; }

    }
}
