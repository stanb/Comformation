using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    /// AWS::EMR::Cluster OnDemandProvisioningSpecification
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-ondemandprovisioningspecification.html
    /// </summary>
    public class OnDemandProvisioningSpecification
    {

        /// <summary>
        /// AllocationStrategy
        /// Specifies the strategy to use in launching On-Demand Instance fleets. Currently, the only option is
        /// lowest-price (the default), which launches the lowest price first.
        /// Required: Yes
        /// Type: String
        /// Allowed values: lowest-price
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AllocationStrategy")]
        public Union<string, IntrinsicFunction> AllocationStrategy { get; set; }

    }
}
