using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Studio
{
    /// <summary>
    /// AWS::EMR::Studio
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-studio.html
    /// </summary>
    public class StudioResource : ResourceBase
    {
        public class StudioProperties
        {
            /// <summary>
            /// AuthMode
            /// Specifies whether the Studio authenticates users using single sign-on (SSO) or IAM. Amazon EMR
            /// Studio currently only supports SSO authentication.
            /// Required: Yes
            /// Type: String
            /// Allowed values: IAM | SSO
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> AuthMode { get; set; }

            /// <summary>
            /// DefaultS3Location
            /// The Amazon S3 location to back up EMR Studio Workspaces and notebook files.
            /// Required: Yes
            /// Type: String
            /// Minimum: 0
            /// Maximum: 10280
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DefaultS3Location { get; set; }

            /// <summary>
            /// Description
            /// A detailed description of the Amazon EMR Studio.
            /// Required: No
            /// Type: String
            /// Minimum: 0
            /// Maximum: 256
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// EngineSecurityGroupId
            /// The ID of the Amazon EMR Studio Engine security group. The Engine security group allows inbound
            /// network traffic from the Workspace security group, and it must be in the same VPC specified by
            /// VpcId.
            /// Required: Yes
            /// Type: String
            /// Minimum: 0
            /// Maximum: 256
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> EngineSecurityGroupId { get; set; }

            /// <summary>
            /// Name
            /// A descriptive name for the Amazon EMR Studio.
            /// Required: Yes
            /// Type: String
            /// Minimum: 0
            /// Maximum: 256
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// ServiceRole
            /// The Amazon Resource Name (ARN) of the IAM role that will be assumed by the Amazon EMR Studio. The
            /// service role provides a way for Amazon EMR Studio to interoperate with other AWS services.
            /// Required: Yes
            /// Type: String
            /// Minimum: 0
            /// Maximum: 10280
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ServiceRole { get; set; }

            /// <summary>
            /// SubnetIds
            /// A list of subnet IDs to associate with the Amazon EMR Studio. A Studio can have a maximum of 5
            /// subnets. The subnets must belong to the VPC specified by VpcId. Studio users can create a Workspace
            /// in any of the specified subnets.
            /// Required: Yes
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> SubnetIds { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs to apply to this resource.
            /// For more information, see Tag.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// UserRole
            /// The Amazon Resource Name (ARN) of the IAM user role that will be assumed by users and groups logged
            /// in to a Studio. The permissions attached to this IAM role can be scoped down for each user or group
            /// using session policies.
            /// Required: Yes
            /// Type: String
            /// Minimum: 0
            /// Maximum: 10280
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> UserRole { get; set; }

            /// <summary>
            /// VpcId
            /// The ID of the Amazon Virtual Private Cloud (Amazon VPC) to associate with the Studio.
            /// Required: Yes
            /// Type: String
            /// Minimum: 0
            /// Maximum: 256
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> VpcId { get; set; }

            /// <summary>
            /// WorkspaceSecurityGroupId
            /// The ID of the Workspace security group associated with the Amazon EMR Studio. The Workspace security
            /// group allows outbound network traffic to resources in the Engine security group and to the internet.
            /// Required: Yes
            /// Type: String
            /// Minimum: 0
            /// Maximum: 256
            /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> WorkspaceSecurityGroupId { get; set; }

        }

        public string Type { get; } = "AWS::EMR::Studio";

        public StudioProperties Properties { get; } = new StudioProperties();

    }

    public static class StudioAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> StudioId = new ResourceAttribute<Union<string, IntrinsicFunction>>("StudioId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Url = new ResourceAttribute<Union<string, IntrinsicFunction>>("Url");
    }
}
