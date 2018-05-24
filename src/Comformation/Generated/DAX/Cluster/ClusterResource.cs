using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.DAX.Cluster
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dax-cluster.html
    /// </summary>
    public class ClusterResource : ResourceBase
    {
        public class ClusterProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dax-cluster.html#cfn-dax-cluster-description
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dax-cluster.html#cfn-dax-cluster-replicationfactor
            /// </summary>
			public Union<int, IntrinsicFunction> ReplicationFactor { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dax-cluster.html#cfn-dax-cluster-parametergroupname
            /// </summary>
			public Union<string, IntrinsicFunction> ParameterGroupName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dax-cluster.html#cfn-dax-cluster-availabilityzones
            /// </summary>
			public Union<List<string>, IntrinsicFunction> AvailabilityZones { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dax-cluster.html#cfn-dax-cluster-nodetype
            /// </summary>
			public Union<string, IntrinsicFunction> NodeType { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dax-cluster.html#cfn-dax-cluster-iamrolearn
            /// </summary>
			public Union<string, IntrinsicFunction> IAMRoleARN { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dax-cluster.html#cfn-dax-cluster-subnetgroupname
            /// </summary>
			public Union<string, IntrinsicFunction> SubnetGroupName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dax-cluster.html#cfn-dax-cluster-clustername
            /// </summary>
			public Union<string, IntrinsicFunction> ClusterName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dax-cluster.html#cfn-dax-cluster-preferredmaintenancewindow
            /// </summary>
			public Union<string, IntrinsicFunction> PreferredMaintenanceWindow { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dax-cluster.html#cfn-dax-cluster-notificationtopicarn
            /// </summary>
			public Union<string, IntrinsicFunction> NotificationTopicARN { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dax-cluster.html#cfn-dax-cluster-securitygroupids
            /// </summary>
			public Union<List<string>, IntrinsicFunction> SecurityGroupIds { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dax-cluster.html#cfn-dax-cluster-tags
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
