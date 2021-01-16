using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFormation.ModuleDefaultVersion
{
    /// <summary>
    /// AWS::CloudFormation::ModuleDefaultVersion
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-moduledefaultversion.html
    /// </summary>
    public class ModuleDefaultVersionResource : ResourceBase
    {
        public class ModuleDefaultVersionProperties
        {
            /// <summary>
            /// Arn
            /// The Amazon Resource Name (ARN) of the module version to set as the default version.
            /// Conditional: You must specify either Arn, or ModuleName and VersionId.
            /// Required: Conditional
            /// Type: String
            /// Maximum: 1024
            /// Pattern: arn:aws[A-Za-z0-9-]{0,64}:cloudformation:[A-Za-z0-9-]{1,64}:[0-9]{12}:type/. +
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Arn { get; set; }

            /// <summary>
            /// ModuleName
            /// The name of the module.
            /// Conditional: You must specify either Arn, or ModuleName and VersionId.
            /// Required: Conditional
            /// Type: String
            /// Minimum: 10
            /// Maximum: 204
            /// Pattern: [A-Za-z0-9]{2,64}::[A-Za-z0-9]{2,64}::[A-Za-z0-9]{2,64}(::MODULE){0,1}
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ModuleName { get; set; }

            /// <summary>
            /// VersionId
            /// The ID for the specific version of the module.
            /// Conditional: You must specify either Arn, or ModuleName and VersionId.
            /// Required: Conditional
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: [A-Za-z0-9-]+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> VersionId { get; set; }

        }

        public string Type { get; } = "AWS::CloudFormation::ModuleDefaultVersion";

        public ModuleDefaultVersionProperties Properties { get; } = new ModuleDefaultVersionProperties();

    }
}
