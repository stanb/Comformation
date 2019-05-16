using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// AWS::CloudFront::Distribution CacheBehavior
    /// A complex type that describes how CloudFront processes requests.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-cachebehavior.html
    /// </summary>
    public class CacheBehavior
    {

        /// <summary>
        /// Compress
        /// 		
        /// Whether you want CloudFront to automatically compress certain files for this cache behavior. 			If
        /// so, specify true; if not, specify false. For more information, see Serving Compressed Files in the
        /// 				Amazon CloudFront Developer Guide.
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Compress")]
        public Union<bool, IntrinsicFunction> Compress { get; set; }

        /// <summary>
        /// LambdaFunctionAssociations
        /// 		
        /// A complex type that contains zero or more Lambda function associations for a cache 			behavior.
        /// 	
        /// Required: No
        /// Type: List of LambdaFunctionAssociation
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LambdaFunctionAssociations")]
        public List<LambdaFunctionAssociation> LambdaFunctionAssociations { get; set; }

        /// <summary>
        /// TargetOriginId
        /// 		
        /// The value of ID for the origin that you want CloudFront to route requests to 			when a request
        /// matches the path pattern either for a cache behavior or for the default cache 			behavior in your
        /// distribution.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetOriginId")]
        public Union<string, IntrinsicFunction> TargetOriginId { get; set; }

        /// <summary>
        /// ViewerProtocolPolicy
        /// 		
        /// The protocol that viewers can use to access the files in the origin specified by 				TargetOriginId
        /// when a request matches the path pattern in 				PathPattern. You can specify the following options:
        /// 		
        /// 			 			 			 		 				 allow-all: Viewers can use HTTP or HTTPS. 			 				 redirect-to-https: If a
        /// viewer submits an HTTP request, CloudFront returns 					an HTTP status code of 301 (Moved
        /// Permanently) to the viewer along with the HTTPS URL. The 					viewer then resubmits the request
        /// using the new URL. 			 				 https-only: If a viewer sends an HTTP request, CloudFront returns an
        /// HTTP 					status code of 403 (Forbidden). 			
        /// 		
        /// For more information about requiring the HTTPS protocol, see Using an HTTPS Connection to Access
        /// Your 				Objects in the Amazon CloudFront Developer Guide.
        /// 		
        /// Note The only way to guarantee that viewers retrieve an object that was fetched from the 				origin
        /// using HTTPS is never to use any other protocol to fetch the object. If you have 				recently changed
        /// from HTTP to HTTPS, we recommend that you clear your objects&#39; cache because 				cached objects are
        /// protocol agnostic. That means that an edge location will return an object 				from the cache
        /// regardless of whether the current request protocol matches the protocol used 				previously. For
        /// more information, see 				Managing How Long Content Stays 				in an Edge Cache (Expiration) in the
        /// 				Amazon CloudFront Developer Guide.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Allowed Values: allow-all | https-only | redirect-to-https
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ViewerProtocolPolicy")]
        public Union<string, IntrinsicFunction> ViewerProtocolPolicy { get; set; }

        /// <summary>
        /// TrustedSigners
        /// 		
        /// A complex type that specifies the AWS accounts, if any, that you want to allow to 			create signed
        /// URLs for private content.
        /// 		
        /// If you want to require signed URLs in requests for objects in the target origin that 			match the
        /// PathPattern for this cache behavior, specify true for 				Enabled, and specify the applicable values
        /// for Quantity and 				Items. For more information, see Serving Private Content through CloudFront in
        /// the Amazon CloudFront Developer Guide. 		
        /// 		
        /// If you don&#39;t want to require signed URLs in requests for objects that match 				PathPattern, specify
        /// false for Enabled and 				0 for Quantity. Omit Items.
        /// 		
        /// To add, change, or remove one or more trusted signers, change Enabled to 				true (if it&#39;s currently
        /// false), change Quantity as 			applicable, and specify all of the trusted signers that you want to
        /// include in the updated 			distribution.
        /// 	
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TrustedSigners")]
        public List<Union<string, IntrinsicFunction>> TrustedSigners { get; set; }

        /// <summary>
        /// DefaultTTL
        /// 		
        /// The default amount of time that you want objects to stay in CloudFront caches before CloudFront
        /// 			forwards another request to your origin to determine whether the object has been updated. The
        /// 			value that you specify applies only when your origin does not add HTTP headers such as
        /// 				Cache-Control max-age, Cache-Control s-maxage, and 				Expires to objects. For more information,
        /// see Managing How Long Content Stays 				in an Edge Cache (Expiration) in the Amazon CloudFront
        /// Developer Guide.
        /// 	
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DefaultTTL")]
        public Union<double, IntrinsicFunction> DefaultTTL { get; set; }

        /// <summary>
        /// FieldLevelEncryptionId
        /// 		
        /// The value of ID for the field-level encryption configuration that you 			want CloudFront to use for
        /// encrypting specific fields of data for a cache behavior or for the 			default cache behavior in your
        /// distribution.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FieldLevelEncryptionId")]
        public Union<string, IntrinsicFunction> FieldLevelEncryptionId { get; set; }

        /// <summary>
        /// AllowedMethods
        /// 		
        /// A complex type that controls which HTTP methods CloudFront processes and forwards to your 			Amazon
        /// S3 bucket or your custom origin. There are three choices:
        /// 		
        /// 			 			 			 		 				 CloudFront forwards only GET and HEAD requests. 			 				 CloudFront forwards
        /// only GET, HEAD, and OPTIONS 					requests. 			 				 CloudFront forwards GET, HEAD, OPTIONS, PUT,
        /// PATCH, POST, and 						DELETE requests. 			
        /// 		
        /// If you pick the third choice, you may need to restrict access to your Amazon S3 bucket or 			to your
        /// custom origin so users can&#39;t perform operations that you don&#39;t want them to. For 			example, you
        /// might not want users to have permissions to delete objects from your 			origin.
        /// 	
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AllowedMethods")]
        public List<Union<string, IntrinsicFunction>> AllowedMethods { get; set; }

        /// <summary>
        /// PathPattern
        /// 		
        /// The pattern (for example, images/*. jpg) that specifies which requests to 			apply the behavior to.
        /// When CloudFront receives a viewer request, the requested path is compared 			with path patterns in
        /// the order in which cache behaviors are listed in the 			distribution.
        /// 		
        /// Note You can optionally include a slash (/) at the beginning of the path 				pattern. For example,
        /// /images/*. jpg. CloudFront behavior is the same with or without 				the leading /.
        /// 		
        /// The path pattern for the default cache behavior is * and cannot be 			changed. If the request for an
        /// object does not match the path pattern for any cache behaviors, 			CloudFront applies the behavior
        /// in the default cache behavior.
        /// 		
        /// For more information, see Path 				Pattern in the Amazon CloudFront Developer Guide.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PathPattern")]
        public Union<string, IntrinsicFunction> PathPattern { get; set; }

        /// <summary>
        /// CachedMethods
        /// 		
        /// A complex type that controls whether CloudFront caches the response to requests using the
        /// 			specified HTTP methods. There are two choices:
        /// 		
        /// 			 			 		 				 CloudFront caches responses to GET and HEAD requests. 			 				 CloudFront caches
        /// responses to GET, HEAD, and 						OPTIONS requests. 			
        /// 		
        /// If you pick the second choice for your Amazon S3 Origin, you may need to forward
        /// 			Access-Control-Request-Method, Access-Control-Request-Headers, and Origin headers for the
        /// 			responses to be cached correctly.
        /// 	
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CachedMethods")]
        public List<Union<string, IntrinsicFunction>> CachedMethods { get; set; }

        /// <summary>
        /// SmoothStreaming
        /// 		
        /// Indicates whether you want to distribute media files in the Microsoft Smooth Streaming 			format
        /// using the origin that is associated with this cache behavior. If so, specify 				true; if not,
        /// specify false. If you specify true for 				SmoothStreaming, you can still distribute other content
        /// using this cache 			behavior if the content matches the value of PathPattern.
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SmoothStreaming")]
        public Union<bool, IntrinsicFunction> SmoothStreaming { get; set; }

        /// <summary>
        /// ForwardedValues
        /// 		
        /// A complex type that specifies how CloudFront handles query strings and cookies.
        /// 	
        /// Required: Yes
        /// Type: ForwardedValues
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ForwardedValues")]
        public ForwardedValues ForwardedValues { get; set; }

        /// <summary>
        /// MinTTL
        /// 		
        /// The minimum amount of time that you want objects to stay in CloudFront caches before CloudFront
        /// 			forwards another request to your origin to determine whether the object has been updated. For
        /// 			more information, see 				Managing How Long Content Stays in an Edge Cache (Expiration) in the
        /// 				Amazon CloudFront Developer Guide.
        /// 		
        /// You must specify 0 for MinTTL if you configure CloudFront to 			forward all headers to your origin
        /// (under Headers, if you specify 1 			for Quantity and * for Name).
        /// 	
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MinTTL")]
        public Union<double, IntrinsicFunction> MinTTL { get; set; }

        /// <summary>
        /// MaxTTL
        /// 		
        /// The maximum amount of time that you want objects to stay in CloudFront caches before CloudFront
        /// 			forwards another request to your origin to determine whether the object has been updated. The
        /// 			value that you specify applies only when your origin adds HTTP headers such as 				Cache-Control
        /// max-age, Cache-Control s-maxage, and 				Expires to objects. For more information, see Managing How
        /// Long Content Stays 				in an Edge Cache (Expiration) in the Amazon CloudFront Developer Guide.
        /// 	
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxTTL")]
        public Union<double, IntrinsicFunction> MaxTTL { get; set; }

    }
}
