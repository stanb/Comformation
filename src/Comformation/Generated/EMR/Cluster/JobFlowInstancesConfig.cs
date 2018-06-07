using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-jobflowinstancesconfig.html
    /// </summary>
    public class JobFlowInstancesConfig
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-jobflowinstancesconfig.html#cfn-emr-cluster-jobflowinstancesconfig-additionalmastersecuritygroups
        /// </summary>
        [JsonProperty("AdditionalMasterSecurityGroups")]
        public Union<List<string>, IntrinsicFunction> AdditionalMasterSecurityGroups { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-jobflowinstancesconfig.html#cfn-emr-cluster-jobflowinstancesconfig-additionalslavesecuritygroups
        /// </summary>
        [JsonProperty("AdditionalSlaveSecurityGroups")]
        public Union<List<string>, IntrinsicFunction> AdditionalSlaveSecurityGroups { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-jobflowinstancesconfig.html#cfn-emr-cluster-jobflowinstancesconfig-coreinstancefleet
        /// </summary>
        [JsonProperty("CoreInstanceFleet")]
        public Union<InstanceFleetConfig, IntrinsicFunction> CoreInstanceFleet { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-jobflowinstancesconfig.html#cfn-emr-cluster-jobflowinstancesconfig-coreinstancegroup
        /// </summary>
        [JsonProperty("CoreInstanceGroup")]
        public Union<InstanceGroupConfig, IntrinsicFunction> CoreInstanceGroup { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-jobflowinstancesconfig.html#cfn-emr-cluster-jobflowinstancesconfig-ec2keyname
        /// </summary>
        [JsonProperty("Ec2KeyName")]
        public Union<string, IntrinsicFunction> Ec2KeyName { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-jobflowinstancesconfig.html#cfn-emr-cluster-jobflowinstancesconfig-ec2subnetid
        /// </summary>
        [JsonProperty("Ec2SubnetId")]
        public Union<string, IntrinsicFunction> Ec2SubnetId { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-jobflowinstancesconfig.html#cfn-emr-cluster-jobflowinstancesconfig-emrmanagedmastersecuritygroup
        /// </summary>
        [JsonProperty("EmrManagedMasterSecurityGroup")]
        public Union<string, IntrinsicFunction> EmrManagedMasterSecurityGroup { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-jobflowinstancesconfig.html#cfn-emr-cluster-jobflowinstancesconfig-emrmanagedslavesecuritygroup
        /// </summary>
        [JsonProperty("EmrManagedSlaveSecurityGroup")]
        public Union<string, IntrinsicFunction> EmrManagedSlaveSecurityGroup { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-jobflowinstancesconfig.html#cfn-emr-cluster-jobflowinstancesconfig-hadoopversion
        /// </summary>
        [JsonProperty("HadoopVersion")]
        public Union<string, IntrinsicFunction> HadoopVersion { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-jobflowinstancesconfig.html#cfn-emr-cluster-jobflowinstancesconfig-masterinstancefleet
        /// </summary>
        [JsonProperty("MasterInstanceFleet")]
        public Union<InstanceFleetConfig, IntrinsicFunction> MasterInstanceFleet { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-jobflowinstancesconfig.html#cfn-emr-cluster-jobflowinstancesconfig-masterinstancegroup
        /// </summary>
        [JsonProperty("MasterInstanceGroup")]
        public Union<InstanceGroupConfig, IntrinsicFunction> MasterInstanceGroup { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-jobflowinstancesconfig.html#cfn-emr-cluster-jobflowinstancesconfig-placement
        /// </summary>
        [JsonProperty("Placement")]
        public Union<PlacementType, IntrinsicFunction> Placement { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-jobflowinstancesconfig.html#cfn-emr-cluster-jobflowinstancesconfig-serviceaccesssecuritygroup
        /// </summary>
        [JsonProperty("ServiceAccessSecurityGroup")]
        public Union<string, IntrinsicFunction> ServiceAccessSecurityGroup { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-jobflowinstancesconfig.html#cfn-emr-cluster-jobflowinstancesconfig-terminationprotected
        /// </summary>
        [JsonProperty("TerminationProtected")]
        public Union<bool, IntrinsicFunction> TerminationProtected { get; set; }

    }
}
