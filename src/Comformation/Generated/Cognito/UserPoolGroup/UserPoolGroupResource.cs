using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Cognito.UserPoolGroup
{
    /// <summary>
    /// AWS::Cognito::UserPoolGroup
    /// The AWS::Cognito::UserPoolGroup resource creates a user group in an Amazon Cognito user pool.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolgroup.html
    /// </summary>
    public class UserPoolGroupResource : ResourceBase
    {
        public class UserPoolGroupProperties
        {
            /// <summary>
            /// GroupName
            /// The name of the user group. GroupName must be unique.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolgroup.html#cfn-cognito-userpoolgroup-groupname
            /// </summary>
			public Union<string, IntrinsicFunction> GroupName { get; set; }

            /// <summary>
            /// Description
            /// A description of the user group.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// MaxLength: 2048
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolgroup.html#cfn-cognito-userpoolgroup-description
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// UserPoolId
            /// The user pool ID.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolgroup.html#cfn-cognito-userpoolgroup-userpoolid
            /// </summary>
			public Union<string, IntrinsicFunction> UserPoolId { get; set; }

            /// <summary>
            /// Precedence
            /// A nonnegative integer value that specifies the precedence of this group relative to the other groups
            /// that a user can belong to in the user pool. Zero is the highest Precedence value. Groups with lower
            /// Precedence values take precedence over groups with higher or null Precedence values. If a user
            /// belongs to two or more groups, the role ARN of the group with the lowest precedence value is used in
            /// the cognito:roles and cognito:preferred_role claims in the user's tokens.
            /// Two groups can have the same Precedence value. If this happens, neither group takes precedence over
            /// the other. If two groups with the same Precedence value have the same role ARN, that role is used in
            /// the cognito:preferred_role claim in tokens for users in each group. If the two groups have different
            /// role ARNs, the cognito:preferred_role claim is not set in users' tokens.
            /// The default Precedence value is null.
            /// Required: No
            /// Type: Number
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolgroup.html#cfn-cognito-userpoolgroup-precedence
            /// </summary>
			public Union<double, IntrinsicFunction> Precedence { get; set; }

            /// <summary>
            /// RoleArn
            /// The role ARN for the group.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolgroup.html#cfn-cognito-userpoolgroup-rolearn
            /// </summary>
			public Union<string, IntrinsicFunction> RoleArn { get; set; }

        }
    
        public string Type { get; } = "AWS::Cognito::UserPoolGroup";
        
        public UserPoolGroupProperties Properties { get; } = new UserPoolGroupProperties();
    }
}
