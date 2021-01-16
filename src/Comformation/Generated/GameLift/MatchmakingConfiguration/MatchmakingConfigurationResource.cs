using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GameLift.MatchmakingConfiguration
{
    /// <summary>
    /// AWS::GameLift::MatchmakingConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-matchmakingconfiguration.html
    /// </summary>
    public class MatchmakingConfigurationResource : ResourceBase
    {
        public class MatchmakingConfigurationProperties
        {
            /// <summary>
            /// GameProperties
            /// A set of custom properties for a game session, formatted as key-value pairs. These properties are
            /// passed to a game server process with a request to start a new game session. See Start a Game
            /// Session. This parameter is not used if FlexMatchMode is set to STANDALONE.
            /// Required: No
            /// Type: List of GameProperty
            /// Maximum: 16
            /// Update requires: No interruption
            /// </summary>
            public List<GameProperty> GameProperties { get; set; }

            /// <summary>
            /// GameSessionData
            /// A set of custom game session properties, formatted as a single string value. This data is passed to
            /// a game server process with a request to start a new game session. See Start a Game Session. This
            /// parameter is not used ifFlexMatchMode is set to STANDALONE.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 4096
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> GameSessionData { get; set; }

            /// <summary>
            /// Description
            /// A descriptive label that is associated with matchmaking configuration.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// AcceptanceTimeoutSeconds
            /// The length of time (in seconds) to wait for players to accept a proposed match, if acceptance is
            /// required.
            /// Required: No
            /// Type: Integer
            /// Minimum: 1
            /// Maximum: 600
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> AcceptanceTimeoutSeconds { get; set; }

            /// <summary>
            /// NotificationTarget
            /// An SNS topic ARN that is set up to receive matchmaking notifications. See Setting up notifications
            /// for matchmaking for more information.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 300
            /// Pattern: [a-zA-Z0-9:_/-]*
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> NotificationTarget { get; set; }

            /// <summary>
            /// CustomEventData
            /// Information that is attached to all events related to the matchmaking configuration.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 256
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> CustomEventData { get; set; }

            /// <summary>
            /// Name
            /// A unique identifier for a matchmaking configuration. Matchmaking requests use this name to identify
            /// which matchmaking configuration to use.
            /// Required: Yes
            /// Type: String
            /// Maximum: 128
            /// Pattern: [a-zA-Z0-9-\. ]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// AdditionalPlayerCount
            /// The number of player slots in a match to keep open for future players. For example, assume that the
            /// configuration&#39;s rule set specifies a match for a single 12-person team. If the additional player
            /// count is set to 2, only 10 players are initially selected for the match. This parameter is not used
            /// if FlexMatchMode is set to STANDALONE.
            /// Required: No
            /// Type: Integer
            /// Minimum: 0
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> AdditionalPlayerCount { get; set; }

            /// <summary>
            /// BackfillMode
            /// The method used to backfill game sessions that are created with this matchmaking configuration.
            /// Specify MANUAL when your game manages backfill requests manually or does not use the match backfill
            /// feature. Specify AUTOMATIC to have GameLift create a StartMatchBackfill request whenever a game
            /// session has one or more open slots. Learn more about manual and automatic backfill in Backfill
            /// Existing Games with FlexMatch. Automatic backfill is not available when FlexMatchMode is set to
            /// STANDALONE.
            /// Required: No
            /// Type: String
            /// Allowed values: AUTOMATIC | MANUAL
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> BackfillMode { get; set; }

            /// <summary>
            /// RequestTimeoutSeconds
            /// The maximum duration, in seconds, that a matchmaking ticket can remain in process before timing out.
            /// Requests that fail due to timing out can be resubmitted as needed.
            /// Required: Yes
            /// Type: Integer
            /// Minimum: 1
            /// Maximum: 43200
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> RequestTimeoutSeconds { get; set; }

            /// <summary>
            /// AcceptanceRequired
            /// A flag that determines whether a match that was created with this configuration must be accepted by
            /// the matched players. To require acceptance, set to TRUE. With this option enabled, matchmaking
            /// tickets use the status REQUIRES_ACCEPTANCE to indicate when a completed potential match is waitiing
            /// for player accepance.
            /// Required: Yes
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> AcceptanceRequired { get; set; }

            /// <summary>
            /// FlexMatchMode
            /// Indicates whether this matchmaking configuration is being used with GameLift managed hosting or as a
            /// standalone matchmaking solution.
            /// STANDALONE - FlexMatch forms matches and returns match information, including players and team
            /// assignments, in a MatchmakingSucceeded event. WITH_QUEUE - FlexMatch forms matches and uses the
            /// specified GameLift queue to start a game session for the match.
            /// Required: No
            /// Type: String
            /// Allowed values: STANDALONE | WITH_QUEUE
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> FlexMatchMode { get; set; }

            /// <summary>
            /// RuleSetName
            /// A unique identifier for a matchmaking rule set to use with this configuration. You can use either
            /// the rule set name or ARN value. A matchmaking configuration can only use rule sets that are defined
            /// in the same Region.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Pattern: [a-zA-Z0-9-\. ]*|^arn:. *:matchmakingruleset\/[a-zA-Z0-9-\. ]*
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RuleSetName { get; set; }

            /// <summary>
            /// GameSessionQueueArns
            /// Amazon Resource Name (ARN) that is assigned to a GameLift game session queue resource and uniquely
            /// identifies it. ARNs are unique across all Regions. Queues can be located in any Region. Queues are
            /// used to start new GameLift-hosted game sessions for matches that are created with this matchmaking
            /// configuration. If FlexMatchMode is set to STANDALONE, do not set this parameter.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> GameSessionQueueArns { get; set; }

        }

        public string Type { get; } = "AWS::GameLift::MatchmakingConfiguration";

        public MatchmakingConfigurationProperties Properties { get; } = new MatchmakingConfigurationProperties();

    }

    public static class MatchmakingConfigurationAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
    }
}
