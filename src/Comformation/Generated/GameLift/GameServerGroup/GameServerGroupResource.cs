using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GameLift.GameServerGroup
{
    /// <summary>
    /// AWS::GameLift::GameServerGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-gameservergroup.html
    /// </summary>
    public class GameServerGroupResource : ResourceBase
    {
        public class GameServerGroupProperties
        {
            /// <summary>
            /// AutoScalingPolicy
            /// Not currently supported by AWS CloudFormation.
            /// Required: No
            /// Type: AutoScalingPolicy
            /// Update requires: No interruption
            /// </summary>
            public AutoScalingPolicy AutoScalingPolicy { get; set; }

            /// <summary>
            /// BalancingStrategy
            /// Indicates how GameLift FleetIQ balances the use of Spot Instances and On-Demand Instances in the
            /// game server group. Method options include the following:
            /// SPOT_ONLY - Only Spot Instances are used in the game server group. If Spot Instances are unavailable
            /// or not viable for game hosting, the game server group provides no hosting capacity until Spot
            /// Instances can again be used. Until then, no new instances are started, and the existing nonviable
            /// Spot Instances are terminated (after current gameplay ends) and are not replaced. SPOT_PREFERRED -
            /// (default value) Spot Instances are used whenever available in the game server group. If Spot
            /// Instances are unavailable, the game server group continues to provide hosting capacity by falling
            /// back to On-Demand Instances. Existing nonviable Spot Instances are terminated (after current
            /// gameplay ends) and are replaced with new On-Demand Instances. ON_DEMAND_ONLY - Only On-Demand
            /// Instances are used in the game server group. No Spot Instances are used, even when available, while
            /// this balancing strategy is in force.
            /// Required: No
            /// Type: String
            /// Allowed values: ON_DEMAND_ONLY | SPOT_ONLY | SPOT_PREFERRED
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> BalancingStrategy { get; set; }

            /// <summary>
            /// DeleteOption
            /// Not currently supported by AWS CloudFormation.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DeleteOption { get; set; }

            /// <summary>
            /// GameServerGroupName
            /// A developer-defined identifier for the game server group. The name is unique for each Region in each
            /// AWS account.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: [a-zA-Z0-9-\. ]+
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> GameServerGroupName { get; set; }

            /// <summary>
            /// GameServerProtectionPolicy
            /// A flag that indicates whether instances in the game server group are protected from early
            /// termination. Unprotected instances that have active game servers running might be terminated during
            /// a scale-down event, causing players to be dropped from the game. Protected instances cannot be
            /// terminated while there are active game servers running except in the event of a forced game server
            /// group deletion (see ). An exception to this is with Spot Instances, which can be terminated by AWS
            /// regardless of protection status.
            /// Required: No
            /// Type: String
            /// Allowed values: FULL_PROTECTION | NO_PROTECTION
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> GameServerProtectionPolicy { get; set; }

            /// <summary>
            /// InstanceDefinitions
            /// The set of EC2 instance types that GameLift FleetIQ can use when balancing and automatically scaling
            /// instances in the corresponding Auto Scaling group.
            /// Required: Yes
            /// Type: List of InstanceDefinition
            /// Maximum: 20
            /// Update requires: No interruption
            /// </summary>
            public List<InstanceDefinition> InstanceDefinitions { get; set; }

            /// <summary>
            /// LaunchTemplate
            /// Not currently supported by AWS CloudFormation.
            /// Required: Yes
            /// Type: LaunchTemplate
            /// Update requires: No interruption
            /// </summary>
            public LaunchTemplate LaunchTemplate { get; set; }

            /// <summary>
            /// MaxSize
            /// Not currently supported by AWS CloudFormation.
            /// Required: No
            /// Type: Double
            /// Update requires: No interruption
            /// </summary>
            public Union<double, IntrinsicFunction> MaxSize { get; set; }

            /// <summary>
            /// MinSize
            /// Not currently supported by AWS CloudFormation.
            /// Required: No
            /// Type: Double
            /// Update requires: No interruption
            /// </summary>
            public Union<double, IntrinsicFunction> MinSize { get; set; }

            /// <summary>
            /// RoleArn
            /// The Amazon Resource Name (ARN) for an IAM role that allows Amazon GameLift to access your EC2 Auto
            /// Scaling groups.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Pattern: ^arn:. *:role\/[\w+=,. @-]+
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// Tags
            /// Not currently supported by AWS CloudFormation.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// VpcSubnets
            /// Not currently supported by AWS CloudFormation.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> VpcSubnets { get; set; }

        }

        public string Type { get; } = "AWS::GameLift::GameServerGroup";

        public GameServerGroupProperties Properties { get; } = new GameServerGroupProperties();

    }

    public static class GameServerGroupAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> AutoScalingGroupArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("AutoScalingGroupArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> GameServerGroupArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("GameServerGroupArn");
    }
}
