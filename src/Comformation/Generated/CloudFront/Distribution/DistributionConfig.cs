using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// AWS::CloudFront::Distribution DistributionConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-distributionconfig.html
    /// </summary>
    public class DistributionConfig
    {

        /// <summary>
        /// Aliases
        /// 		
        /// A complex type that contains information about CNAMEs (alternate domain names), if any, 			for this
        /// distribution.
        /// 	
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Aliases")]
        public List<Union<string, IntrinsicFunction>> Aliases { get; set; }

        /// <summary>
        /// CNAMEs
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CNAMEs")]
        public List<Union<string, IntrinsicFunction>> CNAMEs { get; set; }

        /// <summary>
        /// CacheBehaviors
        /// 		
        /// A complex type that contains zero or more CacheBehavior elements. 		
        /// 	
        /// Required: No
        /// Type: List of CacheBehavior
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CacheBehaviors")]
        public List<CacheBehavior> CacheBehaviors { get; set; }

        /// <summary>
        /// Comment
        /// 		
        /// An optional comment to describe the distribution. The comment cannot be longer than 128
        /// 			characters.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Comment")]
        public Union<string, IntrinsicFunction> Comment { get; set; }

        /// <summary>
        /// CustomErrorResponses
        /// 		
        /// A complex type that controls the following:
        /// 		
        /// 			 			 		 				 Whether CloudFront replaces HTTP status codes in the 4xx and 5xx range with custom
        /// error 					messages before returning the response to the viewer. 			 				 How long CloudFront caches
        /// HTTP status codes in the 4xx and 5xx range. 			
        /// 		
        /// For more information about custom error pages, see Customizing Error Responses in the 				Amazon
        /// CloudFront Developer Guide.
        /// 	
        /// Required: No
        /// Type: List of CustomErrorResponse
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomErrorResponses")]
        public List<CustomErrorResponse> CustomErrorResponses { get; set; }

        /// <summary>
        /// CustomOrigin
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: LegacyCustomOrigin
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomOrigin")]
        public LegacyCustomOrigin CustomOrigin { get; set; }

        /// <summary>
        /// DefaultCacheBehavior
        /// 		
        /// A complex type that describes the default cache behavior if you don&#39;t specify a 				CacheBehavior
        /// element or if files don&#39;t match any of the values of 				PathPattern in CacheBehavior elements. You
        /// must create exactly one 			default cache behavior.
        /// 	
        /// Required: No
        /// Type: DefaultCacheBehavior
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DefaultCacheBehavior")]
        public DefaultCacheBehavior DefaultCacheBehavior { get; set; }

        /// <summary>
        /// DefaultRootObject
        /// 		
        /// The object that you want CloudFront to request from your origin (for example, 				index. html) when
        /// a viewer requests the root URL for your distribution 				(http://www. example. com) instead of an
        /// object in your distribution 				(http://www. example. com/product-description. html). Specifying a
        /// default root 			object avoids exposing the contents of your distribution.
        /// 		
        /// Specify only the object name, for example, index. html. Don&#39;t add a 				/ before the object name.
        /// 		
        /// If you don&#39;t want to specify a default root object when you create a distribution, 			include an
        /// empty DefaultRootObject element.
        /// 		
        /// To delete the default root object from an existing distribution, update the 			distribution
        /// configuration and include an empty DefaultRootObject 			element.
        /// 		
        /// To replace the default root object, update the distribution configuration and specify 			the new
        /// object.
        /// 		
        /// For more information about the default root object, see Creating a Default Root Object in the
        /// 				Amazon CloudFront Developer Guide.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DefaultRootObject")]
        public Union<string, IntrinsicFunction> DefaultRootObject { get; set; }

        /// <summary>
        /// Enabled
        /// 		
        /// From this field, you can enable or disable the selected distribution.
        /// 	
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

        /// <summary>
        /// HttpVersion
        /// 	 		
        /// (Optional) Specify the maximum HTTP version that you want viewers to use to 			communicate with
        /// CloudFront. The default value for new web distributions is 			http1. 1.
        /// 		
        /// For viewers and CloudFront to use HTTP/2, viewers must support TLS 1. 2 or later, and 			must
        /// support server name identification (SNI).
        /// 		
        /// In general, configuring CloudFront to communicate with viewers using HTTP/2 reduces 			latency. You
        /// can improve performance by optimizing for HTTP/2.
        /// 	
        /// Required: No
        /// Type: String
        /// Allowed values: http1. 1 | http2
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HttpVersion")]
        public Union<string, IntrinsicFunction> HttpVersion { get; set; }

        /// <summary>
        /// IPV6Enabled
        /// 		
        /// If you want CloudFront to respond to IPv6 DNS requests with an IPv6 address for your
        /// 			distribution, specify true. If you specify false, CloudFront responds to 			IPv6 DNS requests
        /// with the DNS response code NOERROR and with no IP addresses. 			This allows viewers to submit a
        /// second request, for an IPv4 address for your distribution.
        /// 		
        /// In general, you should enable IPv6 if you have users on IPv6 networks who want to 			access your
        /// content. However, if you&#39;re using signed URLs or signed cookies to restrict access 			to your
        /// content, and if you&#39;re using a custom policy that includes the IpAddress 			parameter to restrict
        /// the IP addresses that can access your content, don&#39;t enable IPv6. If 			you want to restrict access
        /// to some content by IP address and not restrict access to other 			content (or restrict access but
        /// not by IP address), you can create two distributions. For more 			information, see 			Creating a
        /// Signed URL Using a Custom Policy in the Amazon CloudFront Developer Guide.
        /// 		
        /// If you&#39;re using an Amazon Route 53 AWS Integration alias resource record set to route traffic to
        /// your CloudFront 			distribution, you need to create a second alias resource record set when both of
        /// the following 			are true:
        /// 		
        /// 			 			 		 				 You enable IPv6 for the distribution 			 				 You&#39;re using alternate domain names in
        /// the URLs for your objects 			
        /// 		
        /// For more information, see Routing Traffic 				to an Amazon CloudFront Web Distribution by Using Your
        /// Domain Name in the Amazon Route 53 AWS Integration 				Developer Guide.
        /// 		
        /// If you created a CNAME resource record set, either with Amazon Route 53 AWS Integration or with
        /// another DNS 			service, you don&#39;t need to make any changes. A CNAME record will route traffic to
        /// your 			distribution regardless of the IP address format of the viewer request.
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IPV6Enabled")]
        public Union<bool, IntrinsicFunction> IPV6Enabled { get; set; }

        /// <summary>
        /// Logging
        /// 		
        /// A complex type that controls whether access logs are written for the 			distribution.
        /// 		
        /// For more information about logging, see Access 				Logs in the Amazon CloudFront Developer Guide.
        /// 	
        /// Required: No
        /// Type: Logging
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Logging")]
        public Logging Logging { get; set; }

        /// <summary>
        /// OriginGroups
        /// 		
        /// A complex type that contains information about origin groups for this 			distribution.
        /// 	
        /// Required: No
        /// Type: OriginGroups
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OriginGroups")]
        public OriginGroups OriginGroups { get; set; }

        /// <summary>
        /// Origins
        /// 		
        /// A complex type that contains information about origins for this distribution. 		
        /// 	
        /// Required: No
        /// Type: List of Origin
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Origins")]
        public List<Origin> Origins { get; set; }

        /// <summary>
        /// PriceClass
        /// 		
        /// The price class that corresponds with the maximum price that you want to pay for CloudFront
        /// 			service. If you specify PriceClass_All, CloudFront responds to requests for your 			objects from
        /// all CloudFront edge locations.
        /// 		
        /// If you specify a price class other than PriceClass_All, CloudFront serves your 			objects from the
        /// CloudFront edge location that has the lowest latency among the edge locations in 			your price
        /// class. Viewers who are in or near regions that are excluded from your specified 			price class may
        /// encounter slower performance.
        /// 		
        /// For more information about price classes, see Choosing the Price Class 			for a CloudFront
        /// Distribution in the Amazon CloudFront Developer Guide. For 			information about CloudFront pricing,
        /// including how price classes (such as Price Class 100) 			map to CloudFront regions, see Amazon
        /// CloudFront 			Pricing.
        /// 	
        /// Required: No
        /// Type: String
        /// Allowed values: PriceClass_100 | PriceClass_200 | PriceClass_All
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PriceClass")]
        public Union<string, IntrinsicFunction> PriceClass { get; set; }

        /// <summary>
        /// Restrictions
        /// 		
        /// A complex type that identifies ways in which you want to restrict distribution of your 			content.
        /// 	
        /// Required: No
        /// Type: Restrictions
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Restrictions")]
        public Restrictions Restrictions { get; set; }

        /// <summary>
        /// S3Origin
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: LegacyS3Origin
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Origin")]
        public LegacyS3Origin S3Origin { get; set; }

        /// <summary>
        /// ViewerCertificate
        /// 		
        /// A complex type that determines the distribution’s SSL/TLS configuration for 			communicating with
        /// viewers.
        /// 	
        /// Required: No
        /// Type: ViewerCertificate
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ViewerCertificate")]
        public ViewerCertificate ViewerCertificate { get; set; }

        /// <summary>
        /// WebACLId
        /// 		
        /// A unique identifier that specifies the AWS WAF web ACL, if any, to associate 			with this
        /// distribution. To specify a web ACL created using the latest version of AWS WAF, use the ACL ARN, for
        /// example
        /// 			arn:aws:wafv2:us-east-1:123456789012:global/webacl/ExampleWebACL/473e64fd-f30b-4765-81a0-62ad96dd167a.
        /// 			To specify a web ACL created using AWS WAF Classic, use the ACL ID, for example
        /// 			473e64fd-f30b-4765-81a0-62ad96dd167a.
        /// 		
        /// AWS WAF is a web application firewall that lets you monitor the HTTP and HTTPS 			requests that are
        /// forwarded to CloudFront, and lets you control access to your content. Based on 			conditions that
        /// you specify, such as the IP addresses that requests originate from or the 			values of query
        /// strings, CloudFront responds to requests either with the requested content or with 			an HTTP 403
        /// status code (Forbidden). You can also configure CloudFront to return a custom error page 			when a
        /// request is blocked. For more information about AWS WAF, see the AWS WAF 				Developer Guide.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WebACLId")]
        public Union<string, IntrinsicFunction> WebACLId { get; set; }

    }
}
