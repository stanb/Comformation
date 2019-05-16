using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.Alias
{
    /// <summary>
    /// AWS::Lambda::Alias VersionWeight
    /// The traffic-shifting configuration of a Lambda function alias.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-alias-versionweight.html
    /// </summary>
    public class VersionWeight
    {

        /// <summary>
        /// FunctionVersion
        /// The name of the second alias.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FunctionVersion")]
        public Union<string, IntrinsicFunction> FunctionVersion { get; set; }

        /// <summary>
        /// FunctionWeight
        /// The percentage of traffic that&#39;s routed to the second alias.
        /// Required: Yes
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FunctionWeight")]
        public Union<double, IntrinsicFunction> FunctionWeight { get; set; }

    }
}
