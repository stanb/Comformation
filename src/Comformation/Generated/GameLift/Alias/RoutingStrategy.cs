using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GameLift.Alias
{
    /// <summary>
    /// Amazon GameLift Alias RoutingStrategy
    /// RoutingStrategy is a property of the AWS::GameLift::Alias resource that configures the routing strategy for an
    /// Amazon GameLift (GameLift) alias. For more information, see the RoutingStrategy data type in the Amazon
    /// GameLift API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-alias-routingstrategy.html
    /// </summary>
    public class RoutingStrategy
    {

        /// <summary>
        /// FleetId
        /// A unique identifier of a GameLift fleet to associate with the alias.
        /// Required: Conditional. If you specify SIMPLE for the Type property, you must specify this property.
        /// Type: String
        /// </summary>
        [JsonProperty("FleetId")]
        public Union<string, IntrinsicFunction> FleetId { get; set; }

        /// <summary>
        /// Message
        /// A text message that GameLift displays for the Terminal routing type.
        /// Required: Conditional. If you specify TERMINAL for the Type property, you must specify this
        /// property.
        /// Type: String
        /// </summary>
        [JsonProperty("Message")]
        public Union<string, IntrinsicFunction> Message { get; set; }

        /// <summary>
        /// Type
        /// The type of routing strategy. For the SIMPLE type, traffic is routed to an active GameLift fleet.
        /// For the Terminal type, GameLift returns an exception with the message that you specified in the
        /// Message property.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
