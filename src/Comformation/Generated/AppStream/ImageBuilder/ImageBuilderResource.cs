using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppStream.ImageBuilder
{
    /// <summary>
    /// AWS::AppStream::ImageBuilder
    /// The AWS::AppStream::ImageBuilder resource creates an image builder for Amazon AppStream 2. 0. An image builder
    /// is a virtual machine that is used to create an image. For more information, see CreateImageBuilder in the
    /// Amazon AppStream 2. 0 API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-imagebuilder.html
    /// </summary>
    public class ImageBuilderResource : ResourceBase
    {
        public class ImageBuilderProperties
        {
            /// <summary>
            /// ImageName
            /// The name of the image used to create the image builder.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ImageName { get; set; }

            /// <summary>
            /// Description
            /// The description to display.
            /// Required: No
            /// Type: String
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
            /// DisplayName
            /// The image builder name to display.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DisplayName { get; set; }

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
            /// The version of the Amazon AppStream 2. 0 agent to use for this image builder. To use the latest
            /// version of the agent, specify [LATEST].
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> AppstreamAgentVersion { get; set; }

            /// <summary>
            /// InstanceType
            /// The instance type to use when launching the image builder.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceType { get; set; }

            /// <summary>
            /// Name
            /// A unique name for the image builder.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// ImageArn
            /// The ARN of the public, private, or shared image to use.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ImageArn { get; set; }

        }

        public string Type { get; } = "AWS::AppStream::ImageBuilder";

        public ImageBuilderProperties Properties { get; } = new ImageBuilderProperties();

    }

	public static class ImageBuilderAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> StreamingUrl = new ResourceAttribute<Union<string, IntrinsicFunction>>("StreamingUrl");
	}
}
