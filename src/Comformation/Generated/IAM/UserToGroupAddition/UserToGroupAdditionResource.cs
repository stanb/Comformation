using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IAM.UserToGroupAddition
{
    /// <summary>
    /// AWS::IAM::UserToGroupAddition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-addusertogroup.html
    /// </summary>
    public class UserToGroupAdditionResource : ResourceBase
    {
        public class UserToGroupAdditionProperties
        {
            /// <summary>
            /// GroupName
            /// The name of the group to update.
            /// This parameter allows (through its regex pattern) a string of characters consisting of upper and
            /// lowercase alphanumeric characters with no spaces. You can also include any of the following
            /// characters: _+=,. @-
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: [\w+=,. @-]+
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> GroupName { get; set; }

            /// <summary>
            /// Users
            /// A list of the names of the users that you want to add to the group.
            /// Required: Yes
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> Users { get; set; }

        }

        public string Type { get; } = "AWS::IAM::UserToGroupAddition";

        public UserToGroupAdditionProperties Properties { get; } = new UserToGroupAdditionProperties();

    }
}
