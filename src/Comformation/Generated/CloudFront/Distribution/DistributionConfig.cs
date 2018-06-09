using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// CloudFront Distribution DistributionConfig
    /// DistributionConfig is a property of the AWS::CloudFront::Distribution property that describes which Amazon
    /// CloudFront origin servers to get your files from when users request the files through your website or
    /// application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-distributionconfig.html
    /// </summary>
    public class DistributionConfig
    {

        /// <summary>
        /// Logging
        /// Controls whether access logs are written for the distribution. To turn on access logs, specify this
        /// property.
        /// Required: No
        /// Type: Logging type
        /// </summary>
        [JsonProperty("Logging")]
        public Union<Logging, IntrinsicFunction> Logging { get; set; }

        /// <summary>
        /// Comment
        /// Any comments that you want to include about the distribution. Optional.
        /// When you create a distribution, you can include a comment of up to 128 characters. You can update
        /// the comment at any time.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Comment")]
        public Union<string, IntrinsicFunction> Comment { get; set; }

        /// <summary>
        /// DefaultRootObject
        /// The object (such as index. html) that you want CloudFront to request from your origin when the root
        /// URL for your distribution (such as http://example. com/) is requested.
        /// Note Specifying a default root object avoids exposing the contents of your distribution.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("DefaultRootObject")]
        public Union<string, IntrinsicFunction> DefaultRootObject { get; set; }

        /// <summary>
        /// Origins
        /// A list of origins for this CloudFront distribution. For each origin, you can specify whether it is
        /// an Amazon S3 or custom origin.
        /// Required: Yes
        /// Type: List of Origins.
        /// </summary>
        [JsonProperty("Origins")]
        public Union<List<Origin>, IntrinsicFunction> Origins { get; set; }

        /// <summary>
        /// ViewerCertificate
        /// The certificate to use when viewers use HTTPS to request objects.
        /// Required: No
        /// Type: CloudFront Distribution ViewerCertificate
        /// </summary>
        [JsonProperty("ViewerCertificate")]
        public Union<ViewerCertificate, IntrinsicFunction> ViewerCertificate { get; set; }

        /// <summary>
        /// PriceClass
        /// The price class that corresponds with the maximum price that you want to pay for the CloudFront
        /// service. For more information, see Choosing the Price Class in the Amazon CloudFront Developer
        /// Guide.
        /// For more information about the valid values, see the PriceClass content for the DistributionConfig
        /// data type in the Amazon CloudFront API Reference.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("PriceClass")]
        public Union<string, IntrinsicFunction> PriceClass { get; set; }

        /// <summary>
        /// DefaultCacheBehavior
        /// The default cache behavior that is triggered if you do not specify the CacheBehavior property or if
        /// files don&#39;t match any of the values of PathPattern in the CacheBehavior property.
        /// Required: Yes
        /// Type: DefaultCacheBehavior type
        /// </summary>
        [JsonProperty("DefaultCacheBehavior")]
        public Union<DefaultCacheBehavior, IntrinsicFunction> DefaultCacheBehavior { get; set; }

        /// <summary>
        /// CustomErrorResponses
        /// Whether CloudFront replaces HTTP status codes in the 4xx and 5xx range with custom error messages
        /// before returning the response to the viewer.
        /// Required: No
        /// Type List of CloudFront Distribution CustomErrorResponse
        /// </summary>
        [JsonProperty("CustomErrorResponses")]
        public Union<List<CustomErrorResponse>, IntrinsicFunction> CustomErrorResponses { get; set; }

        /// <summary>
        /// Enabled
        /// Controls whether the distribution is enabled to accept end user requests for content.
        /// Required: Yes
        /// Type: Boolean
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

        /// <summary>
        /// Aliases
        /// CNAMEs (alternate domain names), if any, for the distribution.
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("Aliases")]
        public Union<List<string>, IntrinsicFunction> Aliases { get; set; }

        /// <summary>
        /// IPV6Enabled
        /// If you want CloudFront to respond to IPv6 DNS requests with an IPv6 address for your distribution,
        /// specify true. If you specify false, CloudFront responds to IPv6 DNS requests with the DNS response
        /// code NOERROR and with no IP addresses. This allows viewers to submit a second request, for an IPv4
        /// address for your distribution. For more information and usage guidance, see CreateDistribution in
        /// the Amazon CloudFront API Reference.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IPV6Enabled")]
        public Union<bool, IntrinsicFunction> IPV6Enabled { get; set; }

        /// <summary>
        /// WebACLId
        /// The AWS WAF web ACL to associate with this distribution. AWS WAF is a web application firewall that
        /// enables you to monitor the HTTP and HTTPS requests that are forwarded to CloudFront and to control
        /// who can access your content. CloudFront permits or forbids requests based on conditions that you
        /// specify, such as the IP addresses from which requests originate or the values of query strings.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("WebACLId")]
        public Union<string, IntrinsicFunction> WebACLId { get; set; }

        /// <summary>
        /// HttpVersion
        /// The latest HTTP version that viewers can use to communicate with CloudFront. Viewers that don&#39;t
        /// support the latest version automatically use an earlier HTTP version. By default, AWS CloudFormation
        /// specifies http1. 1.
        /// For valid values, see the HttpVersion content for the DistributionConfig data type in the Amazon
        /// CloudFront API Reference.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("HttpVersion")]
        public Union<string, IntrinsicFunction> HttpVersion { get; set; }

        /// <summary>
        /// Restrictions
        /// Specifies restrictions on who or how viewers can access your content.
        /// Required: No
        /// Type: CloudFront Distribution Restrictions
        /// </summary>
        [JsonProperty("Restrictions")]
        public Union<Restrictions, IntrinsicFunction> Restrictions { get; set; }

        /// <summary>
        /// CacheBehaviors
        /// A list of CacheBehavior types for the distribution.
        /// Required: No
        /// Type: List of CloudFront Distribution CacheBehavior
        /// </summary>
        [JsonProperty("CacheBehaviors")]
        public Union<List<CacheBehavior>, IntrinsicFunction> CacheBehaviors { get; set; }

    }
}
