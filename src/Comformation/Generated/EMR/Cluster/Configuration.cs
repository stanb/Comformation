using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-configuration.html
    /// </summary>
    public class Configuration
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-configuration.html#cfn-emr-cluster-configuration-classification
        /// </summary>
        [JsonProperty("Classification")]
        public Union<string, IntrinsicFunction> Classification { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-configuration.html#cfn-emr-cluster-configuration-configurationproperties
        /// </summary>
        [JsonProperty("ConfigurationProperties")]
        public Union<Dictionary<string, string>, IntrinsicFunction> ConfigurationProperties { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-configuration.html#cfn-emr-cluster-configuration-configurations
        /// </summary>
        [JsonProperty("Configurations")]
        public Union<List<Configuration>, IntrinsicFunction> Configurations { get; set; }

    }
}
