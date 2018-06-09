using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// CloudFront Distribution ForwardedValues
    /// ForwardedValues is a property of the DefaultCacheBehavior and CacheBehavior properties that indicates whether
    /// Amazon CloudFront forwards query strings or cookies.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-forwardedvalues.html
    /// </summary>
    public class ForwardedValues
    {

        /// <summary>
        /// Cookies
        /// Forwards specified cookies to the origin of the cache behavior. For more information, see
        /// Configuring CloudFront to Cache Based on Cookies in the Amazon CloudFront Developer Guide.
        /// Required: No
        /// Type: CloudFront Distribution Cookies
        /// </summary>
        [JsonProperty("Cookies")]
        public Union<Cookies, IntrinsicFunction> Cookies { get; set; }

        /// <summary>
        /// Headers
        /// Specifies the headers that you want Amazon CloudFront to forward to the origin for this cache
        /// behavior (whitelisted headers). For the headers that you specify, Amazon CloudFront also caches
        /// separate versions of a specified object that is based on the header values in viewer requests.
        /// For custom origins, if you specify a single asterisk ([&quot;*&quot;]), all headers are forwarded. If you
        /// don&#39;t specify a value, only the default headers are forwarded. For Amazon S3 origins, you can
        /// forward only selected headers; specifying * is not supported. For more information, see Configuring
        /// CloudFront to Cache Objects Based on Request Headers in the Amazon CloudFront Developer Guide.
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("Headers")]
        public Union<List<string>, IntrinsicFunction> Headers { get; set; }

        /// <summary>
        /// QueryString
        /// Indicates whether you want CloudFront to forward query strings to the origin that is associated with
        /// this cache behavior. If so, specify true; if not, specify false. For more information about
        /// forwarding query strings, see the QueryString parameter for the ForwardedValues type in the Amazon
        /// CloudFront API Reference.
        /// Required: Yes
        /// Type: Boolean
        /// </summary>
        [JsonProperty("QueryString")]
        public Union<bool, IntrinsicFunction> QueryString { get; set; }

        /// <summary>
        /// QueryStringCacheKeys
        /// If you forward query strings to the origin, specifies the query string parameters that CloudFront
        /// uses to determine which content to cache. For more information, see Configuring CloudFront to Cache
        /// Based on Query String Parameters in the Amazon CloudFront Developer Guide.
        /// Required: No
        /// Type: List of String values
        /// </summary>
        [JsonProperty("QueryStringCacheKeys")]
        public Union<List<string>, IntrinsicFunction> QueryStringCacheKeys { get; set; }

    }
}
