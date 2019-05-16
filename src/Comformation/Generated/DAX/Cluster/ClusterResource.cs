using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DAX.Cluster
{
    /// <summary>
    /// AWS::DAX::Cluster
    /// Creates a DAX cluster. All nodes in the cluster run the same DAX caching software.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dax-cluster.html
    /// </summary>
    public class ClusterResource : ResourceBase
    {
        public class ClusterProperties
        {
            /// <summary>
            /// SSESpecification
            /// Represents the settings used to enable server-side encryption on the cluster.
            /// Required: No
            /// Type: SSESpecification
            /// Update requires: Replacement
            /// </summary>
			public SSESpecification SSESpecification { get; set; }

            /// <summary>
            /// Description
            /// The description of the cluster.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// ReplicationFactor
            /// The number of nodes in the DAX cluster. A replication factor of 1 will create a single-node cluster,
            /// without any read replicas. For additional fault tolerance, you can create a multiple node cluster
            /// with one or more read replicas. To do this, set ReplicationFactor to 2 or more.
            /// Note AWS recommends that you have at least two read replicas per cluster.
            /// Required: Yes
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
			public Union<int, IntrinsicFunction> ReplicationFactor { get; set; }

            /// <summary>
            /// ParameterGroupName
            /// The parameter group to be associated with the DAX cluster.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ParameterGroupName { get; set; }

            /// <summary>
            /// AvailabilityZones
            /// The Availability Zones (AZs) in which the cluster nodes will be created. All nodes belonging to the
            /// cluster are placed in these Availability Zones. Use this parameter if you want to distribute the
            /// nodes across multiple AZs.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> AvailabilityZones { get; set; }

            /// <summary>
            /// IAMRoleARN
            /// A valid Amazon Resource Name (ARN) that identifies an IAM role. At runtime, DAX will assume this
            /// role and use the role&#39;s permissions to access DynamoDB on your behalf.
            /// Note Updates are not supported for this property.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> IAMRoleARN { get; set; }

            /// <summary>
            /// SubnetGroupName
            /// The name of the subnet group to be used for the replication group.
            /// Important DAX clusters can only run in an Amazon VPC environment. All of the subnets that you
            /// specify in a subnet group must exist in the same VPC. Note Updates are not supported for this
            /// property.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SubnetGroupName { get; set; }

            /// <summary>
            /// PreferredMaintenanceWindow
            /// A range of time when maintenance of DAX cluster software will be performed. For example:
            /// sun:01:00-sun:09:00. Cluster maintenance normally takes less than 30 minutes, and is performed
            /// automatically within the maintenance window.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> PreferredMaintenanceWindow { get; set; }

            /// <summary>
            /// NotificationTopicARN
            /// The Amazon Resource Name (ARN) of the Amazon SNS topic to which notifications will be sent.
            /// Note The Amazon SNS topic owner must be same as the DAX cluster owner.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> NotificationTopicARN { get; set; }

            /// <summary>
            /// SecurityGroupIds
            /// A list of security group IDs to be assigned to each node in the DAX cluster. (Each of the security
            /// group ID is system-generated. )
            /// If this parameter is not specified, DAX assigns the default VPC security group to each node.
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
			public List<Union<string, IntrinsicFunction>> SecurityGroupIds { get; set; }

            /// <summary>
            /// NodeType
            /// The node type for the nodes in the cluster. (All nodes in a DAX cluster are of the same type. )
            /// Note Updates are not supported for this property.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> NodeType { get; set; }

            /// <summary>
            /// ClusterName
            /// The name of the DAX cluster.
            /// Note Updates are not supported for this property.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ClusterName { get; set; }

            /// <summary>
            /// Tags
            /// A set of tags to associate with the DAX cluster.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

        }

        public string Type { get; } = "AWS::DAX::Cluster";

        public ClusterProperties Properties { get; } = new ClusterProperties();

    }

	public static class ClusterAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> ClusterDiscoveryEndpoint = new ResourceAttribute<Union<string, IntrinsicFunction>>("ClusterDiscoveryEndpoint");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
	}
}
