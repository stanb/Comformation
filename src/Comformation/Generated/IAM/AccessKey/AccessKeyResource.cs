using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IAM.AccessKey
{
    /// <summary>
    /// AWS::IAM::AccessKey
    /// Creates a new AWS secret access key and corresponding AWS access key ID for the specified user. The default
    /// status for new keys is Active.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-accesskey.html
    /// </summary>
    public class AccessKeyResource : ResourceBase
    {
        public class AccessKeyProperties
        {
            /// <summary>
            /// Serial
            /// This value is specific to CloudFormation and can only be incremented. Incrementing this value
            /// notifies CloudFormation that you want to rotate your access key. When you update your stack,
            /// CloudFormation will replace the existing access key with a new key.
            /// Required: No
            /// Type: Integer
            /// Update requires: Replacement
            /// </summary>
			public Union<int, IntrinsicFunction> Serial { get; set; }

            /// <summary>
            /// Status
            /// The status of the access key. Active means that the key is valid for API calls, while Inactive means
            /// it is not.
            /// Required: No
            /// Type: String
            /// Allowed Values: Active | Inactive
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Status { get; set; }

            /// <summary>
            /// UserName
            /// The name of the IAM user that the new key will belong to.
            /// This parameter allows (through its regex pattern) a string of characters consisting of upper and
            /// lowercase alphanumeric characters with no spaces. You can also include any of the following
            /// characters: _+=,. @-
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: [\w+=,. @-]+
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> UserName { get; set; }

        }

        public string Type { get; } = "AWS::IAM::AccessKey";

        public AccessKeyProperties Properties { get; } = new AccessKeyProperties();

    }

	public static class AccessKeyAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> SecretAccessKey = new ResourceAttribute<Union<string, IntrinsicFunction>>("SecretAccessKey");
	}
}
