using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ApiGateway.Deployment
{
    /// <summary>
    /// AWS::ApiGateway::Deployment CanarySetting
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-deployment-canarysetting.html
    /// </summary>
    public class CanarySetting
    {

        /// <summary>
        /// PercentTraffic
        /// The percent (0-100) of traffic diverted to a canary deployment.
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
