using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GameLift.Alias
{
    /// <summary>
    /// AWS::GameLift::Alias
    /// The AWS::GameLift::Alias resource creates an alias for an Amazon GameLift (GameLift) fleet, which you can use
    /// to anonymize your fleet. You can reference the alias instead of a specific fleet when you create game
    /// sessions. For more information, see the CreateAlias action in the Amazon GameLift API Reference.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-alias.html
    /// </summary>
    public class AliasResource : ResourceBase
    {
        public class AliasProperties
        {
            /// <summary>
            /// Description
            /// Information that helps you identify the purpose of this alias.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-alias.html#cfn-gamelift-alias-description
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Name
            /// An identifier to associate with this alias. Alias names don't need to be unique.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-alias.html#cfn-gamelift-alias-name
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// RoutingStrategy
            /// A routing configuration that specifies where traffic is directed for this alias, such as to a fleet
            /// or to a message.
            /// Required: Yes
            /// Type: Amazon GameLift Alias RoutingStrategy
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-alias.html#cfn-gamelift-alias-routingstrategy
            /// </summary>
			public Union<RoutingStrategy, IntrinsicFunction> RoutingStrategy { get; set; }

        }
    
        public string Type { get; } = "AWS::GameLift::Alias";
        
        public AliasProperties Properties { get; } = new AliasProperties();
    }
}
