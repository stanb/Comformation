using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.UsagePlan
{
    /// <summary>
    /// AWS::ApiGateway::UsagePlan QuotaSettings
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
        /// The day that a time period starts. For example, with a time period of WEEK, an offset of 0 starts on
        /// Sunday, and an offset of 1 starts on Monday.
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
