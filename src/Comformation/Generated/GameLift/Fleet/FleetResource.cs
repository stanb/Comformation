using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GameLift.Fleet
{
    /// <summary>
    /// AWS::GameLift::Fleet
    /// The AWS::GameLift::Fleet resource creates an Amazon GameLift (GameLift) fleet to host game servers. A fleet is
    /// a set of EC2 instances, each of which is a host in the fleet. For more information, see the CreateFleet action
    /// in the Amazon GameLift API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-fleet.html
    /// </summary>
    public class FleetResource : ResourceBase
    {
        public class FleetProperties
        {
            /// <summary>
            /// BuildId
            /// Unique identifier for a build to be deployed on the new fleet. The custom game server build must
            /// have been successfully uploaded to Amazon GameLift and be in a READY status. This fleet setting
            /// cannot be changed once the fleet is created.
            /// Required: Yes
            /// Type: String
            /// Pattern: ^build-\S+
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> BuildId { get; set; }

            /// <summary>
            /// Description
            /// Human-readable description of a fleet.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// DesiredEC2Instances
            /// Number of EC2 instances you want this fleet to host.
            /// Required: Yes
            /// Type: Integer
            /// Minimum: 0
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> DesiredEC2Instances { get; set; }

            /// <summary>
            /// EC2InboundPermissions
            /// Range of IP addresses and port settings that permit inbound traffic to access game sessions that
            /// running on the fleet. For fleets using a custom game build, this parameter is required before game
            /// sessions running on the fleet can accept connections. For Realtime Servers fleets, Amazon GameLift
            /// automatically sets TCP and UDP ranges for use by the Realtime servers. You can specify multiple
            /// permission settings or add more by updating the fleet.
            /// Required: No
            /// Type: List of IpPermission
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
			public List<IpPermission> EC2InboundPermissions { get; set; }

            /// <summary>
            /// EC2InstanceType
            /// Name of an EC2 instance type that is supported in Amazon GameLift. A fleet instance type determines
            /// the computing resources of each instance in the fleet, including CPU, memory, storage, and
            /// networking capacity. For more information about the instance types that are supported by GameLift,
            /// see the EC2InstanceType parameter in the Amazon GameLift API Reference.
            /// Required: Yes
            /// Type: String
            /// Allowed Values: c3. 2xlarge | c3. 4xlarge | c3. 8xlarge | c3. large | c3. xlarge | c4. 2xlarge | c4.
            /// 4xlarge | c4. 8xlarge | c4. large | c4. xlarge | c5. 12xlarge | c5. 18xlarge | c5. 24xlarge | c5.
            /// 2xlarge | c5. 4xlarge | c5. 9xlarge | c5. large | c5. xlarge | m3. 2xlarge | m3. large | m3. medium
            /// | m3. xlarge | m4. 10xlarge | m4. 2xlarge | m4. 4xlarge | m4. large | m4. xlarge | m5. 12xlarge |
            /// m5. 16xlarge | m5. 24xlarge | m5. 2xlarge | m5. 4xlarge | m5. 8xlarge | m5. large | m5. xlarge | r3.
            /// 2xlarge | r3. 4xlarge | r3. 8xlarge | r3. large | r3. xlarge | r4. 16xlarge | r4. 2xlarge | r4.
            /// 4xlarge | r4. 8xlarge | r4. large | r4. xlarge | r5. 12xlarge | r5. 16xlarge | r5. 24xlarge | r5.
            /// 2xlarge | r5. 4xlarge | r5. 8xlarge | r5. large | r5. xlarge | t2. large | t2. medium | t2. micro |
            /// t2. small
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> EC2InstanceType { get; set; }

            /// <summary>
            /// LogPaths
            /// This parameter is no longer used. Instead, to specify where Amazon GameLift should store log files
            /// once a server process shuts down, use the Amazon GameLift server API ProcessReady() and specify one
            /// or more directory paths in logParameters. See more information in the Server API Reference.
            /// Required: No
            /// Type: List of String
            /// Update requires: Replacement
            /// </summary>
			public List<Union<string, IntrinsicFunction>> LogPaths { get; set; }

            /// <summary>
            /// MaxSize
            /// Maximum value allowed for the fleet&#39;s instance count. Default if not set is 1.
            /// Required: No
            /// Type: Integer
            /// Minimum: 0
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> MaxSize { get; set; }

            /// <summary>
            /// MinSize
            /// Minimum value allowed for the fleet&#39;s instance count. Default if not set is 0.
            /// Required: No
            /// Type: Integer
            /// Minimum: 0
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> MinSize { get; set; }

            /// <summary>
            /// Name
            /// Descriptive label that is associated with a fleet. Fleet names do not need to be unique.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// ServerLaunchParameters
            /// The parameters that are required to launch your game server. Specify these parameters as a string of
            /// command-line parameters, such as +sv_port 33435 +start_lobby.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ServerLaunchParameters { get; set; }

            /// <summary>
            /// ServerLaunchPath
            /// The location of your game server that GameLift launches. You must escape the slashes (\) and use the
            /// following pattern: C:\\game\\launchpath. For example, if your game server files are in the MyGame
            /// folder, the path should be C:\\game\\MyGame\\server. exe.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ServerLaunchPath { get; set; }

        }

        public string Type { get; } = "AWS::GameLift::Fleet";

        public FleetProperties Properties { get; } = new FleetProperties();

    }
}
