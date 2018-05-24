using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IAM.UserToGroupAddition
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-addusertogroup.html
    /// </summary>
    public class UserToGroupAdditionResource : ResourceBase
    {
        public class UserToGroupAdditionProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-addusertogroup.html#cfn-iam-addusertogroup-groupname
            /// </summary>
			public Union<string, IntrinsicFunction> GroupName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-addusertogroup.html#cfn-iam-addusertogroup-users
            /// </summary>
			public Union<List<string>, IntrinsicFunction> Users { get; set; }

        }
    
        public string Type { get; } = "AWS::IAM::UserToGroupAddition";
        
        public UserToGroupAdditionProperties Properties { get; } = new UserToGroupAdditionProperties();
    }
}
