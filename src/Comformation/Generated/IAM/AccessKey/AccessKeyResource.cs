using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IAM.AccessKey
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-accesskey.html
    /// </summary>
    public class AccessKeyResource : ResourceBase
    {
        public class AccessKeyProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-accesskey.html#cfn-iam-accesskey-serial
            /// </summary>
			public Union<int, IntrinsicFunction> Serial { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-accesskey.html#cfn-iam-accesskey-status
            /// </summary>
			public Union<string, IntrinsicFunction> Status { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-accesskey.html#cfn-iam-accesskey-username
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
