using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancetypeconfig.html
    /// </summary>
    public class InstanceTypeConfig
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancetypeconfig.html#cfn-emr-cluster-instancetypeconfig-bidprice
        /// </summary>
        [JsonProperty("BidPrice")]
        public Union<string, IntrinsicFunction> BidPrice { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancetypeconfig.html#cfn-emr-cluster-instancetypeconfig-bidpriceaspercentageofondemandprice
        /// </summary>
        [JsonProperty("BidPriceAsPercentageOfOnDemandPrice")]
        public Union<double, IntrinsicFunction> BidPriceAsPercentageOfOnDemandPrice { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancetypeconfig.html#cfn-emr-cluster-instancetypeconfig-configurations
        /// </summary>
        [JsonProperty("Configurations")]
        public Union<List<Configuration>, IntrinsicFunction> Configurations { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancetypeconfig.html#cfn-emr-cluster-instancetypeconfig-ebsconfiguration
        /// </summary>
        [JsonProperty("EbsConfiguration")]
        public Union<EbsConfiguration, IntrinsicFunction> EbsConfiguration { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancetypeconfig.html#cfn-emr-cluster-instancetypeconfig-instancetype
        /// </summary>
        [JsonProperty("InstanceType")]
        public Union<string, IntrinsicFunction> InstanceType { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancetypeconfig.html#cfn-emr-cluster-instancetypeconfig-weightedcapacity
        /// </summary>
        [JsonProperty("WeightedCapacity")]
        public Union<int, IntrinsicFunction> WeightedCapacity { get; set; }

    }
}
