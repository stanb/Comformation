using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// AWS::CloudFront::Distribution Origin
    /// A complex type that describes the Amazon S3 bucket, HTTP server (for example, a web 			server), Amazon
    /// MediaStore, or other server from which CloudFront gets your files. This can 			also be an origin group, if
    /// you&#39;ve created an origin group. You must specify at 			least one origin or origin group.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-origin.html
    /// </summary>
    public class Origin
    {

        /// <summary>
        /// OriginCustomHeaders
        /// 		
        /// A complex type that contains names and values for the custom headers that you 			want.
        /// 	
        /// Required: No
        /// Type: List of OriginCustomHeader
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OriginCustomHeaders")]
        public List<OriginCustomHeader> OriginCustomHeaders { get; set; }

        /// <summary>
        /// DomainName
        /// 		
        /// Amazon S3 origins: The DNS name of the Amazon S3 bucket from 			which you want CloudFront to get
        /// objects for this origin, for example, 			myawsbucket. s3. amazonaws. com. If you set up your bucket
        /// to be configured 			as a website endpoint, enter the Amazon S3 static website hosting endpoint for
        /// the bucket.
        /// 		
        /// For more information about specifying this value for different types of origins, 			see Origin
        /// Domain 			Name in the Amazon CloudFront Developer Guide.
        /// 		
        /// Constraints for Amazon S3 origins:
        /// 		
        /// 			 			 			 			 		 				 If you configured Amazon S3 Transfer Acceleration for your bucket, don&#39;t
        /// specify the 						s3-accelerate endpoint for DomainName. 			 				 The bucket name must be between 3
        /// and 63 characters long (inclusive). 			 				 The bucket name must contain only lowercase characters,
        /// numbers, periods, 					underscores, and dashes. 			 				 The bucket name must not contain adjacent
        /// periods. 			
        /// 		
        /// Custom Origins: The DNS domain name for the HTTP 			server from which you want CloudFront to get
        /// objects for this origin, for example, 				www. example. com.
        /// 		
        /// Constraints for custom origins:
        /// 		
        /// 			 			 		 				 DomainName must be a valid DNS name that contains only a-z, A-Z, 0-9, 					dot (. ),
        /// hyphen (-), or underscore (_) characters. 			 				 The name cannot exceed 128 characters. 			
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DomainName")]
        public Union<string, IntrinsicFunction> DomainName { get; set; }

        /// <summary>
        /// S3OriginConfig
        /// 		
        /// A complex type that contains information about the Amazon S3 origin. If the origin is a 			custom
        /// origin, use the CustomOriginConfig element instead.
        /// 	
        /// Required: Conditional
        /// Type: S3OriginConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3OriginConfig")]
        public S3OriginConfig S3OriginConfig { get; set; }

        /// <summary>
        /// OriginPath
        /// 		
        /// An optional element that causes CloudFront to request your content from a directory in your
        /// 			Amazon S3 bucket or your custom origin. When you include the OriginPath element, 			specify the
        /// directory name, beginning with a /. CloudFront appends the directory name 			to the value of
        /// DomainName, for example, example. com/production. Do 			not include a / at the end of the directory
        /// name.
        /// 		
        /// For example, suppose you&#39;ve specified the following values for your 			distribution:
        /// 		
        /// 			 			 			 		 				 DomainName: An Amazon S3 bucket named myawsbucket. 			 				 OriginPath:
        /// /production 			 				 CNAME: example. com 			
        /// 		
        /// When a user enters example. com/index. html in a browser, CloudFront sends a 			request to Amazon S3
        /// for myawsbucket/production/index. html.
        /// 		
        /// When a user enters example. com/acme/index. html in a browser, CloudFront sends a 			request to
        /// Amazon S3 for myawsbucket/production/acme/index. html.
        /// 	
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OriginPath")]
        public Union<string, IntrinsicFunction> OriginPath { get; set; }

        /// <summary>
        /// Id
        /// 		
        /// A unique identifier for the origin or origin group. The value of Id must be unique within 			the
        /// distribution.
        /// 		
        /// When you specify the value of TargetOriginId for the default cache 			behavior or for another cache
        /// behavior, you indicate the origin to which you want the cache 			behavior to route requests by
        /// specifying the value of the Id element for that 			origin. When a request matches the path pattern
        /// for that cache behavior, CloudFront routes the 			request to the specified origin. For more
        /// information, see Cache 				Behavior Settings in the Amazon CloudFront Developer Guide.
        /// 	
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// CustomOriginConfig
        /// 		
        /// A complex type that contains information about a custom origin. If the origin is an 			Amazon S3
        /// bucket, use the S3OriginConfig element instead.
        /// 	
        /// Required: Conditional
        /// Type: CustomOriginConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CustomOriginConfig")]
        public CustomOriginConfig CustomOriginConfig { get; set; }

    }
}
