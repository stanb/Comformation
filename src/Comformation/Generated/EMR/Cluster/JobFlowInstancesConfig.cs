using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// Amazon EMR Cluster JobFlowInstancesConfig
    /// Use theJobFlowInstancesConfig, which is a property of the AWS::EMR::Cluster resource, to configure the EC2
    /// instances (nodes) that will run jobs in an Amazon EMR cluster.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-jobflowinstancesconfig.html
    /// </summary>
    public class JobFlowInstancesConfig
    {

        /// <summary>
        /// AdditionalMasterSecurityGroups
        /// A list of additional EC2 security group IDs to assign to the master instance (master node) in your
        /// Amazon EMR cluster. Use this property to supplement the rules specified by the Amazon EMR managed
        /// master security group.
        /// Required: No
        /// Type: List of String values
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("AdditionalMasterSecurityGroups")]
        public List<Union<string, IntrinsicFunction>> AdditionalMasterSecurityGroups { get; set; }

        /// <summary>
        /// AdditionalSlaveSecurityGroups
        /// A list of additional EC2 security group IDs to assign to the slave instances (slave nodes) in your
        /// Amazon EMR cluster. Use this property to supplement the rules specified by the Amazon EMR managed
        /// slave security group.
        /// Required: No
        /// Type: List of String values
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("AdditionalSlaveSecurityGroups")]
        public List<Union<string, IntrinsicFunction>> AdditionalSlaveSecurityGroups { get; set; }

        /// <summary>
        /// CoreInstanceFleet
        /// The instance fleet settings for the core instances in your Amazon EMR cluster. Use this property
        /// with the MasterInstanceFleet property.
        /// Note The instance fleet configuration is available only in Amazon EMR versions 4. 8. 0 and later,
        /// excluding 5. 0. x versions.
        /// Required: No
        /// Type: Amazon EMR Cluster InstanceFleetConfig
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("CoreInstanceFleet")]
        public InstanceFleetConfig CoreInstanceFleet { get; set; }

        /// <summary>
        /// CoreInstanceGroup
        /// The settings for the core instances in your Amazon EMR cluster. Use this property with the
        /// MasterInstanceGroup property.
        /// Required: No
        /// Type: Amazon EMR Cluster InstanceGroupConfig
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("CoreInstanceGroup")]
        public InstanceGroupConfig CoreInstanceGroup { get; set; }

        /// <summary>
        /// Ec2KeyName
        /// The name of an Amazon Elastic Compute Cloud (Amazon EC2) key pair, which you can use to access the
        /// instances in your Amazon EMR cluster.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Ec2KeyName")]
        public Union<string, IntrinsicFunction> Ec2KeyName { get; set; }

        /// <summary>
        /// Ec2SubnetId
        /// The ID of the subnet where you want to launch your instances.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Ec2SubnetId")]
        public Union<string, IntrinsicFunction> Ec2SubnetId { get; set; }

        /// <summary>
        /// EmrManagedMasterSecurityGroup
        /// The ID of an EC2 security group (managed by Amazon EMR) that is assigned to the master instance
        /// (master node) in your Amazon EMR cluster.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("EmrManagedMasterSecurityGroup")]
        public Union<string, IntrinsicFunction> EmrManagedMasterSecurityGroup { get; set; }

        /// <summary>
        /// EmrManagedSlaveSecurityGroup
        /// The ID of an EC2 security group (managed by Amazon EMR) that is assigned to the slave instances
        /// (slave nodes) in your Amazon EMR cluster.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("EmrManagedSlaveSecurityGroup")]
        public Union<string, IntrinsicFunction> EmrManagedSlaveSecurityGroup { get; set; }

        /// <summary>
        /// HadoopVersion
        /// The Hadoop version for the job flow. For valid values, see the HadoopVersion parameter in the Amazon
        /// EMR API Reference.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("HadoopVersion")]
        public Union<string, IntrinsicFunction> HadoopVersion { get; set; }

        /// <summary>
        /// MasterInstanceFleet
        /// The instance fleet settings for the master instance (master node).
        /// Note The instance fleet configuration is available only in Amazon EMR versions 4. 8. 0 and later,
        /// excluding 5. 0. x versions.
        /// You must use either MasterInstanceFleet or MasterInstanceGroup in your configuration. If you use
        /// MasterInstanceFleet, then you may also specify the CoreInstanceFleet property.
        /// Required: No
        /// Type: Amazon EMR Cluster InstanceFleetConfig
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("MasterInstanceFleet")]
        public InstanceFleetConfig MasterInstanceFleet { get; set; }

        /// <summary>
        /// MasterInstanceGroup
        /// The settings for the master instance (master node).
        /// You must use either MasterInstanceGroup or MasterInstanceFleet in your configuration. If you use
        /// MasterInstanceGroup, then you may also specify the CoreInstanceGroup property.
        /// Required: No
        /// Type: Amazon EMR Cluster InstanceGroupConfig
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("MasterInstanceGroup")]
        public InstanceGroupConfig MasterInstanceGroup { get; set; }

        /// <summary>
        /// Placement
        /// The Availability Zone (AZ) in which the job flow runs.
        /// Required: No
        /// Type: Amazon EMR Cluster PlacementType
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Placement")]
        public PlacementType Placement { get; set; }

        /// <summary>
        /// ServiceAccessSecurityGroup
        /// The ID of the EC2 security group (managed by Amazon EMR) that services use to access clusters in
        /// private subnets.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ServiceAccessSecurityGroup")]
        public Union<string, IntrinsicFunction> ServiceAccessSecurityGroup { get; set; }

        /// <summary>
        /// TerminationProtected
        /// Indicates whether to prevent the EC2 instances from being terminated by an API call or user
        /// intervention. If you want to delete a stack with protected instances, update this value to false
        /// before you delete the stack. By default, AWS CloudFormation sets this property to false.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TerminationProtected")]
        public Union<bool, IntrinsicFunction> TerminationProtected { get; set; }

    }
}
