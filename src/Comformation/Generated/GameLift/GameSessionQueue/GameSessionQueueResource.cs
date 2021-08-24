using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GameLift.GameSessionQueue
{
    /// <summary>
    /// AWS::GameLift::GameSessionQueue
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-gamesessionqueue.html
    /// </summary>
    public class GameSessionQueueResource : ResourceBase
    {
        public class GameSessionQueueProperties
        {
            /// <summary>
            /// TimeoutInSeconds
            /// The maximum time, in seconds, that a new game session placement request remains in the queue. When a
            /// request exceeds this time, the game session placement changes to a TIMED_OUT status.
            /// Required: No
            /// Type: Integer
            /// Minimum: 0
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> TimeoutInSeconds { get; set; }

            /// <summary>
            /// PlayerLatencyPolicies
            /// A set of policies that act as a sliding cap on player latency. FleetIQ works to deliver low latency
            /// for most players in a game session. These policies ensure that no individual player can be placed
            /// into a game with unreasonably high latency. Use multiple policies to gradually relax latency
            /// requirements a step at a time. Multiple policies are applied based on their maximum allowed latency,
            /// starting with the lowest value.
            /// Required: No
            /// Type: List of PlayerLatencyPolicy
            /// Update requires: No interruption
            /// </summary>
            public List<PlayerLatencyPolicy> PlayerLatencyPolicies { get; set; }

            /// <summary>
            /// Destinations
            /// A list of fleets and/or fleet aliases that can be used to fulfill game session placement requests in
            /// the queue. Destinations are identified by either a fleet ARN or a fleet alias ARN, and are listed in
            /// order of placement preference.
            /// Required: No
            /// Type: List of Destination
            /// Update requires: No interruption
            /// </summary>
            public List<Destination> Destinations { get; set; }

            /// <summary>
            /// NotificationTarget
            /// An SNS topic ARN that is set up to receive game session placement notifications. See Setting up
            /// notifications for game session placement.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 300
            /// Pattern: [a-zA-Z0-9:_-]*(\. fifo)?
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> NotificationTarget { get; set; }

            /// <summary>
            /// FilterConfiguration
            /// A list of locations where a queue is allowed to place new game sessions. Locations are specified in
            /// the form of AWS Region codes, such as us-west-2. If this parameter is not set, game sessions can be
            /// placed in any queue location.
            /// Required: No
            /// Type: FilterConfiguration
            /// Update requires: No interruption
            /// </summary>
            public FilterConfiguration FilterConfiguration { get; set; }

            /// <summary>
            /// CustomEventData
            /// Information to be added to all events that are related to this game session queue.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 256
            /// Pattern: [\s\S]*
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> CustomEventData { get; set; }

            /// <summary>
            /// Name
            /// A descriptive label that is associated with game session queue. Queue names must be unique within
            /// each Region.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: [a-zA-Z0-9-]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// PriorityConfiguration
            /// Custom settings to use when prioritizing destinations and locations for game session placements.
            /// This configuration replaces the FleetIQ default prioritization process. Priority types that are not
            /// explicitly named will be automatically applied at the end of the prioritization process.
            /// Required: No
            /// Type: PriorityConfiguration
            /// Update requires: No interruption
            /// </summary>
            public PriorityConfiguration PriorityConfiguration { get; set; }

        }

        public string Type { get; } = "AWS::GameLift::GameSessionQueue";

        public GameSessionQueueProperties Properties { get; } = new GameSessionQueueProperties();

    }

    public static class GameSessionQueueAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
    }
}
