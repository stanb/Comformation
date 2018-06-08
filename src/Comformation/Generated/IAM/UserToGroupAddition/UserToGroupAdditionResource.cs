using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IAM.UserToGroupAddition
{
    /// <summary>
    /// AWS::IAM::UserToGroupAddition
    /// The AWS::IAM::UserToGroupAddition type adds AWS Identity and Access Management (IAM) users to a group.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-addusertogroup.html
    /// </summary>
    public class UserToGroupAdditionResource : ResourceBase
    {
        public class UserToGroupAdditionProperties
        {
            /// <summary>
            /// GroupName
            /// The name of group to add users to.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> GroupName { get; set; }

            /// <summary>
            /// Users
            /// Required: Yes
            /// Type: List of users
            /// Update requires: No interruption
            /// </summary>
			public Union<List<string>, IntrinsicFunction> Users { get; set; }

        }
    
        public string Type { get; } = "AWS::IAM::UserToGroupAddition";
        
        public UserToGroupAdditionProperties Properties { get; } = new UserToGroupAdditionProperties();
    }
}
