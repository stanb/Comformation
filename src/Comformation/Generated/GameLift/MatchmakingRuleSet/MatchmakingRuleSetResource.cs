using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GameLift.MatchmakingRuleSet
{
    /// <summary>
    /// AWS::GameLift::MatchmakingRuleSet
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-matchmakingruleset.html
    /// </summary>
    public class MatchmakingRuleSetResource : ResourceBase
    {
        public class MatchmakingRuleSetProperties
        {
            /// <summary>
            /// RuleSetBody
            /// A collection of matchmaking rules, formatted as a JSON string. Comments are not allowed in JSON, but
            /// most elements support a description field.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 65535
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> RuleSetBody { get; set; }

            /// <summary>
            /// Name
            /// A unique identifier for a matchmaking rule set. A matchmaking configuration identifies the rule set
            /// it uses by this name value. Note that the rule set name is different from the optional name field in
            /// the rule set body.
            /// Required: Yes
            /// Type: String
            /// Maximum: 128
            /// Pattern: [a-zA-Z0-9-\. ]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

        }

        public string Type { get; } = "AWS::GameLift::MatchmakingRuleSet";

        public MatchmakingRuleSetProperties Properties { get; } = new MatchmakingRuleSetProperties();

    }

    public static class MatchmakingRuleSetAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Name = new ResourceAttribute<Union<string, IntrinsicFunction>>("Name");
    }
}
