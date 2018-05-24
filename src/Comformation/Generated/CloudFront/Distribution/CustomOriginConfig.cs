using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-customoriginconfig.html
    /// </summary>
    public class CustomOriginConfig
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-customoriginconfig.html#cfn-cloudfront-distribution-customoriginconfig-originreadtimeout
        /// </summary>
        [JsonProperty("OriginReadTimeout")]
        public Union<int?, IntrinsicFunction> OriginReadTimeout { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-customoriginconfig.html#cfn-cloudfront-distribution-customoriginconfig-httpsport
        /// </summary>
        [JsonProperty("HTTPSPort")]
        public Union<int?, IntrinsicFunction> HTTPSPort { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-customoriginconfig.html#cfn-cloudfront-distribution-customoriginconfig-originkeepalivetimeout
        /// </summary>
        [JsonProperty("OriginKeepaliveTimeout")]
        public Union<int?, IntrinsicFunction> OriginKeepaliveTimeout { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-customoriginconfig.html#cfn-cloudfront-distribution-customoriginconfig-originsslprotocols
        /// </summary>
        [JsonProperty("OriginSSLProtocols")]
        public Union<List<string>, IntrinsicFunction> OriginSSLProtocols { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-customoriginconfig.html#cfn-cloudfront-distribution-customoriginconfig-httpport
        /// </summary>
        [JsonProperty("HTTPPort")]
        public Union<int?, IntrinsicFunction> HTTPPort { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-customoriginconfig.html#cfn-cloudfront-distribution-customoriginconfig-originprotocolpolicy
        /// </summary>
        [JsonProperty("OriginProtocolPolicy")]
        public Union<string, IntrinsicFunction> OriginProtocolPolicy { get; set; }

    }
}
