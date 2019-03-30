using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppStream.Fleet
{
    /// <summary>
    /// AWS::AppStream::Fleet
    /// The AWS::AppStream::Fleet resource creates a fleet for Amazon AppStream 2. 0. A fleet consists of streaming
    /// instances that run a specified image. For more information, see CreateFleet in the Amazon AppStream 2. 0 API
    /// Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-fleet.html
    /// </summary>
    public class FleetResource : ResourceBase
    {
        public class FleetProperties
        {
            /// <summary>
            /// Description
            /// The description to display.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// ComputeCapacity
            /// The desired capacity for the fleet.
            /// Required: Yes
            /// Type: ComputeCapacity
            /// Update requires: No interruption
            /// </summary>
			public ComputeCapacity ComputeCapacity { get; set; }

            /// <summary>
            /// VpcConfig
            /// The VPC configuration for the fleet.
            /// Required: No
            /// Type: VpcConfig
            /// Update requires: No interruption
            /// </summary>
			public VpcConfig VpcConfig { get; set; }

            /// <summary>
            /// FleetType
            /// The fleet type.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> FleetType { get; set; }

            /// <summary>
            /// EnableDefaultInternetAccess
            /// Enables or disables default internet access for the fleet.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
			public Union<bool, IntrinsicFunction> EnableDefaultInternetAccess { get; set; }

            /// <summary>
            /// DomainJoinInfo
            /// The information needed to join a Microsoft Active Directory domain.
            /// Required: No
            /// Type: DomainJoinInfo
            /// Update requires: No interruption
            /// </summary>
			public DomainJoinInfo DomainJoinInfo { get; set; }

            /// <summary>
            /// Name
            /// A unique name for the fleet.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// ImageName
            /// The name of the image used to create the fleet.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ImageName { get; set; }

            /// <summary>
            /// MaxUserDurationInSeconds
            /// The maximum time that a streaming session can run, in seconds. Specify a value between 600 and
            /// 57600.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> MaxUserDurationInSeconds { get; set; }

            /// <summary>
            /// DisconnectTimeoutInSeconds
            /// The time after disconnection when a session is considered to have ended, in seconds. If a user who
            /// was disconnected reconnects within this time interval, the user is connected to their previous
            /// session. Specify a value between 60 and 57600.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> DisconnectTimeoutInSeconds { get; set; }

            /// <summary>
            /// DisplayName
            /// The fleet name to display.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DisplayName { get; set; }

            /// <summary>
            /// InstanceType
            /// The instance type to use when launching fleet instances.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceType { get; set; }

            /// <summary>
            /// Tags
            /// The tags for the fleet. Each tag specifies a key-value pair, and the value is optional. If you do
            /// not specify a value, it is set to an empty string (for example, Environment=).
            /// Required: No
            /// Type: List of Tag property types
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// ImageArn
            /// The ARN of the public, private, or shared image to use.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ImageArn { get; set; }

        }

        public string Type { get; } = "AWS::AppStream::Fleet";

        public FleetProperties Properties { get; } = new FleetProperties();

    }
}
