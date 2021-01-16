using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// AWS::CloudFront::Distribution ForwardedValues
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-forwardedvalues.html
    /// </summary>
    public class ForwardedValues
    {

        /// <summary>
        /// Cookies
        /// 		
        /// This field is deprecated. We recommend that you use a cache policy or an origin 			request policy
        /// instead of this field.
        /// 		
        /// If you want to include cookies in the cache key, use a cache policy. For more 			information, see
        /// Creating cache policies in the Amazon CloudFront Developer Guide.
        /// 		
        /// If you want to send cookies to the origin but not include them in the cache key, use an 			origin
        /// request policy. For more information, see Creating origin request policies in the 			Amazon
        /// CloudFront Developer Guide.
        /// 		
        /// A complex type that specifies whether you want CloudFront to forward cookies to the origin 			and,
        /// if so, which ones. For more information about forwarding cookies to the origin, see 			How
        /// CloudFront Forwards, Caches, and Logs Cookies in the 			Amazon CloudFront Developer Guide.
        /// 	
        /// Required: No
        /// Type: Cookies
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Cookies")]
        public Cookies Cookies { get; set; }

        /// <summary>
        /// Headers
        /// 		
        /// This field is deprecated. We recommend that you use a cache policy or an origin 			request policy
        /// instead of this field.
        /// 		
        /// If you want to include headers in the cache key, use a cache policy. For more information, 			see
        /// Creating cache policies in the Amazon CloudFront Developer Guide.
        /// 		
        /// If you want to send headers to the origin but not include them in the cache key, use an 			origin
        /// request policy. For more information, see Creating origin request policies in the 			Amazon
        /// CloudFront Developer Guide.
        /// 		
        /// A complex type that specifies the Headers, if any, that you want CloudFront to forward to the
        /// 			origin for this cache behavior (whitelisted headers). For the headers that you specify,
        /// CloudFront also caches 			separate versions of a specified object that is based on the header values
        /// in viewer requests.
        /// 		
        /// For more information, see 			Caching Content Based on Request Headers in the Amazon CloudFront
        /// Developer Guide.
        /// 	
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Headers")]
        public List<Union<string, IntrinsicFunction>> Headers { get; set; }

        /// <summary>
        /// QueryString
        /// 		
        /// This field is deprecated. We recommend that you use a cache policy or an origin 			request policy
        /// instead of this field.
        /// 		
        /// If you want to include query strings in the cache key, use a cache policy. For more 			information,
        /// see Creating cache policies in the Amazon CloudFront Developer Guide.
        /// 		
        /// If you want to send query strings to the origin but not include them in the cache key, use 			an
        /// origin request policy. For more information, see Creating origin request policies in the 			Amazon
        /// CloudFront Developer Guide.
        /// 		
        /// Indicates whether you want CloudFront to forward query strings to the origin that is 			associated
        /// with this cache behavior and cache based on the query string parameters. CloudFront 			behavior
        /// depends on the value of QueryString and on the values that you specify 			for QueryStringCacheKeys,
        /// if any:
        /// 		
        /// If you specify true for QueryString and you don&#39;t specify any values for 				QueryStringCacheKeys,
        /// CloudFront forwards all query string parameters to the origin 			and caches based on all query
        /// string parameters. Depending on how many query string parameters 			and values you have, this can
        /// adversely affect performance because CloudFront must forward more 			requests to the origin.
        /// 		
        /// If you specify true for QueryString and you specify one or more values for 				QueryStringCacheKeys,
        /// CloudFront forwards all query string parameters to the origin, 			but it only caches based on the
        /// query string parameters that you specify.
        /// 		
        /// If you specify false for QueryString, CloudFront doesn&#39;t forward any query 			string parameters to
        /// the origin, and doesn&#39;t cache based on query string parameters.
        /// 		
        /// For more information, see Configuring CloudFront to Cache Based on Query String Parameters in the
        /// 				Amazon CloudFront Developer Guide.
        /// 	
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("QueryString")]
        public Union<bool, IntrinsicFunction> QueryString { get; set; }

        /// <summary>
        /// QueryStringCacheKeys
        /// 		
        /// This field is deprecated. We recommend that you use a cache policy or an origin 			request policy
        /// instead of this field.
        /// 		
        /// If you want to include query strings in the cache key, use a cache policy. For more 			information,
        /// see Creating cache policies in the Amazon CloudFront Developer Guide.
        /// 		
        /// If you want to send query strings to the origin but not include them in the cache key, use 			an
        /// origin request policy. For more information, see Creating origin request policies in the 			Amazon
        /// CloudFront Developer Guide.
        /// 		
        /// A complex type that contains information about the query string parameters that you 			want
        /// CloudFront to use for caching for this cache behavior.
        /// 	
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("QueryStringCacheKeys")]
        public List<Union<string, IntrinsicFunction>> QueryStringCacheKeys { get; set; }

    }
}
