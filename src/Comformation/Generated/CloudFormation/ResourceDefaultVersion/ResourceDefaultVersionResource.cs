using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.CloudFormation.ResourceDefaultVersion
{
    /// <summary>
    /// AWS::CloudFormation::ResourceDefaultVersion
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudformation-resourcedefaultversion.html
    /// </summary>
    public class ResourceDefaultVersionResource : ResourceBase
    {
        public class ResourceDefaultVersionProperties
        {
            /// <summary>
            /// TypeVersionArn
            /// The Amazon Resource Name (ARN) of the resource version.
            /// Conditional: You must specify either TypeVersionArn, or TypeName and VersionId.
            /// Required: Conditional
            /// Type: String
            /// Maximum: 1024
            /// Pattern: arn:aws[A-Za-z0-9-]{0,64}:cloudformation:[A-Za-z0-9-]{1,64}:[0-9]{12}:type/. +
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> TypeVersionArn { get; set; }

            /// <summary>
            /// TypeName
            /// The name of the resource.
            /// Conditional: You must specify either TypeVersionArn, or TypeName and VersionId.
            /// Required: Conditional
            /// Type: String
            /// Minimum: 10
            /// Maximum: 204
            /// Pattern: [A-Za-z0-9]{2,64}::[A-Za-z0-9]{2,64}::[A-Za-z0-9]{2,64}(::MODULE){0,1}
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> TypeName { get; set; }

            /// <summary>
            /// VersionId
            /// The ID of a specific version of the resource. The version ID is the value at the end of the Amazon
            /// Resource Name (ARN) assigned to the resource version when it is registered.
            /// Conditional: You must specify either TypeVersionArn, or TypeName and VersionId.
            /// Required: Conditional
            /// Type: String
            /// Minimum: 1
            /// Maximum: 128
            /// Pattern: [A-Za-z0-9-]+
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> VersionId { get; set; }

        }

        public string Type { get; } = "AWS::CloudFormation::ResourceDefaultVersion";

        public ResourceDefaultVersionProperties Properties { get; } = new ResourceDefaultVersionProperties();

    }

    public static class ResourceDefaultVersionAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
