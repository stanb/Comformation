using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EKS.Cluster
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-resourcesvpcconfig.html
    /// </summary>
    public class ResourcesVpcConfig
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-resourcesvpcconfig.html#cfn-eks-cluster-resourcesvpcconfig-securitygroupids
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public Union<List<string>, IntrinsicFunction> SecurityGroupIds { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-resourcesvpcconfig.html#cfn-eks-cluster-resourcesvpcconfig-subnetids
        /// </summary>
        [JsonProperty("SubnetIds")]
        public Union<List<string>, IntrinsicFunction> SubnetIds { get; set; }

    }
}
