using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.UsagePlan
{
    /// <summary>
    /// AWS::ApiGateway::UsagePlan
    /// The AWS::ApiGateway::UsagePlan resource specifies a usage plan for deployed Amazon API Gateway (API Gateway)
    /// APIs. A usage plan enforces throttling and quota limits on individual client API keys. For more information,
    /// see Creating and Using API Usage Plans in Amazon API Gateway in the API Gateway Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-usageplan.html
    /// </summary>
    public class UsagePlanResource : ResourceBase
    {
        public class UsagePlanProperties
        {
            /// <summary>
            /// ApiStages
            /// The API stages to associate with this usage plan.
            /// Required: No
            /// Type: List of Amazon API Gateway UsagePlan ApiStage
            /// Update requires: No interruption
            /// </summary>
			public List<ApiStage> ApiStages { get; set; }

            /// <summary>
            /// Description
            /// The purpose of this usage plan.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Quota
            /// Configures the number of requests that users can make within a given interval.
            /// Required: No
            /// Type: Amazon API Gateway UsagePlan QuotaSettings
            /// Update requires: No interruption
            /// </summary>
			public QuotaSettings Quota { get; set; }

            /// <summary>
            /// Throttle
            /// Configures the overall request rate (average requests per second) and burst capacity.
            /// Required: No
            /// Type: Amazon API Gateway UsagePlan ThrottleSettings
            /// Update requires: No interruption
            /// </summary>
			public ThrottleSettings Throttle { get; set; }

            /// <summary>
            /// UsagePlanName
            /// A name for this usage plan.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> UsagePlanName { get; set; }

        }

        public string Type { get; } = "AWS::ApiGateway::UsagePlan";

        public UsagePlanProperties Properties { get; } = new UsagePlanProperties();

    }
}
