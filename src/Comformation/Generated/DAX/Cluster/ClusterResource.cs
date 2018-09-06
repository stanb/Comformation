using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DAX.Cluster
{
    /// <summary>
    /// AWS::DAX::Cluster
    /// Use the AWS::DAX::Cluster resource to create a DAX cluster for use with Amazon DynamoDB.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dax-cluster.html
    /// </summary>
    public class ClusterResource : ResourceBase
    {
        public class ClusterProperties
        {
            /// <summary>
            /// SSESpecification
            /// Whether server-side encryption is enabled or not.
            /// Required: No
            /// Type: DAX Cluster SSESpecification
            /// Update requires: Replacement
            /// </summary>
			public Union<SSESpecification, IntrinsicFunction> SSESpecification { get; set; }

            /// <summary>
            /// Description
            /// A description of the cluster.
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
            /// Update requires: Some interruptions
            /// </summary>
			public Union<int, IntrinsicFunction> ReplicationFactor { get; set; }

            /// <summary>
            /// ParameterGroupName
            /// The parameter group to be associated with the DAX cluster.
            /// Required: No
            /// Type: String
            /// Update requires: Some interruptions
            /// </summary>
			public Union<string, IntrinsicFunction> ParameterGroupName { get; set; }

            /// <summary>
            /// AvailabilityZones
            /// The Availability Zones (AZs) in which the cluster nodes will be created. All nodes belonging to the
            /// cluster are placed in these Availability Zones. Use this parameter if you want to distribute the
            /// nodes across multiple AZs.
            /// You must specify one AZ per DAX node in the cluster.
            /// Required: No
            /// Type: List of String values
            /// Update requires: Some interruptions
            /// </summary>
			public Union<List<string>, IntrinsicFunction> AvailabilityZones { get; set; }

            /// <summary>
            /// IAMRoleARN
            /// A valid Amazon Resource Name (ARN) that identifies an IAM role. At runtime, DAX will assume this
            /// role and use the role&#39;s permissions to access DynamoDB on your behalf.
            /// Required: Yes
            /// Type: String
            /// Update requires: Updates are not supported.
            /// </summary>
			public Union<string, IntrinsicFunction> IAMRoleARN { get; set; }

            /// <summary>
            /// SubnetGroupName
            /// The name of the subnet group to be used for the replication group.
            /// Important DAX clusters can only run in an Amazon VPC environment. All of the subnets that you
            /// specify in a subnet group must exist in the same VPC.
            /// Required: Yes
            /// Type: String
            /// Update requires: Updates are not supported.
            /// </summary>
			public Union<string, IntrinsicFunction> SubnetGroupName { get; set; }

            /// <summary>
            /// PreferredMaintenanceWindow
            /// Specifies the weekly time range during which maintenance on the DAX cluster is performed. It is
            /// specified as a range in the format ddd:hh24:mi-ddd:hh24:mi (24H Clock UTC). The minimum maintenance
            /// window is a 60 minute period. Valid values for ddd are:
            /// sun mon tue wed thu fri sat
            /// Example: sun:05:00-sun:09:00
            /// Note If you don&#39;t specify a preferred maintenance window when you create or modify a cache cluster,
            /// DAX assigns a 60-minute maintenance window on a randomly selected day of the week.
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
            /// Type: List of String values
            /// Update requires: No interruption
            /// </summary>
			public Union<List<string>, IntrinsicFunction> SecurityGroupIds { get; set; }

            /// <summary>
            /// NodeType
            /// The compute and memory capacity of the nodes in the cluster.
            /// Required: Yes
            /// Type: String
            /// Update requires: Updates are not supported.
            /// </summary>
			public Union<string, IntrinsicFunction> NodeType { get; set; }

            /// <summary>
            /// ClusterName
            /// The cluster identifier. This parameter is stored as a lowercase string.
            /// Required: No
            /// Type: String
            /// Update requires: Updates are not supported.
            /// </summary>
			public Union<string, IntrinsicFunction> ClusterName { get; set; }

            /// <summary>
            /// Tags
            /// A map of tags to associate with the DAX cluster.
            /// Required: No
            /// Type: String to String map
            /// Update requires: No interruption
            /// </summary>
			public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

        }
    
        public string Type { get; } = "AWS::DAX::Cluster";
        
        public ClusterProperties Properties { get; } = new ClusterProperties();
    }

	public static class ClusterAttributes
	{
        public static readonly ResourceAttribute<string> ClusterDiscoveryEndpoint = new ResourceAttribute<string>("ClusterDiscoveryEndpoint");
        public static readonly ResourceAttribute<string> Arn = new ResourceAttribute<string>("Arn");
	}
}
