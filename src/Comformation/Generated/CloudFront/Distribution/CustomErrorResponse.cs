using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFront.Distribution
{
    /// <summary>
    /// CloudFront Distribution CustomErrorResponse
    /// CustomErrorResponse is a property of the CloudFront Distribution DistributionConfig resource that defines
    /// custom error messages for certain HTTP status codes.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution-customerrorresponse.html
    /// </summary>
    public class CustomErrorResponse
    {

        /// <summary>
        /// ResponseCode
        /// The HTTP status code that CloudFront returns to viewer along with the custom error page. You can
        /// specify 200, 400, 403, 404, 405, 414, 500, 501, 502, 503, or 504.
        /// Required: Conditional. Required if you specified the ResponsePagePath property.
        /// Type: Integer
        /// </summary>
        [JsonProperty("ResponseCode")]
        public Union<int, IntrinsicFunction> ResponseCode { get; set; }

        /// <summary>
        /// ErrorCachingMinTTL
        /// The minimum amount of time, in seconds, that Amazon CloudFront caches the HTTP status code that you
        /// specified in the ErrorCode property. The default value is 300.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("ErrorCachingMinTTL")]
        public Union<double, IntrinsicFunction> ErrorCachingMinTTL { get; set; }

        /// <summary>
        /// ErrorCode
        /// An HTTP status code for which you want to specify a custom error page. You can specify 400, 403,
        /// 404, 405, 414, 500, 501, 502, 503, or 504.
        /// Required: Yes
        /// Type: Integer
        /// </summary>
        [JsonProperty("ErrorCode")]
        public Union<int, IntrinsicFunction> ErrorCode { get; set; }

        /// <summary>
        /// ResponsePagePath
        /// The path to the custom error page that CloudFront returns to a viewer when your origin returns the
        /// HTTP status code that you specified in the ErrorCode property. For example, you can specify
        /// /404-errors/403-forbidden. html.
        /// Required: Conditional. Required if you specified the ResponseCode property.
        /// Type: String
        /// </summary>
        [JsonProperty("ResponsePagePath")]
        public Union<string, IntrinsicFunction> ResponsePagePath { get; set; }

    }
}
