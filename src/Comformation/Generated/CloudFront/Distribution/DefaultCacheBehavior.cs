using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-defaultcachebehavior.html
    /// </summary>
    public class DefaultCacheBehavior
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-defaultcachebehavior.html#cfn-cloudfront-distribution-defaultcachebehavior-compress
        /// </summary>
        [JsonProperty("Compress")]
        public Union<bool?, IntrinsicFunction> Compress { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-defaultcachebehavior.html#cfn-cloudfront-distribution-defaultcachebehavior-allowedmethods
        /// </summary>
        [JsonProperty("AllowedMethods")]
        public Union<List<string>, IntrinsicFunction> AllowedMethods { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-defaultcachebehavior.html#cfn-cloudfront-distribution-defaultcachebehavior-cachedmethods
        /// </summary>
        [JsonProperty("CachedMethods")]
        public Union<List<string>, IntrinsicFunction> CachedMethods { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-defaultcachebehavior.html#cfn-cloudfront-distribution-defaultcachebehavior-lambdafunctionassociations
        /// </summary>
        [JsonProperty("LambdaFunctionAssociations")]
        public Union<List<LambdaFunctionAssociation>, IntrinsicFunction> LambdaFunctionAssociations { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-defaultcachebehavior.html#cfn-cloudfront-distribution-defaultcachebehavior-smoothstreaming
        /// </summary>
        [JsonProperty("SmoothStreaming")]
        public Union<bool?, IntrinsicFunction> SmoothStreaming { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-defaultcachebehavior.html#cfn-cloudfront-distribution-defaultcachebehavior-targetoriginid
        /// </summary>
        [JsonProperty("TargetOriginId")]
        public Union<string, IntrinsicFunction> TargetOriginId { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-defaultcachebehavior.html#cfn-cloudfront-distribution-defaultcachebehavior-viewerprotocolpolicy
        /// </summary>
        [JsonProperty("ViewerProtocolPolicy")]
        public Union<string, IntrinsicFunction> ViewerProtocolPolicy { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-defaultcachebehavior.html#cfn-cloudfront-distribution-defaultcachebehavior-forwardedvalues
        /// </summary>
        [JsonProperty("ForwardedValues")]
        public Union<ForwardedValues, IntrinsicFunction> ForwardedValues { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-defaultcachebehavior.html#cfn-cloudfront-distribution-defaultcachebehavior-minttl
        /// </summary>
        [JsonProperty("MinTTL")]
        public Union<double?, IntrinsicFunction> MinTTL { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-defaultcachebehavior.html#cfn-cloudfront-distribution-defaultcachebehavior-maxttl
        /// </summary>
        [JsonProperty("MaxTTL")]
        public Union<double?, IntrinsicFunction> MaxTTL { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-defaultcachebehavior.html#cfn-cloudfront-distribution-defaultcachebehavior-trustedsigners
        /// </summary>
        [JsonProperty("TrustedSigners")]
        public Union<List<string>, IntrinsicFunction> TrustedSigners { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-defaultcachebehavior.html#cfn-cloudfront-distribution-defaultcachebehavior-defaultttl
        /// </summary>
        [JsonProperty("DefaultTTL")]
        public Union<double?, IntrinsicFunction> DefaultTTL { get; set; }

    }
}
