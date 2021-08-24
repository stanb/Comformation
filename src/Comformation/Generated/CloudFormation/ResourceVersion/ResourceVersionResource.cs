using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFormation.ResourceVersion
{
    /// <summary>
    /// AWS::CloudFormation::ResourceVersion
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-resourceversion.html
    /// </summary>
    public class ResourceVersionResource : ResourceBase
    {
        public class ResourceVersionProperties
        {
            /// <summary>
            /// ExecutionRoleArn
            /// The Amazon Resource Name (ARN) of the IAM role for CloudFormation to assume when invoking the
            /// resource. If your resource calls AWS APIs in any of its handlers, you must create an IAM execution
            /// role that includes the necessary permissions to call those AWS APIs, and provision that execution
            /// role in your account. When CloudFormation needs to invoke the resource type handler, CloudFormation
            /// assumes this execution role to create a temporary session token, which it then passes to the
            /// resource type handler, thereby supplying your resource type with the appropriate credentials.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Pattern: arn:. +:iam::[0-9]{12}:role/. +
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ExecutionRoleArn { get; set; }

            /// <summary>
            /// LoggingConfig
            /// Logging configuration information for a resource.
            /// Required: No
            /// Type: LoggingConfig
            /// Update requires: Replacement
            /// </summary>
            public LoggingConfig LoggingConfig { get; set; }

            /// <summary>
            /// SchemaHandlerPackage
            /// A url to the S3 bucket containing the resource project package that contains the neccessary files
            /// for the resource you want to register.
            /// For information on generating a schema handler package for the resource you want to register, see
            /// submit in the CloudFormation CLI User Guide.
            /// Note The user registering the resource must be able to access the package in the S3 bucket. That is,
            /// the user needs to have GetObject permissions for the schema handler package. For more information,
            /// see Actions, Resources, and Condition Keys for Amazon S3 in the AWS Identity and Access Management
            /// User Guide.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 4096
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SchemaHandlerPackage { get; set; }

            /// <summary>
            /// TypeName
            /// The name of the resource being registered.
            /// We recommend that resource names adhere to the following pattern:
            /// company_or_organization::service::type.
            /// Note The following organization namespaces are reserved and cannot be used in your resource names:
            /// Alexa AMZN Amazon AWS Custom Dev
            /// Required: Yes
            /// Type: String
            /// Minimum: 10
            /// Maximum: 204
            /// Pattern: [A-Za-z0-9]{2,64}::[A-Za-z0-9]{2,64}::[A-Za-z0-9]{2,64}(::MODULE){0,1}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TypeName { get; set; }

        }

        public string Type { get; } = "AWS::CloudFormation::ResourceVersion";

        public ResourceVersionProperties Properties { get; } = new ResourceVersionProperties();

    }

    public static class ResourceVersionAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> TypeArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("TypeArn");
        public static readonly ResourceAttribute<Union<bool, IntrinsicFunction>> IsDefaultVersion = new ResourceAttribute<Union<bool, IntrinsicFunction>>("IsDefaultVersion");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ProvisioningType = new ResourceAttribute<Union<string, IntrinsicFunction>>("ProvisioningType");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> VersionId = new ResourceAttribute<Union<string, IntrinsicFunction>>("VersionId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Visibility = new ResourceAttribute<Union<string, IntrinsicFunction>>("Visibility");
    }
}
