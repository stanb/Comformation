using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// CloudFront Distribution ViewerCertificate
    /// ViewerCertificate is a property of the CloudFront Distribution DistributionConfig property that specifies
    /// which certificate to use when viewers use HTTPS to request objects.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-viewercertificate.html
    /// </summary>
    public class ViewerCertificate
    {

        /// <summary>
        /// IamCertificateId
        /// If you're using an alternate domain name, the ID of a server certificate that was purchased from a
        /// certificate authority. This ID is the ServerCertificateId value, which AWS Identity and Access
        /// Management (IAM) returns when the certificate is added to the IAM certificate store, such as
        /// ASCACKCEVSQ6CEXAMPLE1.
        /// Required: Conditional. You must specify one of the following properties: AcmCertificateArn,
        /// CloudFrontDefaultCertificate, or IamCertificateId.
        /// Type: String
        /// </summary>
        [JsonProperty("IamCertificateId")]
        public Union<string, IntrinsicFunction> IamCertificateId { get; set; }

        /// <summary>
        /// SslSupportMethod
        /// Specifies how CloudFront serves HTTPS requests. For valid values, see the SslSupportMethod content
        /// for the ViewerCertificate data type in the Amazon CloudFront API Reference.
        /// Required: Conditional. Required if you specified the IamCertificateId or AcmCertificateArn property.
        /// Type: String
        /// </summary>
        [JsonProperty("SslSupportMethod")]
        public Union<string, IntrinsicFunction> SslSupportMethod { get; set; }

        /// <summary>
        /// MinimumProtocolVersion
        /// The minimum version of the SSL protocol that you want CloudFront to use for HTTPS connections.
        /// CloudFront serves your objects only to browsers or devices that support at least the SSL version
        /// that you specify. For valid values, see the MinimumProtocolVersion content for the ViewerCertificate
        /// data type in the Amazon CloudFront API Reference.
        /// AWS CloudFormation specifies SSLv3 by default. However, if you specify the IamCertificateId or
        /// AcmCertificateArn property and specify SNI only for the SslSupportMethod property, AWS
        /// CloudFormation specifies TLSv1 for the minimum protocol version.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("MinimumProtocolVersion")]
        public Union<string, IntrinsicFunction> MinimumProtocolVersion { get; set; }

        /// <summary>
        /// CloudFrontDefaultCertificate
        /// Indicates whether to use the default certificate for your CloudFront domain name when viewers use
        /// HTTPS to request your content.
        /// Required: Conditional. You must specify one of the following properties: AcmCertificateArn,
        /// CloudFrontDefaultCertificate, or IamCertificateId.
        /// Type: Boolean
        /// </summary>
        [JsonProperty("CloudFrontDefaultCertificate")]
        public Union<bool, IntrinsicFunction> CloudFrontDefaultCertificate { get; set; }

        /// <summary>
        /// AcmCertificateArn
        /// If you're using an alternate domain name, the Amazon Resource Name (ARN) of an AWS Certificate
        /// Manager (ACM) certificate. Use the ACM service to provision and manage your certificates. For more
        /// information, see the AWS Certificate Manager User Guide.
        /// Note Currently, you can specify only certificates that are in the US East (N. Virginia) region.
        /// Required: Conditional. You must specify one of the following properties: AcmCertificateArn,
        /// CloudFrontDefaultCertificate, or IamCertificateId.
        /// Type: String
        /// </summary>
        [JsonProperty("AcmCertificateArn")]
        public Union<string, IntrinsicFunction> AcmCertificateArn { get; set; }

    }
}
