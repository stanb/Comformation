using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-viewercertificate.html
    /// </summary>
    public class ViewerCertificate
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-viewercertificate.html#cfn-cloudfront-distribution-viewercertificate-iamcertificateid
        /// </summary>
        [JsonProperty("IamCertificateId")]
        public Union<string, IntrinsicFunction> IamCertificateId { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-viewercertificate.html#cfn-cloudfront-distribution-viewercertificate-sslsupportmethod
        /// </summary>
        [JsonProperty("SslSupportMethod")]
        public Union<string, IntrinsicFunction> SslSupportMethod { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-viewercertificate.html#cfn-cloudfront-distribution-viewercertificate-minimumprotocolversion
        /// </summary>
        [JsonProperty("MinimumProtocolVersion")]
        public Union<string, IntrinsicFunction> MinimumProtocolVersion { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-viewercertificate.html#cfn-cloudfront-distribution-viewercertificate-cloudfrontdefaultcertificate
        /// </summary>
        [JsonProperty("CloudFrontDefaultCertificate")]
        public Union<bool?, IntrinsicFunction> CloudFrontDefaultCertificate { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-viewercertificate.html#cfn-cloudfront-distribution-viewercertificate-acmcertificatearn
        /// </summary>
        [JsonProperty("AcmCertificateArn")]
        public Union<string, IntrinsicFunction> AcmCertificateArn { get; set; }

    }
}
