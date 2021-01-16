using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GameLift.Fleet
{
    /// <summary>
    /// AWS::GameLift::Fleet ResourceCreationLimitPolicy
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-resourcecreationlimitpolicy.html
    /// </summary>
    public class ResourceCreationLimitPolicy
    {

        /// <summary>
        /// NewGameSessionsPerCreator
        /// The maximum number of game sessions that an individual can create during the policy period.
        /// Required: No
        /// Type: Integer
        /// Minimum: 0
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NewGameSessionsPerCreator")]
        public Union<int, IntrinsicFunction> NewGameSessionsPerCreator { get; set; }

        /// <summary>
        /// PolicyPeriodInMinutes
        /// The time span used in evaluating the resource creation limit policy.
        /// Required: No
        /// Type: Integer
        /// Minimum: 0
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PolicyPeriodInMinutes")]
        public Union<int, IntrinsicFunction> PolicyPeriodInMinutes { get; set; }

    }
}
