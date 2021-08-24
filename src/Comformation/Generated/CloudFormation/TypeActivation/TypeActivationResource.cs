using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFormation.TypeActivation
{
    /// <summary>
    /// AWS::CloudFormation::TypeActivation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-typeactivation.html
    /// </summary>
    public class TypeActivationResource : ResourceBase
    {
        public class TypeActivationProperties
        {
            /// <summary>
            /// ExecutionRoleArn
            /// The name of the IAM execution role to use to activate the extension.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Pattern: arn:. +:iam::[0-9]{12}:role/. +
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ExecutionRoleArn { get; set; }

            /// <summary>
            /// PublisherId
            /// The ID of the extension publisher.
            /// Conditional: You must specify PublicTypeArn, or TypeName, Type, and PublisherId.
            /// Required: Conditional
            /// Type: String
            /// Minimum: 1
            /// Maximum: 40
            /// Pattern: [0-9a-zA-Z]{12,40}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PublisherId { get; set; }

            /// <summary>
            /// LoggingConfig
            /// Specifies logging configuration information for an extension.
            /// Required: No
            /// Type: LoggingConfig
            /// Update requires: Replacement
            /// </summary>
            public LoggingConfig LoggingConfig { get; set; }

            /// <summary>
            /// PublicTypeArn
            /// The Amazon Resource Number (ARN) of the public extension.
            /// Conditional: You must specify PublicTypeArn, or TypeName, Type, and PublisherId.
            /// Required: Conditional
            /// Type: String
            /// Maximum: 1024
            /// Pattern: arn:aws[A-Za-z0-9-]{0,64}:cloudformation:[A-Za-z0-9-]{1,64}::type/. +/[0-9a-zA-Z]{12,40}/.
            /// +
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PublicTypeArn { get; set; }

            /// <summary>
            /// AutoUpdate
            /// Whether to automatically update the extension in this account and region when a new minor version is
            /// published by the extension publisher. Major versions released by the publisher must be manually
            /// updated.
            /// The default is true.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> AutoUpdate { get; set; }

            /// <summary>
            /// TypeNameAlias
            /// An alias to assign to the public extension, in this account and region. If you specify an alias for
            /// the extension, CloudFormation treats the alias as the extension type name within this account and
            /// region. You must use the alias to refer to the extension in your templates, API calls, and
            /// CloudFormation console.
            /// An extension alias must be unique within a given account and region. You can activate the same
            /// public resource multiple times in the same account and region, using different type name aliases.
            /// Required: No
            /// Type: String
            /// Minimum: 10
            /// Maximum: 204
            /// Pattern: [A-Za-z0-9]{2,64}::[A-Za-z0-9]{2,64}::[A-Za-z0-9]{2,64}(::MODULE){0,1}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TypeNameAlias { get; set; }

            /// <summary>
            /// VersionBump
            /// Manually updates a previously-activated type to a new major or minor version, if available. You can
            /// also use this parameter to update the value of AutoUpdate.
            /// MAJOR: CloudFormation updates the extension to the newest major version, if one is available. MINOR:
            /// CloudFormation updates the extension to the newest minor version, if one is available.
            /// Required: No
            /// Type: String
            /// Allowed values: MAJOR | MINOR
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> VersionBump { get; set; }

            /// <summary>
            /// MajorVersion
            /// The major version of this extension you want to activate, if multiple major versions are available.
            /// The default is the latest major version. CloudFormation uses the latest available minor version of
            /// the major version selected.
            /// You can specify MajorVersion or VersionBump, but not both.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> MajorVersion { get; set; }

            /// <summary>
            /// TypeName
            /// The name of the extension.
            /// Conditional: You must specify PublicTypeArn, or TypeName, Type, and PublisherId.
            /// Required: Conditional
            /// Type: String
            /// Minimum: 10
            /// Maximum: 204
            /// Pattern: [A-Za-z0-9]{2,64}::[A-Za-z0-9]{2,64}::[A-Za-z0-9]{2,64}(::MODULE){0,1}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TypeName { get; set; }

            /// <summary>
            /// Type
            /// The extension type.
            /// Conditional: You must specify PublicTypeArn, or TypeName, Type, and PublisherId.
            /// Required: Conditional
            /// Type: String
            /// Allowed values: MODULE | RESOURCE
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Type { get; set; }

        }

        public string Type { get; } = "AWS::CloudFormation::TypeActivation";

        public TypeActivationProperties Properties { get; } = new TypeActivationProperties();

    }

    public static class TypeActivationAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
