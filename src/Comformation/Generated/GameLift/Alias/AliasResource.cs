using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GameLift.Alias
{
    /// <summary>
    /// AWS::GameLift::Alias
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-alias.html
    /// </summary>
    public class AliasResource : ResourceBase
    {
        public class AliasProperties
        {
            /// <summary>
            /// Description
            /// A human-readable description of the alias.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Name
            /// A descriptive label that is associated with an alias. Alias names do not need to be unique.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Pattern: . *\S. *
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// RoutingStrategy
            /// A routing configuration that specifies where traffic is directed for this alias, such as to a fleet
            /// or to a message.
            /// Required: Yes
            /// Type: RoutingStrategy
            /// Update requires: No interruption
            /// </summary>
            public RoutingStrategy RoutingStrategy { get; set; }

        }

        public string Type { get; } = "AWS::GameLift::Alias";

        public AliasProperties Properties { get; } = new AliasProperties();

    }

    public static class AliasAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> AliasId = new ResourceAttribute<Union<string, IntrinsicFunction>>("AliasId");
    }
}
