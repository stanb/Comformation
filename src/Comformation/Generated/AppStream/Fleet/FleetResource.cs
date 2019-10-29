using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppStream.Fleet
{
    /// <summary>
    /// AWS::AppStream::Fleet
    /// The AWS::AppStream::Fleet resource creates a fleet for Amazon AppStream 2. 0. A fleet consists of streaming
    /// instances that run a specified image.
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
            /// Maximum: 256
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
            /// ALWAYS_ON Provides users with instant-on access to their apps. You are charged for all running
            /// instances in your fleet, even if no users are streaming apps. ON_DEMAND Provide users with access to
            /// applications after they connect, which takes one to two minutes. You are charged for instance
            /// streaming when users are connected and a small hourly fee for instances that are not streaming apps.
            /// Required: No
            /// Type: String
            /// Allowed Values: ALWAYS_ON | ON_DEMAND
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
            /// The name of the directory and organizational unit (OU) to use to join the fleet to a Microsoft
            /// Active Directory domain.
            /// Required: No
            /// Type: DomainJoinInfo
            /// Update requires: No interruption
            /// </summary>
			public DomainJoinInfo DomainJoinInfo { get; set; }

            /// <summary>
            /// Name
            /// A unique name for the fleet.
            /// Required: No
            /// Type: String
            /// Pattern: ^[a-zA-Z0-9][a-zA-Z0-9_. -]{0,100}$
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// ImageName
            /// The name of the image used to create the fleet.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ImageName { get; set; }

            /// <summary>
            /// MaxUserDurationInSeconds
            /// The maximum amount of time that a streaming session can remain active, in seconds. If users are
            /// still connected to a streaming instance five minutes before this limit is reached, they are prompted
            /// to save any open documents before being disconnected. After this time elapses, the instance is
            /// terminated and replaced by a new instance.
            /// Specify a value between 600 and 360000.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> MaxUserDurationInSeconds { get; set; }

            /// <summary>
            /// IdleDisconnectTimeoutInSeconds
            /// The amount of time that users can be idle (inactive) before they are disconnected from their
            /// streaming session and the DisconnectTimeoutInSeconds time interval begins. Users are notified before
            /// they are disconnected due to inactivity. If they try to reconnect to the streaming session before
            /// the time interval specified in DisconnectTimeoutInSeconds elapses, they are connected to their
            /// previous session. Users are considered idle when they stop providing keyboard or mouse input during
            /// their streaming session. File uploads and downloads, audio in, audio out, and pixels changing do not
            /// qualify as user activity. If users continue to be idle after the time interval in
            /// IdleDisconnectTimeoutInSeconds elapses, they are disconnected.
            /// To prevent users from being disconnected due to inactivity, specify a value of 0. Otherwise, specify
            /// a value between 60 and 3600.
            /// Note If you enable this feature, we recommend that you specify a value that corresponds exactly to a
            /// whole number of minutes (for example, 60, 120, and 180). If you don&#39;t do this, the value is rounded
            /// to the nearest minute. For example, if you specify a value of 70, users are disconnected after 1
            /// minute of inactivity. If you specify a value that is at the midpoint between two different minutes,
            /// the value is rounded up. For example, if you specify a value of 90, users are disconnected after 2
            /// minutes of inactivity.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> IdleDisconnectTimeoutInSeconds { get; set; }

            /// <summary>
            /// DisconnectTimeoutInSeconds
            /// The amount of time that a streaming session remains active after users disconnect. If users try to
            /// reconnect to the streaming session after a disconnection or network interruption within this time
            /// interval, they are connected to their previous session. Otherwise, they are connected to a new
            /// session with a new streaming instance.
            /// Specify a value between 60 and 360000.
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
            /// Maximum: 100
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DisplayName { get; set; }

            /// <summary>
            /// InstanceType
            /// The instance type to use when launching fleet instances. The following instance types are available:
            /// stream. standard. medium stream. standard. large stream. compute. large stream. compute. xlarge
            /// stream. compute. 2xlarge stream. compute. 4xlarge stream. compute. 8xlarge stream. memory. large
            /// stream. memory. xlarge stream. memory. 2xlarge stream. memory. 4xlarge stream. memory. 8xlarge
            /// stream. graphics-design. large stream. graphics-design. xlarge stream. graphics-design. 2xlarge
            /// stream. graphics-design. 4xlarge stream. graphics-desktop. 2xlarge stream. graphics-pro. 4xlarge
            /// stream. graphics-pro. 8xlarge stream. graphics-pro. 16xlarge
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
            /// Pattern: ^arn:aws:[A-Za-z0-9][A-Za-z0-9_/. -]{0,62}:[A-Za-z0-9_/. -]{0,63}:[A-Za-z0-9_/.
            /// -]{0,63}:[A-Za-z0-9][A-Za-z0-9:_/+=,@. -]{0,1023}$
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ImageArn { get; set; }

        }

        public string Type { get; } = "AWS::AppStream::Fleet";

        public FleetProperties Properties { get; } = new FleetProperties();

    }
}
