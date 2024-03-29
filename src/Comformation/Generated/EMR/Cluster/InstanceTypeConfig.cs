using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// AWS::EMR::Cluster InstanceTypeConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancetypeconfig.html
    /// </summary>
    public class InstanceTypeConfig
    {

        /// <summary>
        /// BidPrice
        /// The bid price for each EC2 Spot Instance type as defined by InstanceType. Expressed in USD. If
        /// neither BidPrice nor BidPriceAsPercentageOfOnDemandPrice is provided,
        /// BidPriceAsPercentageOfOnDemandPrice defaults to 100%.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 256
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("BidPrice")]
        public Union<string, IntrinsicFunction> BidPrice { get; set; }

        /// <summary>
        /// BidPriceAsPercentageOfOnDemandPrice
        /// The bid price, as a percentage of On-Demand price, for each EC2 Spot Instance as defined by
        /// InstanceType. Expressed as a number (for example, 20 specifies 20%). If neither BidPrice nor
        /// BidPriceAsPercentageOfOnDemandPrice is provided, BidPriceAsPercentageOfOnDemandPrice defaults to
        /// 100%.
        /// Required: No
        /// Type: Double
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("BidPriceAsPercentageOfOnDemandPrice")]
        public Union<double, IntrinsicFunction> BidPriceAsPercentageOfOnDemandPrice { get; set; }

        /// <summary>
        /// Configurations
        /// A configuration classification that applies when provisioning cluster instances, which can include
        /// configurations for applications and software that run on the cluster.
        /// Required: No
        /// Type: List of Configuration
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Configurations")]
        public List<Configuration> Configurations { get; set; }

        /// <summary>
        /// EbsConfiguration
        /// The configuration of Amazon Elastic Block Store (Amazon EBS) attached to each instance as defined by
        /// InstanceType.
        /// Required: No
        /// Type: EbsConfiguration
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("EbsConfiguration")]
        public EbsConfiguration EbsConfiguration { get; set; }

        /// <summary>
        /// InstanceType
        /// An EC2 instance type, such as m3. xlarge.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 256
        /// Pattern: [\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("InstanceType")]
        public Union<string, IntrinsicFunction> InstanceType { get; set; }

        /// <summary>
        /// WeightedCapacity
        /// The number of units that a provisioned instance of this type provides toward fulfilling the target
        /// capacities defined in InstanceFleetConfig. This value is 1 for a master instance fleet, and must be
        /// 1 or greater for core and task instance fleets. Defaults to 1 if not specified.
        /// Required: No
        /// Type: Integer
        /// Minimum: 0
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("WeightedCapacity")]
        public Union<int, IntrinsicFunction> WeightedCapacity { get; set; }

    }
}
