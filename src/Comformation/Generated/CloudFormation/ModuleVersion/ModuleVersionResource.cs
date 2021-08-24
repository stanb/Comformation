using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFormation.ModuleVersion
{
    /// <summary>
    /// AWS::CloudFormation::ModuleVersion
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-moduleversion.html
    /// </summary>
    public class ModuleVersionResource : ResourceBase
    {
        public class ModuleVersionProperties
        {
            /// <summary>
            /// ModuleName
            /// The name of the module being registered.
            /// Required: Yes
            /// Type: String
            /// Minimum: 10
            /// Maximum: 204
            /// Pattern: [A-Za-z0-9]{2,64}::[A-Za-z0-9]{2,64}::[A-Za-z0-9]{2,64}(::MODULE){0,1}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ModuleName { get; set; }

            /// <summary>
            /// ModulePackage
            /// A url to the S3 bucket containing the package that contains the template fragment and schema files
            /// for the module version to register.
            /// Note The user registering the module version must be able to access the the module package in the S3
            /// bucket. That is, the user needs to have GetObject permissions for the package. For more information,
            /// see Actions, Resources, and Condition Keys for Amazon S3 in the AWS Identity and Access Management
            /// User Guide.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 4096
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ModulePackage { get; set; }

        }

        public string Type { get; } = "AWS::CloudFormation::ModuleVersion";

        public ModuleVersionProperties Properties { get; } = new ModuleVersionProperties();

    }

    public static class ModuleVersionAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Description = new ResourceAttribute<Union<string, IntrinsicFunction>>("Description");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DocumentationUrl = new ResourceAttribute<Union<string, IntrinsicFunction>>("DocumentationUrl");
        public static readonly ResourceAttribute<Union<bool, IntrinsicFunction>> IsDefaultVersion = new ResourceAttribute<Union<bool, IntrinsicFunction>>("IsDefaultVersion");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Schema = new ResourceAttribute<Union<string, IntrinsicFunction>>("Schema");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> TimeCreated = new ResourceAttribute<Union<string, IntrinsicFunction>>("TimeCreated");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> VersionId = new ResourceAttribute<Union<string, IntrinsicFunction>>("VersionId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Visibility = new ResourceAttribute<Union<string, IntrinsicFunction>>("Visibility");
    }
}
