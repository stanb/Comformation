using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.Deployment
{
    /// <summary>
    /// AWS::ApiGateway::Deployment DeploymentCanarySettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-deploymentcanarysettings.html
    /// </summary>
    public class DeploymentCanarySettings
    {

        /// <summary>
        /// PercentTraffic
        /// The percentage (0-100) of traffic diverted to a canary deployment.
        /// Required: No
        /// Type: Double
        /// Update requires: Replacement
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
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("StageVariableOverrides")]
        public Dictionary<string, Union<string, IntrinsicFunction>> StageVariableOverrides { get; set; }

        /// <summary>
        /// UseStageCache
        /// Whether the canary deployment uses the stage cache.
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("UseStageCache")]
        public Union<bool, IntrinsicFunction> UseStageCache { get; set; }

    }
}
