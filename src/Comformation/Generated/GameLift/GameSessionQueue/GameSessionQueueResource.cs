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
            /// A collection of latency policies to apply when processing game sessions placement requests with
            /// player latency information. Multiple policies are evaluated in order of the maximum latency value,
            /// starting with the lowest latency values. With just one policy, the policy is enforced at the start
            /// of the game session placement for the duration period. With multiple policies, each policy is
            /// enforced consecutively for its duration period. For example, a queue might enforce a 60-second
            /// policy followed by a 120-second policy, and then no policy for the remainder of the placement. A
            /// player latency policy must set a value for MaximumIndividualPlayerLatencyMilliseconds. If none is
            /// set, this API request fails.
            /// Required: No
            /// Type: List of PlayerLatencyPolicy
            /// Update requires: No interruption
            /// </summary>
            public List<PlayerLatencyPolicy> PlayerLatencyPolicies { get; set; }

            /// <summary>
            /// Destinations
            /// A list of fleets that can be used to fulfill game session placement requests in the queue. Fleets
            /// are identified by either a fleet ARN or a fleet alias ARN. Destinations are listed in default
            /// preference order.
            /// Required: No
            /// Type: List of Destination
            /// Update requires: No interruption
            /// </summary>
            public List<Destination> Destinations { get; set; }

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
