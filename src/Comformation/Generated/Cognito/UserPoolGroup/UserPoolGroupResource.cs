using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPoolGroup
{
    /// <summary>
    /// AWS::Cognito::UserPoolGroup
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolgroup.html
    /// </summary>
    public class UserPoolGroupResource : ResourceBase
    {
        public class UserPoolGroupProperties
        {
            /// <summary>
            /// GroupName
            /// The name of the group. Must be unique.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: [\p{L}\p{M}\p{S}\p{N}\p{P}]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> GroupName { get; set; }

            /// <summary>
            /// Description
            /// A string containing the description of the group.
            /// Required: No
            /// Type: String
            /// Maximum: 2048
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// UserPoolId
            /// The user pool ID for the user pool.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 55
            /// Pattern: [\w-]+_[0-9a-zA-Z]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> UserPoolId { get; set; }

            /// <summary>
            /// Precedence
            /// A nonnegative integer value that specifies the precedence of this group relative to the other groups
            /// that a user can belong to in the user pool. Zero is the highest precedence value. Groups with lower
            /// Precedence values take precedence over groups with higher or null Precedence values. If a user
            /// belongs to two or more groups, it is the group with the lowest precedence value whose role ARN will
            /// be used in the cognito:roles and cognito:preferred_role claims in the user&#39;s tokens.
            /// Two groups can have the same Precedence value. If this happens, neither group takes precedence over
            /// the other. If two groups with the same Precedence have the same role ARN, that role is used in the
            /// cognito:preferred_role claim in tokens for users in each group. If the two groups have different
            /// role ARNs, the cognito:preferred_role claim is not set in users&#39; tokens.
            /// The default Precedence value is null.
            /// Required: No
            /// Type: Double
            /// Minimum: 0
            /// Update requires: No interruption
            /// </summary>
            public Union<double, IntrinsicFunction> Precedence { get; set; }

            /// <summary>
            /// RoleArn
            /// The role ARN for the group.
            /// Required: No
            /// Type: String
            /// Minimum: 20
            /// Maximum: 2048
            /// Pattern: arn:[\w+=/,. @-]+:[\w+=/,. @-]+:([\w+=/,. @-]*)?:[0-9]+:[\w+=/,. @-]+(:[\w+=/,.
            /// @-]+)?(:[\w+=/,. @-]+)?
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

        }

        public string Type { get; } = "AWS::Cognito::UserPoolGroup";

        public UserPoolGroupProperties Properties { get; } = new UserPoolGroupProperties();

    }
}
