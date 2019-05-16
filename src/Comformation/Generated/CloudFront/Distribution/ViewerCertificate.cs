using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// AWS::CloudFront::Distribution ViewerCertificate
    /// A complex type that specifies the following:
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-viewercertificate.html
    /// </summary>
    public class ViewerCertificate
    {

        /// <summary>
        /// IamCertificateId
        /// 		
        /// If you want viewers to use HTTPS to request your objects and you&#39;re using an alternate domain name,
        /// 			you must choose the type of certificate that you want to use. Specify the following value if you
        /// purchased your certificate from 			a third-party certificate authority:
        /// 				
        /// 					 				 						 &amp;lt;IAMCertificateId&amp;gt;IAM certificate ID&amp;lt;IAMCertificateId&amp;gt; where 							
        /// IAM certificate ID is the ID that IAM returned when you added the certificate 							to the IAM
        /// certificate store. 					
        /// 		
        /// If you specify IAMCertificateId, you must also specify a value for SSLSupportMethod.
        /// 	
        /// Required: Conditional
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IamCertificateId")]
        public Union<string, IntrinsicFunction> IamCertificateId { get; set; }

        /// <summary>
        /// SslSupportMethod
        /// 		
        /// If you specify a value for ACMCertificateArn or for 			IAMCertificateId, 			you must also specify
        /// how you want CloudFront to serve HTTPS requests: using a method that works for browsers and clients
        /// released after 2010 or one that works for all 			clients.
        /// 		
        /// 			 			 		 				 sni-only: CloudFront can respond to HTTPS requests from viewers that support Server
        /// Name Indication (SNI). 					All modern browsers support SNI, but there are a few that don&#39;t. For a
        /// current list of the browsers that support SNI, see the 					Wikipedia entry Server Name Indication.
        /// To learn 					about options to explore if you have users with browsers that don&#39;t include SNI
        /// support, see Choosing 						How CloudFront Serves HTTPS Requests in the Amazon CloudFront Developer
        /// Guide. 			 				 vip: CloudFront uses dedicated IP addresses for your content and can respond to
        /// HTTPS requests from any viewer. 					However, there are additional monthly charges. For details,
        /// including specific pricing information, see Custom SSL options for Amazon CloudFront 					on the AWS
        /// marketing site. 				 			
        /// 		
        /// Don&#39;t specify a value for SSLSupportMethod if you specified
        /// 				&amp;lt;CloudFrontDefaultCertificate&amp;gt;true&amp;lt;CloudFrontDefaultCertificate&amp;gt;.
        /// 		
        /// For more information, see Choosing 			How CloudFront Serves HTTPS Requests in the Amazon CloudFront
        /// Developer Guide.
        /// 	
        /// Required: Conditional
        /// Type: String
        /// Allowed Values: sni-only | vip
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SslSupportMethod")]
        public Union<string, IntrinsicFunction> SslSupportMethod { get; set; }

        /// <summary>
        /// MinimumProtocolVersion
        /// 		
        /// Specify the security policy that you want CloudFront to use for HTTPS connections. A security policy
        /// determines two settings:
        /// 			
        /// 				 				 			 The minimum SSL/TLS protocol that CloudFront uses to communicate with viewers The
        /// cipher that CloudFront uses to encrypt the content that it returns to viewers
        /// 		
        /// Note On the CloudFront console, this setting is called Security policy.
        /// 		 		
        /// We recommend that you specify TLSv1. 1_2016 unless your users are using browsers or devices 			that
        /// do not support TLSv1. 1 or later.
        /// 		
        /// When both of the following are true, you must specify TLSv1 or later for the security policy:
        /// 			
        /// 				 				 			 					 You&#39;re using a custom certificate: you specified a value for ACMCertificateArn
        /// or for IAMCertificateId 				 					 You&#39;re using SNI: you specified sni-only for SSLSupportMethod
        /// 				
        /// 		
        /// If you specify true for CloudFrontDefaultCertificate, CloudFront automatically sets the security
        /// policy to 			TLSv1 regardless of the value that you specify for MinimumProtocolVersion.
        /// 		
        /// For information about the relationship between the security policy that you choose and the protocols
        /// and ciphers that CloudFront 			uses to communicate with viewers, see 			 				Supported SSL/TLS
        /// Protocols and Ciphers for Communication Between Viewers and CloudFront in the Amazon CloudFront
        /// Developer Guide.
        /// 	
        /// Required: No
        /// Type: String
        /// Allowed Values: SSLv3 | TLSv1 | TLSv1. 1_2016 | TLSv1. 2_2018 | TLSv1_2016
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MinimumProtocolVersion")]
        public Union<string, IntrinsicFunction> MinimumProtocolVersion { get; set; }

        /// <summary>
        /// CloudFrontDefaultCertificate
        /// 		
        /// If you&#39;re using the CloudFront domain name for your distribution, such as d111111abcdef8.
        /// cloudfront. net, specify the 			following value:
        /// 		
        /// 			 		 				 					 &amp;lt;CloudFrontDefaultCertificate&amp;gt;true&amp;lt;CloudFrontDefaultCertificate&amp;gt; 				
        /// 			
        /// 		 	
        /// Required: Conditional
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CloudFrontDefaultCertificate")]
        public Union<bool, IntrinsicFunction> CloudFrontDefaultCertificate { get; set; }

        /// <summary>
        /// AcmCertificateArn
        /// 		
        /// If you want viewers to use HTTPS to request your objects and you&#39;re using an alternate domain name,
        /// 			you must choose the type of certificate that you want to use. Specify the following value if ACM
        /// provided your certificate:
        /// 				
        /// 					 				 						 &amp;lt;ACMCertificateArn&amp;gt;ARN for ACM SSL/TLS certificate&amp;lt;ACMCertificateArn&amp;gt;
        /// where 							 ARN for ACM SSL/TLS certificate is the ARN for the ACM SSL/TLS certificate that you
        /// want to use 							for this distribution. 					
        /// 				
        /// If you specify ACMCertificateArn, you must also specify a value for SSLSupportMethod.
        /// 		 	
        /// Required: Conditional
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AcmCertificateArn")]
        public Union<string, IntrinsicFunction> AcmCertificateArn { get; set; }

    }
}
