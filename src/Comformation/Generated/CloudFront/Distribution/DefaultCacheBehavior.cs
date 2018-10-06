using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// CloudFront Distribution DefaultCacheBehavior
    /// DefaultCacheBehavior is a property of the DistributionConfig property that describes the default cache
    /// behavior for an Amazon CloudFront distribution.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-defaultcachebehavior.html
    /// </summary>
    public class DefaultCacheBehavior
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
        /// The value of ID for the origin that CloudFront routes requests to when the default cache behavior is
        /// applied to a request.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("TargetOriginId")]
        public Union<string, IntrinsicFunction> TargetOriginId { get; set; }

        /// <summary>
        /// ViewerProtocolPolicy
        /// The protocol that users can use to access the files in the origin that you specified in the
        /// TargetOriginId property when the default cache behavior is applied to a request. For more
        /// information about the valid values, see the ViewerProtocolPolicy content for the
        /// DefaultCacheBehavior data type in the Amazon CloudFront API Reference.
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
        /// property is greater than the default value, CloudFront uses the minimum Time To Live (TTL) value.
        /// Required: No
        /// Type: Number
        /// </summary>
        [JsonProperty("DefaultTTL")]
        public Union<double, IntrinsicFunction> DefaultTTL { get; set; }

        /// <summary>
        /// FieldLevelEncryptionId
        /// The value of ID for the field-level encryption configuration that you want CloudFront to use for
        /// encrypting specific fields of data for the default cache behavior in your distribution. The default
        /// is an empty string.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("FieldLevelEncryptionId")]
        public Union<string, IntrinsicFunction> FieldLevelEncryptionId { get; set; }

        /// <summary>
        /// AllowedMethods
        /// HTTP methods that CloudFront processes and forwards to your Amazon S3 bucket or your custom origin.
        /// In AWS CloudFormation templates, you can specify [&quot;HEAD&quot;, &quot;GET&quot;], [&quot;GET&quot;, &quot;HEAD&quot;, &quot;OPTIONS&quot;], or
        /// [&quot;DELETE&quot;, &quot;GET&quot;, &quot;HEAD&quot;, &quot;OPTIONS&quot;, &quot;PATCH&quot;, &quot;POST&quot;, &quot;PUT&quot;]. If you don&#39;t specify a value, AWS
        /// CloudFormation specifies [&quot;HEAD&quot;, &quot;GET&quot;].
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("AllowedMethods")]
        public List<Union<string, IntrinsicFunction>> AllowedMethods { get; set; }

        /// <summary>
        /// CachedMethods
        /// HTTP methods for which CloudFront caches responses. In AWS CloudFormation templates, you can specify
        /// [&quot;HEAD&quot;, &quot;GET&quot;] or [&quot;GET&quot;, &quot;HEAD&quot;, &quot;OPTIONS&quot;]. If you don&#39;t specify a value, AWS CloudFormation
        /// specifies [&quot;HEAD&quot;, &quot;GET&quot;].
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("CachedMethods")]
        public List<Union<string, IntrinsicFunction>> CachedMethods { get; set; }

        /// <summary>
        /// SmoothStreaming
        /// Indicates whether to use the origin that is associated with this cache behavior to distribute media
        /// files in the Microsoft Smooth Streaming format.
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
        /// applies only when your custom origin adds HTTP headers, such as Cache-Control max-age, Cache-Control
        /// s-maxage, and Expires to objects.
        /// By default, AWS CloudFormation specifies 31536000 seconds (one year). If the value of the MinTTL or
        /// DefaultTTL property is greater than the maximum value, CloudFront uses the default TTL value.
        /// Required: No
        /// Type: Number
        /// </summary>
        [JsonProperty("MaxTTL")]
        public Union<double, IntrinsicFunction> MaxTTL { get; set; }

    }
}
