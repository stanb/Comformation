using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// AWS::EMR::Cluster JobFlowInstancesConfig
    /// JobFlowInstancesConfig is a property of the AWS::EMR::Cluster resource. JobFlowInstancesConfig defines the
    /// instance groups or instance fleets that comprise the cluster. JobFlowInstancesConfig must contain either
    /// InstanceFleetConfig or InstanceGroupConfig. They cannot be used together.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-jobflowinstancesconfig.html
    /// </summary>
    public class JobFlowInstancesConfig
    {

        /// <summary>
        /// AdditionalMasterSecurityGroups
        /// A list of additional Amazon EC2 security group IDs for the master node.
        /// Required: No
        /// Type: List of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("AdditionalMasterSecurityGroups")]
        public List<Union<string, IntrinsicFunction>> AdditionalMasterSecurityGroups { get; set; }

        /// <summary>
        /// AdditionalSlaveSecurityGroups
        /// A list of additional Amazon EC2 security group IDs for the core and task nodes.
        /// Required: No
        /// Type: List of String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("AdditionalSlaveSecurityGroups")]
        public List<Union<string, IntrinsicFunction>> AdditionalSlaveSecurityGroups { get; set; }

        /// <summary>
        /// CoreInstanceFleet
        /// Describes the EC2 instances and instance configurations for the core instance fleet when using
        /// clusters with the instance fleet configuration.
        /// Required: No
        /// Type: InstanceFleetConfig
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("CoreInstanceFleet")]
        public InstanceFleetConfig CoreInstanceFleet { get; set; }

        /// <summary>
        /// CoreInstanceGroup
        /// Describes the EC2 instances and instance configurations for core instance groups when using clusters
        /// with the uniform instance group configuration.
        /// Required: No
        /// Type: InstanceGroupConfig
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("CoreInstanceGroup")]
        public InstanceGroupConfig CoreInstanceGroup { get; set; }

        /// <summary>
        /// Ec2KeyName
        /// The name of the EC2 key pair that can be used to ssh to the master node as the user called &quot;hadoop.
        /// &quot;
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 256
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Ec2KeyName")]
        public Union<string, IntrinsicFunction> Ec2KeyName { get; set; }

        /// <summary>
        /// Ec2SubnetId
        /// Applies to clusters that use the uniform instance group configuration. To launch the cluster in
        /// Amazon Virtual Private Cloud (Amazon VPC), set this parameter to the identifier of the Amazon VPC
        /// subnet where you want the cluster to launch. If you do not specify this value, the cluster launches
        /// in the normal Amazon Web Services cloud, outside of an Amazon VPC, if the account launching the
        /// cluster supports EC2 Classic networks in the region where the cluster launches.
        /// Amazon VPC currently does not support cluster compute quadruple extra large (cc1. 4xlarge)
        /// instances. Thus you cannot specify the cc1. 4xlarge instance type for clusters launched in an Amazon
        /// VPC.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 256
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Ec2SubnetId")]
        public Union<string, IntrinsicFunction> Ec2SubnetId { get; set; }

        /// <summary>
        /// EmrManagedMasterSecurityGroup
        /// The identifier of the Amazon EC2 security group for the master node.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 256
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("EmrManagedMasterSecurityGroup")]
        public Union<string, IntrinsicFunction> EmrManagedMasterSecurityGroup { get; set; }

        /// <summary>
        /// EmrManagedSlaveSecurityGroup
        /// The identifier of the Amazon EC2 security group for the core and task nodes.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 256
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("EmrManagedSlaveSecurityGroup")]
        public Union<string, IntrinsicFunction> EmrManagedSlaveSecurityGroup { get; set; }

        /// <summary>
        /// HadoopVersion
        /// Applies only to Amazon EMR release versions earlier than 4. 0. The Hadoop version for the cluster.
        /// Valid inputs are &quot;0. 18&quot; (deprecated), &quot;0. 20&quot; (deprecated), &quot;0. 20. 205&quot; (deprecated), &quot;1. 0. 3&quot;,
        /// &quot;2. 2. 0&quot;, or &quot;2. 4. 0&quot;. If you do not set this value, the default of 0. 18 is used, unless the
        /// AmiVersion parameter is set in the RunJobFlow call, in which case the default version of Hadoop for
        /// that AMI version is used.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 256
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("HadoopVersion")]
        public Union<string, IntrinsicFunction> HadoopVersion { get; set; }

        /// <summary>
        /// KeepJobFlowAliveWhenNoSteps
        /// Specifies whether the cluster should remain available after completing all steps.
        /// Required: No
        /// Type: Boolean
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("KeepJobFlowAliveWhenNoSteps")]
        public Union<bool, IntrinsicFunction> KeepJobFlowAliveWhenNoSteps { get; set; }

        /// <summary>
        /// MasterInstanceFleet
        /// Describes the EC2 instances and instance configurations for the master instance fleet when using
        /// clusters with the instance fleet configuration.
        /// Required: No
        /// Type: InstanceFleetConfig
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("MasterInstanceFleet")]
        public InstanceFleetConfig MasterInstanceFleet { get; set; }

        /// <summary>
        /// MasterInstanceGroup
        /// Describes the EC2 instances and instance configurations for the master instance group when using
        /// clusters with the uniform instance group configuration.
        /// Required: No
        /// Type: InstanceGroupConfig
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("MasterInstanceGroup")]
        public InstanceGroupConfig MasterInstanceGroup { get; set; }

        /// <summary>
        /// Placement
        /// The Availability Zone in which the cluster runs.
        /// Required: No
        /// Type: PlacementType
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Placement")]
        public PlacementType Placement { get; set; }

        /// <summary>
        /// ServiceAccessSecurityGroup
        /// The identifier of the Amazon EC2 security group for the Amazon EMR service to access clusters in VPC
        /// private subnets.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 256
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("ServiceAccessSecurityGroup")]
        public Union<string, IntrinsicFunction> ServiceAccessSecurityGroup { get; set; }

        /// <summary>
        /// TerminationProtected
        /// Specifies whether to lock the cluster to prevent the Amazon EC2 instances from being terminated by
        /// API call, user intervention, or in the event of a job-flow error.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TerminationProtected")]
        public Union<bool, IntrinsicFunction> TerminationProtected { get; set; }

    }
}
