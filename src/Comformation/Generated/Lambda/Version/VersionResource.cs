using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.Version
{
    /// <summary>
    /// AWS::Lambda::Version
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-version.html
    /// </summary>
    public class VersionResource : ResourceBase
    {
        public class VersionProperties
        {
            /// <summary>
            /// CodeSha256
            /// Only publish a version if the hash value matches the value that&#39;s specified. Use this option to
            /// avoid publishing a version if the function code has changed since you last updated it. Updates are
            /// not supported for this property.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> CodeSha256 { get; set; }

            /// <summary>
            /// Description
            /// A description for the version to override the description in the function configuration. Updates are
            /// not supported for this property.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 256
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// FunctionName
            /// The name of the Lambda function.
            /// Name formats Function name - MyFunction. Function ARN -
            /// arn:aws:lambda:us-west-2:123456789012:function:MyFunction. Partial ARN -
            /// 123456789012:function:MyFunction.
            /// The length constraint applies only to the full ARN. If you specify only the function name, it is
            /// limited to 64 characters in length.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 140
            /// Pattern:
            /// (arn:(aws[a-zA-Z-]*)?:lambda:)?([a-z]{2}(-gov)?-[a-z]+-\d{1}:)?(\d{12}:)?(function:)?([a-zA-Z0-9-_]+)(:(\$LATEST|[a-zA-Z0-9-_]+))?
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> FunctionName { get; set; }

            /// <summary>
            /// ProvisionedConcurrencyConfig
            /// Specifies a provisioned concurrency configuration for a function&#39;s version. Updates are not
            /// supported for this property.
            /// Required: No
            /// Type: ProvisionedConcurrencyConfiguration
            /// Update requires: No interruption
            /// </summary>
            public ProvisionedConcurrencyConfiguration ProvisionedConcurrencyConfig { get; set; }

        }

        public string Type { get; } = "AWS::Lambda::Version";

        public VersionProperties Properties { get; } = new VersionProperties();

    }

    public static class VersionAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Version = new ResourceAttribute<Union<string, IntrinsicFunction>>("Version");
    }
}
