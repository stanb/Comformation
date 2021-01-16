using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppStream.ImageBuilder
{
    /// <summary>
    /// AWS::AppStream::ImageBuilder
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-imagebuilder.html
    /// </summary>
    public class ImageBuilderResource : ResourceBase
    {
        public class ImageBuilderProperties
        {
            /// <summary>
            /// Description
            /// The description to display.
            /// Required: No
            /// Type: String
            /// Maximum: 256
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// VpcConfig
            /// The VPC configuration for the image builder. You can specify only one subnet.
            /// Required: No
            /// Type: VpcConfig
            /// Update requires: No interruption
            /// </summary>
            public VpcConfig VpcConfig { get; set; }

            /// <summary>
            /// EnableDefaultInternetAccess
            /// Enables or disables default internet access for the image builder.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> EnableDefaultInternetAccess { get; set; }

            /// <summary>
            /// DomainJoinInfo
            /// The name of the directory and organizational unit (OU) to use to join the image builder to a
            /// Microsoft Active Directory domain.
            /// Required: No
            /// Type: DomainJoinInfo
            /// Update requires: No interruption
            /// </summary>
            public DomainJoinInfo DomainJoinInfo { get; set; }

            /// <summary>
            /// AppstreamAgentVersion
            /// The version of the AppStream 2. 0 agent to use for this image builder. To use the latest version of
            /// the AppStream 2. 0 agent, specify [LATEST].
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AppstreamAgentVersion { get; set; }

            /// <summary>
            /// Name
            /// A unique name for the image builder.
            /// Required: Yes
            /// Type: String
            /// Pattern: ^[a-zA-Z0-9][a-zA-Z0-9_. -]{0,100}$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// ImageName
            /// The name of the image used to create the image builder.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ImageName { get; set; }

            /// <summary>
            /// DisplayName
            /// The image builder name to display.
            /// Required: No
            /// Type: String
            /// Maximum: 100
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DisplayName { get; set; }

            /// <summary>
            /// IamRoleArn
            /// The ARN of the IAM role that is applied to the image builder. To assume a role, the image builder
            /// calls the AWS Security Token Service (STS) AssumeRole API operation and passes the ARN of the role
            /// to use. The operation creates a new session with temporary credentials. AppStream 2. 0 retrieves the
            /// temporary credentials and creates the appstream_machine_role credential profile on the instance.
            /// For more information, see Using an IAM Role to Grant Permissions to Applications and Scripts Running
            /// on AppStream 2. 0 Streaming Instances in the Amazon AppStream 2. 0 Administration Guide.
            /// Required: No
            /// Type: String
            /// Pattern: ^arn:aws(?:\-cn|\-iso\-b|\-iso|\-us\-gov)?:[A-Za-z0-9][A-Za-z0-9_/. -]{0,62}:[A-Za-z0-9_/.
            /// -]{0,63}:[A-Za-z0-9_/. -]{0,63}:[A-Za-z0-9][A-Za-z0-9:_/+=,@. \\-]{0,1023}$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> IamRoleArn { get; set; }

            /// <summary>
            /// InstanceType
            /// The instance type to use when launching the image builder. The following instance types are
            /// available:
            /// stream. standard. small stream. standard. medium stream. standard. large stream. compute. large
            /// stream. compute. xlarge stream. compute. 2xlarge stream. compute. 4xlarge stream. compute. 8xlarge
            /// stream. memory. large stream. memory. xlarge stream. memory. 2xlarge stream. memory. 4xlarge stream.
            /// memory. 8xlarge stream. memory. z1d. large stream. memory. z1d. xlarge stream. memory. z1d. 2xlarge
            /// stream. memory. z1d. 3xlarge stream. memory. z1d. 6xlarge stream. memory. z1d. 12xlarge stream.
            /// graphics-design. large stream. graphics-design. xlarge stream. graphics-design. 2xlarge stream.
            /// graphics-design. 4xlarge stream. graphics-desktop. 2xlarge stream. graphics. g4dn. xlarge stream.
            /// graphics. g4dn. 2xlarge stream. graphics. g4dn. 4xlarge stream. graphics. g4dn. 8xlarge stream.
            /// graphics. g4dn. 12xlarge stream. graphics. g4dn. 16xlarge stream. graphics-pro. 4xlarge stream.
            /// graphics-pro. 8xlarge stream. graphics-pro. 16xlarge
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> InstanceType { get; set; }

            /// <summary>
            /// Tags
            /// An array of key-value pairs. For more information, see Using Cost Allocation Tags in the AWS Billing
            /// and Cost Management User Guide.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// ImageArn
            /// The ARN of the public, private, or shared image to use.
            /// Required: No
            /// Type: String
            /// Pattern: ^arn:aws(?:\-cn|\-iso\-b|\-iso|\-us\-gov)?:[A-Za-z0-9][A-Za-z0-9_/. -]{0,62}:[A-Za-z0-9_/.
            /// -]{0,63}:[A-Za-z0-9_/. -]{0,63}:[A-Za-z0-9][A-Za-z0-9:_/+=,@. \\-]{0,1023}$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ImageArn { get; set; }

            /// <summary>
            /// AccessEndpoints
            /// The list of virtual private cloud (VPC) interface endpoint objects. Administrators can connect to
            /// the image builder only through the specified endpoints.
            /// Required: No
            /// Type: List of AccessEndpoint
            /// Maximum: 4
            /// Update requires: No interruption
            /// </summary>
            public List<AccessEndpoint> AccessEndpoints { get; set; }

        }

        public string Type { get; } = "AWS::AppStream::ImageBuilder";

        public ImageBuilderProperties Properties { get; } = new ImageBuilderProperties();

    }

    public static class ImageBuilderAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> StreamingUrl = new ResourceAttribute<Union<string, IntrinsicFunction>>("StreamingUrl");
    }
}
