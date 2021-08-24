using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.GameLift.Fleet
{
    /// <summary>
    /// AWS::GameLift::Fleet
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-fleet.html
    /// </summary>
    public class FleetResource : ResourceBase
    {
        public class FleetProperties
        {
            /// <summary>
            /// CertificateConfiguration
            /// Indicates whether to generate a TLS/SSL certificate for the new fleet. TLS certificates are used for
            /// encrypting traffic between game clients and game servers running on GameLift. If this parameter is
            /// not set, certificate generation is disabled. This fleet setting cannot be changed once the fleet is
            /// created. Learn more at Securing Client/Server Communication.
            /// Note: This feature requires the AWS Certificate Manager service, which is available in the AWS
            /// global partition but not in all other partitions. When working in a partition that does not support
            /// this feature, a request for a new fleet with certificate generation results fails with a 4xx
            /// unsupported region error.
            /// Required: No
            /// Type: CertificateConfiguration
            /// Update requires: Replacement
            /// </summary>
            public CertificateConfiguration CertificateConfiguration { get; set; }

            /// <summary>
            /// Description
            /// A human-readable description of the fleet.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// DesiredEC2Instances
            /// The number of EC2 instances that you want this fleet to host. When creating a new fleet, GameLift
            /// automatically sets this value to &quot;1&quot; and initiates a single instance. Once the fleet is active,
            /// update this value to trigger GameLift to add or remove instances from the fleet.
            /// Required: No
            /// Type: Integer
            /// Minimum: 0
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> DesiredEC2Instances { get; set; }

            /// <summary>
            /// EC2InboundPermissions
            /// A range of IP addresses and port settings that allow inbound traffic to connect to server processes
            /// on an Amazon GameLift server.
            /// Required: No
            /// Type: List of IpPermission
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public List<IpPermission> EC2InboundPermissions { get; set; }

            /// <summary>
            /// EC2InstanceType
            /// The GameLift-supported Amazon EC2 instance type to use for all fleet instances. Instance type
            /// determines the computing resources that will be used to host your game servers, including CPU,
            /// memory, storage, and networking capacity. See Amazon Elastic Compute Cloud Instance Types for
            /// detailed descriptions of Amazon EC2 instance types.
            /// Required: No
            /// Type: String
            /// Allowed values: c3. 2xlarge | c3. 4xlarge | c3. 8xlarge | c3. large | c3. xlarge | c4. 2xlarge | c4.
            /// 4xlarge | c4. 8xlarge | c4. large | c4. xlarge | c5. 12xlarge | c5. 18xlarge | c5. 24xlarge | c5.
            /// 2xlarge | c5. 4xlarge | c5. 9xlarge | c5. large | c5. xlarge | c5a. 12xlarge | c5a. 16xlarge | c5a.
            /// 24xlarge | c5a. 2xlarge | c5a. 4xlarge | c5a. 8xlarge | c5a. large | c5a. xlarge | m3. 2xlarge | m3.
            /// large | m3. medium | m3. xlarge | m4. 10xlarge | m4. 2xlarge | m4. 4xlarge | m4. large | m4. xlarge
            /// | m5. 12xlarge | m5. 16xlarge | m5. 24xlarge | m5. 2xlarge | m5. 4xlarge | m5. 8xlarge | m5. large |
            /// m5. xlarge | m5a. 12xlarge | m5a. 16xlarge | m5a. 24xlarge | m5a. 2xlarge | m5a. 4xlarge | m5a.
            /// 8xlarge | m5a. large | m5a. xlarge | r3. 2xlarge | r3. 4xlarge | r3. 8xlarge | r3. large | r3.
            /// xlarge | r4. 16xlarge | r4. 2xlarge | r4. 4xlarge | r4. 8xlarge | r4. large | r4. xlarge | r5.
            /// 12xlarge | r5. 16xlarge | r5. 24xlarge | r5. 2xlarge | r5. 4xlarge | r5. 8xlarge | r5. large | r5.
            /// xlarge | r5a. 12xlarge | r5a. 16xlarge | r5a. 24xlarge | r5a. 2xlarge | r5a. 4xlarge | r5a. 8xlarge
            /// | r5a. large | r5a. xlarge | t2. large | t2. medium | t2. micro | t2. small
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> EC2InstanceType { get; set; }

            /// <summary>
            /// FleetType
            /// Indicates whether to use On-Demand or Spot instances for this fleet. By default, this property is
            /// set to ON_DEMAND. Learn more about when to use On-Demand versus Spot Instances. This property cannot
            /// be changed after the fleet is created.
            /// Required: No
            /// Type: String
            /// Allowed values: ON_DEMAND | SPOT
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> FleetType { get; set; }

            /// <summary>
            /// InstanceRoleARN
            /// A unique identifier for an IAM role that manages access to your AWS services. With an instance role
            /// ARN set, any application that runs on an instance in this fleet can assume the role, including
            /// install scripts, server processes, and daemons (background processes). Create a role or look up a
            /// role&#39;s ARN by using the IAM dashboard in the AWS Management Console. Learn more about using on-box
            /// credentials for your game servers at Access external resources from a game server. This property
            /// cannot be changed after the fleet is created.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> InstanceRoleARN { get; set; }

            /// <summary>
            /// Locations
            /// A set of remote locations to deploy additional instances to and manage as part of the fleet. This
            /// parameter can only be used when creating fleets in AWS Regions that support multiple locations. You
            /// can add any GameLift-supported AWS Region as a remote location, in the form of an AWS Region code
            /// such as us-west-2. To create a fleet with instances in the home Region only, omit this parameter.
            /// Required: No
            /// Type: List of LocationConfiguration
            /// Maximum: 100
            /// Update requires: No interruption
            /// </summary>
            public List<LocationConfiguration> Locations { get; set; }

            /// <summary>
            /// MaxSize
            /// The maximum value that is allowed for the fleet&#39;s instance count. When creating a new fleet,
            /// GameLift automatically sets this value to &quot;1&quot;. Once the fleet is active, you can change this value.
            /// Required: No
            /// Type: Integer
            /// Minimum: 0
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> MaxSize { get; set; }

            /// <summary>
            /// MetricGroups
            /// The name of an Amazon CloudWatch metric group. A metric group aggregates the metrics for all fleets
            /// in the group. Specify a string containing the metric group name. You can use an existing name or use
            /// a new name to create a new metric group. Currently, this parameter can have only one string.
            /// Required: No
            /// Type: List of String
            /// Maximum: 1
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> MetricGroups { get; set; }

            /// <summary>
            /// MinSize
            /// The minimum value allowed for the fleet&#39;s instance count. When creating a new fleet, GameLift
            /// automatically sets this value to &quot;0&quot;. After the fleet is active, you can change this value.
            /// Required: No
            /// Type: Integer
            /// Minimum: 0
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> MinSize { get; set; }

            /// <summary>
            /// Name
            /// A descriptive label that is associated with a fleet. Fleet names do not need to be unique.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// NewGameSessionProtectionPolicy
            /// A game session protection policy to apply to all game sessions hosted on instances in this fleet.
            /// When protected, active game sessions cannot be terminated during a scale-down event. If this
            /// parameter is not set, instances in this fleet default to no protection. You can change a fleet&#39;s
            /// protection policy to affect future game sessions on the fleet. You can also set protection for
            /// individual game sessions.
            /// Required: No
            /// Type: String
            /// Allowed values: FullProtection | NoProtection
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> NewGameSessionProtectionPolicy { get; set; }

            /// <summary>
            /// PeerVpcAwsAccountId
            /// Used when peering your GameLift fleet with a VPC, the unique identifier for the AWS account that
            /// owns the VPC. You can find your account ID in the AWS Management Console under account settings.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PeerVpcAwsAccountId { get; set; }

            /// <summary>
            /// PeerVpcId
            /// A unique identifier for a VPC with resources to be accessed by your GameLift fleet. The VPC must be
            /// in the same Region as your fleet. To look up a VPC ID, use the VPC Dashboard in the AWS Management
            /// Console. Learn more about VPC peering in VPC Peering with GameLift Fleets.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 1024
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PeerVpcId { get; set; }

            /// <summary>
            /// ResourceCreationLimitPolicy
            /// A policy that limits the number of game sessions that an individual player can create on instances
            /// in this fleet within a specified span of time.
            /// Required: No
            /// Type: ResourceCreationLimitPolicy
            /// Update requires: No interruption
            /// </summary>
            public ResourceCreationLimitPolicy ResourceCreationLimitPolicy { get; set; }

            /// <summary>
            /// BuildId
            /// A unique identifier for a build to be deployed on the new fleet. If you are deploying the fleet with
            /// a custom game build, you must specify this property. The build must have been successfully uploaded
            /// to Amazon GameLift and be in a READY status. This fleet setting cannot be changed once the fleet is
            /// created.
            /// Required: Conditional
            /// Type: String
            /// Pattern: ^build-\S+|^arn:. *:build\/build-\S+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> BuildId { get; set; }

            /// <summary>
            /// ScriptId
            /// A unique identifier for a Realtime script to be deployed on a new Realtime Servers fleet. The script
            /// must have been successfully uploaded to Amazon GameLift. This fleet setting cannot be changed once
            /// the fleet is created.
            /// Note: It is not currently possible to use the !Ref command to reference a script created with a
            /// CloudFormation template for the fleet property ScriptId. Instead, use Fn::GetAtt Script. Arn or
            /// Fn::GetAtt Script. Id to retrieve either of these properties as input for ScriptId. Alternatively,
            /// enter a ScriptId string manually.
            /// Required: Conditional
            /// Type: String
            /// Pattern: ^script-\S+|^arn:. *:script\/script-\S+
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ScriptId { get; set; }

            /// <summary>
            /// RuntimeConfiguration
            /// Instructions for launching server processes on each instance in the fleet. Server processes run
            /// either a custom game build executable or a Realtime script. The runtime configuration defines the
            /// server executables or launch script file, launch parameters, and the number of processes to run
            /// concurrently on each instance. When creating a fleet, the runtime configuration must have at least
            /// one server process configuration; otherwise the request fails with an invalid request exception.
            /// This parameter is required unless the parameters ServerLaunchPath and ServerLaunchParameters are
            /// defined. Runtime configuration has replaced these parameters, but fleets that use them will continue
            /// to work.
            /// Required: Conditional
            /// Type: RuntimeConfiguration
            /// Update requires: No interruption
            /// </summary>
            public RuntimeConfiguration RuntimeConfiguration { get; set; }

        }

        public string Type { get; } = "AWS::GameLift::Fleet";

        public FleetProperties Properties { get; } = new FleetProperties();

    }

    public static class FleetAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> FleetId = new ResourceAttribute<Union<string, IntrinsicFunction>>("FleetId");
    }
}
