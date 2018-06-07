using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IAM.AccessKey
{
    /// <summary>
    /// AWS::IAM::AccessKey
    /// The AWS::IAM::AccessKey resource type generates a secret access key and assigns it to an IAM user or AWS
    /// account.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-accesskey.html
    /// </summary>
    public class AccessKeyResource : ResourceBase
    {
        public class AccessKeyProperties
        {
            /// <summary>
            /// Serial
            /// This value is specific to AWS CloudFormation and can only be incremented. Incrementing this value
            /// notifies AWS CloudFormation that you want to rotate your access key. When you update your stack, AWS
            /// CloudFormation will replace the existing access key with a new key.
            /// Required: No
            /// Type: Integer
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-accesskey.html#cfn-iam-accesskey-serial
            /// </summary>
			public Union<int, IntrinsicFunction> Serial { get; set; }

            /// <summary>
            /// Status
            /// The status of the access key. By default, AWS CloudFormation sets this property value to Active.
            /// Required: No
            /// Type: String
            /// Valid values: Active or Inactive
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-accesskey.html#cfn-iam-accesskey-status
            /// </summary>
			public Union<string, IntrinsicFunction> Status { get; set; }

            /// <summary>
            /// UserName
            /// The name of the user that the new key will belong to.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-accesskey.html#cfn-iam-accesskey-username
            /// </summary>
			public Union<string, IntrinsicFunction> UserName { get; set; }

        }
    
        public string Type { get; } = "AWS::IAM::AccessKey";
        
        public AccessKeyProperties Properties { get; } = new AccessKeyProperties();
    }

	public static class AccessKeyAttributes
	{
        public static readonly ResourceAttribute<string> SecretAccessKey = new ResourceAttribute<string>("SecretAccessKey");
	}
}
