using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancefleetconfig.html
    /// </summary>
    public class InstanceFleetConfig
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancefleetconfig.html#cfn-emr-cluster-instancefleetconfig-instancetypeconfigs
        /// </summary>
        [JsonProperty("InstanceTypeConfigs")]
        public Union<List<InstanceTypeConfig>, IntrinsicFunction> InstanceTypeConfigs { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancefleetconfig.html#cfn-emr-cluster-instancefleetconfig-launchspecifications
        /// </summary>
        [JsonProperty("LaunchSpecifications")]
        public Union<InstanceFleetProvisioningSpecifications, IntrinsicFunction> LaunchSpecifications { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancefleetconfig.html#cfn-emr-cluster-instancefleetconfig-name
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancefleetconfig.html#cfn-emr-cluster-instancefleetconfig-targetondemandcapacity
        /// </summary>
        [JsonProperty("TargetOnDemandCapacity")]
        public Union<int, IntrinsicFunction> TargetOnDemandCapacity { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancefleetconfig.html#cfn-emr-cluster-instancefleetconfig-targetspotcapacity
        /// </summary>
        [JsonProperty("TargetSpotCapacity")]
        public Union<int, IntrinsicFunction> TargetSpotCapacity { get; set; }

    }
}
