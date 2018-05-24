using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html
    /// </summary>
    public class CacheBehavior
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-compress
        /// </summary>
        [JsonProperty("Compress")]
        public Union<bool?, IntrinsicFunction> Compress { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-lambdafunctionassociations
        /// </summary>
        [JsonProperty("LambdaFunctionAssociations")]
        public Union<List<LambdaFunctionAssociation>, IntrinsicFunction> LambdaFunctionAssociations { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-targetoriginid
        /// </summary>
        [JsonProperty("TargetOriginId")]
        public Union<string, IntrinsicFunction> TargetOriginId { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-viewerprotocolpolicy
        /// </summary>
        [JsonProperty("ViewerProtocolPolicy")]
        public Union<string, IntrinsicFunction> ViewerProtocolPolicy { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-trustedsigners
        /// </summary>
        [JsonProperty("TrustedSigners")]
        public Union<List<string>, IntrinsicFunction> TrustedSigners { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-defaultttl
        /// </summary>
        [JsonProperty("DefaultTTL")]
        public Union<double?, IntrinsicFunction> DefaultTTL { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-allowedmethods
        /// </summary>
        [JsonProperty("AllowedMethods")]
        public Union<List<string>, IntrinsicFunction> AllowedMethods { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-pathpattern
        /// </summary>
        [JsonProperty("PathPattern")]
        public Union<string, IntrinsicFunction> PathPattern { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-cachedmethods
        /// </summary>
        [JsonProperty("CachedMethods")]
        public Union<List<string>, IntrinsicFunction> CachedMethods { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-smoothstreaming
        /// </summary>
        [JsonProperty("SmoothStreaming")]
        public Union<bool?, IntrinsicFunction> SmoothStreaming { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-forwardedvalues
        /// </summary>
        [JsonProperty("ForwardedValues")]
        public Union<ForwardedValues, IntrinsicFunction> ForwardedValues { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-minttl
        /// </summary>
        [JsonProperty("MinTTL")]
        public Union<double?, IntrinsicFunction> MinTTL { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html#cfn-cloudfront-distribution-cachebehavior-maxttl
        /// </summary>
        [JsonProperty("MaxTTL")]
        public Union<double?, IntrinsicFunction> MaxTTL { get; set; }

    }
}
