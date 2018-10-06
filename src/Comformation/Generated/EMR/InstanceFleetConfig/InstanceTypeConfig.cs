using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.InstanceFleetConfig
{
    /// <summary>
    /// Amazon EMR InstanceFleetConfig InstanceTypeConfig
    /// Use the InstanceTypeConfig property to configure each instance type in an instance fleet. This configuration
    /// determines which EC2 instances that Amazon EMR attempts to provision to fulfill On-Demand and Spot target
    /// capacities. You can configure a maximum of five instance types in a fleet. For a list of InstanceTypeConfig
    /// property types, see the InstanceTypeConfigs property of the AWS::EMR::InstanceFleetConfig resource.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-instancetypeconfig.html
    /// </summary>
    public class InstanceTypeConfig
    {

        /// <summary>
        /// BidPrice
        /// The bid price for each EC2 Spot Instance type as defined by InstanceType. BidPrice is expressed in
        /// USD. For more information, see InstanceTypeConfig in the Amazon EMR API Reference.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("BidPrice")]
        public Union<string, IntrinsicFunction> BidPrice { get; set; }

        /// <summary>
        /// BidPriceAsPercentageOfOnDemandPrice
        /// The bid price, as a percentage of the On-Demand price, for each EC2 Spot Instance as defined by
        /// InstanceType. BidPriceAsPercentageOfOnDemandPrice is expressed as a number. For more information,
        /// see InstanceTypeConfig in the Amazon EMR API Reference.
        /// Required: No
        /// Type: Double
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("BidPriceAsPercentageOfOnDemandPrice")]
        public Union<double, IntrinsicFunction> BidPriceAsPercentageOfOnDemandPrice { get; set; }

        /// <summary>
        /// Configurations
        /// A configuration classification that applies when provisioning cluster instances. You can use this
        /// property to configure applications and software that run on the cluster. Duplicates are not allowed.
        /// Required: No
        /// Type: List of Amazon EMR InstanceFleetConfig Configuration
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Configurations")]
        public List<Configuration> Configurations { get; set; }

        /// <summary>
        /// EbsConfiguration
        /// The configuration of Amazon Elastic Block Store (Amazon EBS) that is attached to each instance as
        /// defined by InstanceType.
        /// Required: No
        /// Type: Amazon EMR InstanceFleetConfig EbsConfiguration
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("EbsConfiguration")]
        public EbsConfiguration EbsConfiguration { get; set; }

        /// <summary>
        /// InstanceType
        /// An EC2 instance type, such as m3. xlarge. For constraints, see InstanceTypeConfig in the Amazon EMR
        /// API Reference.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("InstanceType")]
        public Union<string, IntrinsicFunction> InstanceType { get; set; }

        /// <summary>
        /// WeightedCapacity
        /// The number of units that a provisioned instance of this type provides toward fulfilling the target
        /// capacities defined in InstanceFleetConfig. For more information, see InstanceTypeConfig in the
        /// Amazon EMR API Reference.
        /// Required: No
        /// Type: Integer
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("WeightedCapacity")]
        public Union<int, IntrinsicFunction> WeightedCapacity { get; set; }

    }
}
