using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.UsagePlan
{
    /// <summary>
    /// AWS::ApiGateway::UsagePlan ApiStage
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-usageplan-apistage.html
    /// </summary>
    public class ApiStage
    {

        /// <summary>
        /// ApiId
        /// The ID of an API that is in the specified Stage property that you want to associate with the usage
        /// plan.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ApiId")]
        public Union<string, IntrinsicFunction> ApiId { get; set; }

        /// <summary>
        /// Stage
        /// The name of the stage to associate with the usage plan.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Stage")]
        public Union<string, IntrinsicFunction> Stage { get; set; }

        /// <summary>
        /// Throttle
        /// Map containing method-level throttling information for an API stage in a usage plan. The key for the
        /// map is the path and method for which to configure custom throttling, for example, &quot;/pets/GET&quot;.
        /// Duplicates are not allowed.
        /// Required: No
        /// Type: Map of ThrottleSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Throttle")]
        public Dictionary<string, ThrottleSettings> Throttle { get; set; }

    }
}
