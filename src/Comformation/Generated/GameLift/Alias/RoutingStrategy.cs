using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GameLift.Alias
{
    /// <summary>
    /// AWS::GameLift::Alias RoutingStrategy
    /// Routing configuration for a fleet alias.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-alias-routingstrategy.html
    /// </summary>
    public class RoutingStrategy
    {

        /// <summary>
        /// FleetId
        /// Unique identifier for a fleet that the alias points to.
        /// Required: Conditional. If you specify SIMPLE for the Type property, you must specify this property.
        /// Required: No
        /// Type: String
        /// Pattern: ^fleet-\S+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FleetId")]
        public Union<string, IntrinsicFunction> FleetId { get; set; }

        /// <summary>
        /// Message
        /// Message text to be used with a terminal routing strategy.
        /// Required: Conditional. If you specify TERMINAL for the Type property, you must specify this
        /// property.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Message")]
        public Union<string, IntrinsicFunction> Message { get; set; }

        /// <summary>
        /// Type
        /// Type of routing strategy.
        /// Possible routing types include the following:
        /// SIMPLE -- The alias resolves to one specific fleet. Use this type when routing to active fleets.
        /// TERMINAL -- The alias does not resolve to a fleet but instead can be used to display a message to
        /// the user. A terminal alias throws a TerminalRoutingStrategyException with the message that you
        /// specified in the Message property.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: SIMPLE | TERMINAL
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
