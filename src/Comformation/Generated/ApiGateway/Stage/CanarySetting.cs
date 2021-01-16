using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.Stage
{
    /// <summary>
    /// AWS::ApiGateway::Stage CanarySetting
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-stage-canarysetting.html
    /// </summary>
    public class CanarySetting
    {

        /// <summary>
        /// DeploymentId
        /// The identifier of the deployment that the stage points to.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeploymentId")]
        public Union<string, IntrinsicFunction> DeploymentId { get; set; }

        /// <summary>
        /// PercentTraffic
        /// The percentage (0-100) of traffic diverted to a canary deployment.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PercentTraffic")]
        public Union<double, IntrinsicFunction> PercentTraffic { get; set; }

        /// <summary>
        /// StageVariableOverrides
        /// Stage variables overridden for a canary release deployment, including new stage variables introduced
        /// in the canary. These stage variables are represented as a string-to-string map between stage
        /// variable names and their values.
        /// Duplicates are not allowed.
        /// Required: No
        /// Type: Map of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StageVariableOverrides")]
        public Dictionary<string, Union<string, IntrinsicFunction>> StageVariableOverrides { get; set; }

        /// <summary>
        /// UseStageCache
        /// Whether the canary deployment uses the stage cache or not.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UseStageCache")]
        public Union<bool, IntrinsicFunction> UseStageCache { get; set; }

    }
}
