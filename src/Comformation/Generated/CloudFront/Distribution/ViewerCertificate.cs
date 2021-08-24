using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// AWS::CloudFront::Distribution ViewerCertificate
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-viewercertificate.html
    /// </summary>
    public class ViewerCertificate
    {

        /// <summary>
        /// AcmCertificateArn
        /// 		
        /// Note In CloudFormation, this field name is AcmCertificateArn. Note the different 				capitalization.
        /// 		
        /// If the distribution uses Aliases (alternate domain names or CNAMEs) and 			the SSL/TLS certificate
        /// is stored in AWS Certificate Manager (ACM), provide the Amazon Resource 			Name (ARN) of the ACM
        /// certificate. CloudFront only supports ACM certificates in the US 			East (N. Virginia) Region
        /// (us-east-1).
        /// 		
        /// If you specify an ACM certificate ARN, you must also specify values for 			MinimumProtocolVersion
        /// and SSLSupportMethod. 			(In CloudFormation, the field name is SslSupportMethod. Note the different
        /// 			capitalization. )
        /// 	
        /// Required: Conditional
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AcmCertificateArn")]
        public Union<string, IntrinsicFunction> AcmCertificateArn { get; set; }

        /// <summary>
        /// CloudFrontDefaultCertificate
        /// 		
        /// If the distribution uses the CloudFront domain name such as 			d111111abcdef8. cloudfront. net, set
        /// this field to true.
        /// 		
        /// If the distribution uses Aliases (alternate domain names or CNAMEs), set 			this field to false and
        /// specify values for the following fields:
        /// 		
        /// 			 			 			 		 				 ACMCertificateArn or IAMCertificateId (specify a value for one, 					not both)
        /// 				 In CloudFormation, these field names are 					AcmCertificateArn and IamCertificateId. Note the
        /// 					different capitalization. 			 				 MinimumProtocolVersion 			 				 SSLSupportMethod (In
        /// CloudFormation, this field name is 					SslSupportMethod. Note the different 					capitalization. )
        /// 			
        /// 	
        /// Required: Conditional
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudFrontDefaultCertificate")]
        public Union<bool, IntrinsicFunction> CloudFrontDefaultCertificate { get; set; }

        /// <summary>
        /// IamCertificateId
        /// 		
        /// Note In CloudFormation, this field name is IamCertificateId. Note the different 				capitalization.
        /// 		
        /// If the distribution uses Aliases (alternate domain names or CNAMEs) and 			the SSL/TLS certificate
        /// is stored in AWS Identity and Access Management (IAM), provide the ID of the IAM 			certificate.
        /// 		
        /// If you specify an IAM certificate ID, you must also specify values for 			MinimumProtocolVersion and
        /// SSLSupportMethod. (In CloudFormation, the field name is SslSupportMethod. Note the 			different
        /// capitalization. )
        /// 	
        /// Required: Conditional
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IamCertificateId")]
        public Union<string, IntrinsicFunction> IamCertificateId { get; set; }

        /// <summary>
        /// MinimumProtocolVersion
        /// 		
        /// If the distribution uses Aliases (alternate domain names or CNAMEs), 			specify the security policy
        /// that you want CloudFront to use for HTTPS connections with 			viewers. The security policy
        /// determines two settings:
        /// 		
        /// 			 			 		 				 The minimum SSL/TLS protocol that CloudFront can use to communicate with
        /// 					viewers. 			 				 The ciphers that CloudFront can use to encrypt the content that it returns to
        /// 					viewers. 			
        /// 		
        /// For more information, see Security Policy and Supported Protocols and Ciphers Between Viewers and
        /// 			CloudFront in the Amazon CloudFront Developer Guide.
        /// 		
        /// Note On the CloudFront console, this setting is called Security 				Policy.
        /// 		
        /// When you’re using SNI only (you set SSLSupportMethod to sni-only), 			you must specify TLSv1 or
        /// higher. (In CloudFormation, the 			field name is SslSupportMethod. Note the different
        /// 			capitalization. )
        /// 		
        /// If the distribution uses the CloudFront domain name such as 			d111111abcdef8. cloudfront. net (you
        /// set 			CloudFrontDefaultCertificate to true), CloudFront automatically sets 			the security policy
        /// to TLSv1 regardless of the value that you set 			here.
        /// 	
        /// Required: Conditional
        /// Type: String
        /// Allowed values: SSLv3 | TLSv1 | TLSv1. 1_2016 | TLSv1. 2_2018 | TLSv1. 2_2019 | TLSv1. 2_2021 |
        /// TLSv1_2016
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MinimumProtocolVersion")]
        public Union<string, IntrinsicFunction> MinimumProtocolVersion { get; set; }

        /// <summary>
        /// SslSupportMethod
        /// 		
        /// Note In CloudFormation, this field name is SslSupportMethod. Note the different 				capitalization.
        /// 		
        /// If the distribution uses Aliases (alternate domain names or CNAMEs), specify 			which viewers the
        /// distribution accepts HTTPS connections from.
        /// 		
        /// 			 			 			 		 				 sni-only – The distribution accepts HTTPS connections from only viewers that
        /// 					support server 					name indication (SNI). This is recommended. Most browsers and clients
        /// support SNI. 			 				 vip – The distribution accepts HTTPS connections from all viewers including
        /// 					those that don’t support SNI. This is not recommended, and results in additional 					monthly
        /// charges from CloudFront. 			 				 static-ip - Do not specify this value unless your distribution
        /// 					has been enabled for this feature by the CloudFront team. If you have a use case 					that
        /// requires static IP addresses for a distribution, contact CloudFront through 					the AWS Support
        /// Center. 			
        /// 		
        /// If the distribution uses the CloudFront domain name such as 			d111111abcdef8. cloudfront. net,
        /// don’t set a value for this field.
        /// 	
        /// Required: Conditional
        /// Type: String
        /// Allowed values: sni-only | static-ip | vip
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SslSupportMethod")]
        public Union<string, IntrinsicFunction> SslSupportMethod { get; set; }

    }
}
