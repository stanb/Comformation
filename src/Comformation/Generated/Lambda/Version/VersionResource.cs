using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.Version
{
    /// <summary>
    /// AWS::Lambda::Version
    /// The AWS::Lambda::Version resource publishes a specified version of an AWS Lambda (Lambda) function. When
    /// publishing a new version of your function, Lambda copies the latest version of your function. For more
    /// information, see Introduction to AWS Lambda Versioning in the AWS Lambda Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-version.html
    /// </summary>
    public class VersionResource : ResourceBase
    {
        public class VersionProperties
        {
            /// <summary>
            /// CodeSha256
            /// The SHA-256 hash of the deployment package that you want to publish. This value must match the
            /// SHA-256 hash of the $LATEST version of the function. Specify this property to validate that you are
            /// publishing the correct package.
            /// Required: No
            /// Type: String
            /// Update requires: Updates are not supported.
            /// </summary>
			public Union<string, IntrinsicFunction> CodeSha256 { get; set; }

            /// <summary>
            /// Description
            /// A description of the version you are publishing. If you don&#39;t specify a value, Lambda copies the
            /// description from the $LATEST version of the function.
            /// Required: No
            /// Type: String
            /// Update requires: Updates are not supported.
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// FunctionName
            /// The Lambda function for which you want to publish a version. You can specify the function&#39;s name or
            /// its Amazon Resource Name (ARN).
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> FunctionName { get; set; }

        }

        public string Type { get; } = "AWS::Lambda::Version";

        public VersionProperties Properties { get; } = new VersionProperties();

    }

	public static class VersionAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Version = new ResourceAttribute<Union<string, IntrinsicFunction>>("Version");
	}
}
