using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// CloudFront Distribution CacheBehavior
    /// CacheBehavior is a property of the DistributionConfig property that describes the Amazon CloudFront
    /// (CloudFront) cache behavior when the requested URL matches a pattern.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html
    /// </summary>
    public class CacheBehavior
    {

        /// <summary>
        /// Compress
        /// Indicates whether CloudFront automatically compresses certain files for this cache behavior. For
        /// more information, see Serving Compressed Files in the Amazon CloudFront Developer Guide.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("Compress")]
        public Union<bool, IntrinsicFunction> Compress { get; set; }

        /// <summary>
        /// LambdaFunctionAssociations
        /// Lambda function associations for the Amazon CloudFront distribution.
        /// Required: No
        /// Type: List of CloudFront Distribution LambdaFunctionAssociation
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LambdaFunctionAssociations")]
        public List<LambdaFunctionAssociation> LambdaFunctionAssociations { get; set; }

        /// <summary>
        /// TargetOriginId
        /// The ID value of the origin to which you want CloudFront to route requests when a request matches the
        /// value of the PathPattern property.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("TargetOriginId")]
        public Union<string, IntrinsicFunction> TargetOriginId { get; set; }

        /// <summary>
        /// ViewerProtocolPolicy
        /// The protocol that users can use to access the files in the origin that you specified in the
        /// TargetOriginId property when a request matches the value of the PathPattern property. For more
        /// information about the valid values, see the ViewerProtocolPolicy content for the CacheBehavior data
        /// type in the Amazon CloudFront API Reference.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("ViewerProtocolPolicy")]
        public Union<string, IntrinsicFunction> ViewerProtocolPolicy { get; set; }

        /// <summary>
        /// TrustedSigners
        /// A list of AWS accounts that can create signed URLs in order to access private content.
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("TrustedSigners")]
        public List<Union<string, IntrinsicFunction>> TrustedSigners { get; set; }

        /// <summary>
        /// DefaultTTL
        /// The default time in seconds that objects stay in CloudFront caches before CloudFront forwards
        /// another request to your custom origin to determine whether the object has been updated. This value
        /// applies only when your custom origin does not add HTTP headers, such as Cache-Control max-age,
        /// Cache-Control s-maxage, and Expires to objects.
        /// By default, AWS CloudFormation specifies 86400 seconds (one day). If the value of the MinTTL
        /// property is greater than the default value, CloudFront uses the minimum Time to Live (TTL) value.
        /// Required: No
        /// Type: Number
        /// </summary>
        [JsonProperty("DefaultTTL")]
        public Union<double, IntrinsicFunction> DefaultTTL { get; set; }

        /// <summary>
        /// FieldLevelEncryptionId
        /// The value of ID for the field-level encryption configuration that you want CloudFront to use for
        /// encrypting specific fields of data for a cache behavior in your distribution. The default is an
        /// empty string.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("FieldLevelEncryptionId")]
        public Union<string, IntrinsicFunction> FieldLevelEncryptionId { get; set; }

        /// <summary>
        /// AllowedMethods
        /// HTTP methods that CloudFront processes and forwards to your Amazon S3 bucket or your custom origin.
        /// You can specify [&quot;HEAD&quot;, &quot;GET&quot;], [&quot;GET&quot;, &quot;HEAD&quot;, &quot;OPTIONS&quot;], or [&quot;DELETE&quot;, &quot;GET&quot;, &quot;HEAD&quot;, &quot;OPTIONS&quot;,
        /// &quot;PATCH&quot;, &quot;POST&quot;, &quot;PUT&quot;]. If you don&#39;t specify a value, AWS CloudFormation specifies [&quot;HEAD&quot;, &quot;GET&quot;].
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("AllowedMethods")]
        public List<Union<string, IntrinsicFunction>> AllowedMethods { get; set; }

        /// <summary>
        /// PathPattern
        /// The pattern to which this cache behavior applies. For example, you can specify images/*. jpg.
        /// When CloudFront receives an end-user request, CloudFront compares the requested path with path
        /// patterns in the order in which cache behaviors are listed in the template.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("PathPattern")]
        public Union<string, IntrinsicFunction> PathPattern { get; set; }

        /// <summary>
        /// CachedMethods
        /// HTTP methods for which CloudFront caches responses. You can specify [&quot;HEAD&quot;, &quot;GET&quot;] or [&quot;GET&quot;,
        /// &quot;HEAD&quot;, &quot;OPTIONS&quot;]. If you don&#39;t specify a value, AWS CloudFormation specifies [&quot;HEAD&quot;, &quot;GET&quot;].
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("CachedMethods")]
        public List<Union<string, IntrinsicFunction>> CachedMethods { get; set; }

        /// <summary>
        /// SmoothStreaming
        /// Indicates whether to use the origin that is associated with this cache behavior to distribute media
        /// files in the Microsoft Smooth Streaming format. If you specify true, you can still use this cache
        /// behavior to distribute other content if the content matches the PathPattern value.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("SmoothStreaming")]
        public Union<bool, IntrinsicFunction> SmoothStreaming { get; set; }

        /// <summary>
        /// ForwardedValues
        /// Specifies how CloudFront handles query strings or cookies.
        /// Required: Yes
        /// Type: ForwardedValues type
        /// </summary>
        [JsonProperty("ForwardedValues")]
        public ForwardedValues ForwardedValues { get; set; }

        /// <summary>
        /// MinTTL
        /// The minimum amount of time that you want objects to stay in the cache before CloudFront queries your
        /// origin to see whether the object has been updated.
        /// Required: No
        /// Type: Number
        /// </summary>
        [JsonProperty("MinTTL")]
        public Union<double, IntrinsicFunction> MinTTL { get; set; }

        /// <summary>
        /// MaxTTL
        /// The maximum time in seconds that objects stay in CloudFront caches before CloudFront forwards
        /// another request to your custom origin to determine whether the object has been updated. This value
        /// applies only when your custom origin does not add HTTP headers, such as Cache-Control max-age,
        /// Cache-Control s-maxage, and Expires to objects.
        /// By default, AWS CloudFormation specifies 31536000 seconds (one year). If the value of the MinTTL or
        /// DefaultTTL property is greater than the maximum value, CloudFront uses the default TTL value.
        /// Required: No
        /// Type: Number
        /// </summary>
        [JsonProperty("MaxTTL")]
        public Union<double, IntrinsicFunction> MaxTTL { get; set; }

    }
}
