using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.CachePolicy
{
    /// <summary>
    /// AWS::CloudFront::CachePolicy ParametersInCacheKeyAndForwardedToOrigin
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachepolicy-parametersincachekeyandforwardedtoorigin.html
    /// </summary>
    public class ParametersInCacheKeyAndForwardedToOrigin
    {

        /// <summary>
        /// CookiesConfig
        /// 		
        /// An object that determines whether any cookies in viewer requests (and if so, which cookies) 			are
        /// included in the cache key and automatically included in requests that CloudFront sends to 			the
        /// origin.
        /// 	
        /// Required: Yes
        /// Type: CookiesConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CookiesConfig")]
        public CookiesConfig CookiesConfig { get; set; }

        /// <summary>
        /// EnableAcceptEncodingBrotli
        /// 		
        /// A flag that can affect whether the Accept-Encoding HTTP header is 			included in the cache key and
        /// included in requests that CloudFront sends to the origin.
        /// 		
        /// This field is related to the EnableAcceptEncodingGzip field. If one or 			both of these fields is
        /// true and the viewer request 			includes the Accept-Encoding header, then CloudFront does the
        /// following:
        /// 		
        /// 			 			 			 		 				 Normalizes the value of the viewer’s Accept-Encoding 					header 			 				
        /// Includes the normalized header in the cache key 			 				 Includes the normalized header in the
        /// request to the origin, if a request is necessary 			
        /// 		
        /// For more information, see Compression support in the Amazon CloudFront Developer Guide.
        /// If you set this value to true, and this cache behavior also has an origin 			request policy
        /// attached, do not include the Accept-Encoding header in the 			origin request policy. CloudFront
        /// always includes the Accept-Encoding header in 			origin requests when the value of this field is
        /// true, so including this 			header in an origin request policy has no effect.
        /// 		
        /// If both of these fields are false, then CloudFront treats the 			Accept-Encoding header the same as
        /// any other HTTP header in the viewer 			request. By default, it’s not included in the cache key and
        /// it’s not included in origin 			requests. In this case, you can manually add Accept-Encoding to the
        /// headers 			whitelist like any other HTTP header.
        /// 	
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EnableAcceptEncodingBrotli")]
        public Union<bool, IntrinsicFunction> EnableAcceptEncodingBrotli { get; set; }

        /// <summary>
        /// EnableAcceptEncodingGzip
        /// A flag that can affect whether the Accept-Encoding HTTP header is 			included in the cache key and
        /// included in requests that CloudFront sends to the origin.
        /// 		
        /// This field is related to the EnableAcceptEncodingBrotli field. If one or 			both of these fields is
        /// true and the viewer request 			includes the Accept-Encoding header, then CloudFront does the
        /// following:
        /// 		
        /// 			 			 			 		 				 Normalizes the value of the viewer’s Accept-Encoding 					header 			 				
        /// Includes the normalized header in the cache key 			 				 Includes the normalized header in the
        /// request to the origin, if a request is necessary 			
        /// 		
        /// For more information, see Compression support in the Amazon CloudFront Developer Guide.
        /// 		
        /// If you set this value to true, and this cache behavior also has an origin 			request policy
        /// attached, do not include the Accept-Encoding header in the 			origin request policy. CloudFront
        /// always includes the Accept-Encoding header in 			origin requests when the value of this field is
        /// true, so including this 			header in an origin request policy has no effect.
        /// 		
        /// If both of these fields are false, then CloudFront treats the 			Accept-Encoding header the same as
        /// any other HTTP header in the viewer 			request. By default, it’s not included in the cache key and
        /// it’s not included in origin 			requests. In this case, you can manually add Accept-Encoding to the
        /// headers 			whitelist like any other HTTP header.
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EnableAcceptEncodingGzip")]
        public Union<bool, IntrinsicFunction> EnableAcceptEncodingGzip { get; set; }

        /// <summary>
        /// HeadersConfig
        /// An object that determines whether any HTTP headers (and if so, which headers) are 			included in the
        /// cache key and automatically included in requests that CloudFront sends to the 			origin.
        /// Required: Yes
        /// Type: HeadersConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HeadersConfig")]
        public HeadersConfig HeadersConfig { get; set; }

        /// <summary>
        /// QueryStringsConfig
        /// 		
        /// An object that determines whether any URL query strings in viewer requests (and if so, which
        /// 			query strings) are included in the cache key and automatically included in requests that
        /// 			CloudFront sends to the origin.
        /// 	
        /// Required: Yes
        /// Type: QueryStringsConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("QueryStringsConfig")]
        public QueryStringsConfig QueryStringsConfig { get; set; }

    }
}
