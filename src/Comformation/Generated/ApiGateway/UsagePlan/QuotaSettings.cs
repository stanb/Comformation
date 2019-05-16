using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.UsagePlan
{
    /// <summary>
    /// AWS::ApiGateway::UsagePlan QuotaSettings
    /// QuotaSettings is a property of the AWS::ApiGateway::UsagePlan resource that specifies the maximum number of
    /// requests users can make to your REST APIs.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-usageplan-quotasettings.html
    /// </summary>
    public class QuotaSettings
    {

        /// <summary>
        /// Limit
        /// The maximum number of requests that users can make within the specified time period.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Limit")]
        public Union<int, IntrinsicFunction> Limit { get; set; }

        /// <summary>
        /// Offset
        /// For the initial time period, the number of requests to subtract from the specified limit. When you
        /// first implement a usage plan, the plan might start in the middle of the week or month. With this
        /// property, you can decrease the limit for this initial time period.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Offset")]
        public Union<int, IntrinsicFunction> Offset { get; set; }

        /// <summary>
        /// Period
        /// The time period for which the maximum limit of requests applies, such as DAY or WEEK. For valid
        /// values, see the period property for the UsagePlan resource in the Amazon API Gateway REST API
        /// Reference.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Period")]
        public Union<string, IntrinsicFunction> Period { get; set; }

    }
}
