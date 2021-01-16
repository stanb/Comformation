using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.UsagePlan
{
    /// <summary>
    /// AWS::ApiGateway::UsagePlan ThrottleSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-usageplan-throttlesettings.html
    /// </summary>
    public class ThrottleSettings
    {

        /// <summary>
        /// BurstLimit
        /// The maximum API request rate limit over a time ranging from one to a few seconds. The maximum API
        /// request rate limit depends on whether the underlying token bucket is at its full capacity. For more
        /// information about request throttling, see Manage API Request Throttling in the API Gateway Developer
        /// Guide.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BurstLimit")]
        public Union<int, IntrinsicFunction> BurstLimit { get; set; }

        /// <summary>
        /// RateLimit
        /// The API request steady-state rate limit (average requests per second over an extended period of
        /// time). For more information about request throttling, see Manage API Request Throttling in the API
        /// Gateway Developer Guide.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RateLimit")]
        public Union<double, IntrinsicFunction> RateLimit { get; set; }

    }
}
