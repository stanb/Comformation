using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GameLift.Fleet
{
    /// <summary>
    /// AWS::GameLift::Fleet LocationConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-fleet-locationconfiguration.html
    /// </summary>
    public class LocationConfiguration
    {

        /// <summary>
        /// Location
        /// An AWS Region code, such as us-west-2.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 64
        /// Pattern: ^[a-z]+(-([a-z]+|\d))*
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Location")]
        public Union<string, IntrinsicFunction> Location { get; set; }

        /// <summary>
        /// LocationCapacity
        /// Current resource capacity settings in a specified fleet or location. The location value might refer
        /// to a fleet&#39;s remote location or its home Region.
        /// Related actions
        /// DescribeFleetCapacity | DescribeFleetLocationCapacity | UpdateFleetCapacity
        /// Required: No
        /// Type: LocationCapacity
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LocationCapacity")]
        public LocationCapacity LocationCapacity { get; set; }

    }
}
