using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.EMR.Cluster
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-spotprovisioningspecification.html
    /// </summary>
    public class SpotProvisioningSpecification
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-spotprovisioningspecification.html#cfn-emr-cluster-spotprovisioningspecification-blockdurationminutes
        /// </summary>
        [JsonProperty("BlockDurationMinutes")]
        public Union<int, IntrinsicFunction> BlockDurationMinutes { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-spotprovisioningspecification.html#cfn-emr-cluster-spotprovisioningspecification-timeoutaction
        /// </summary>
        [JsonProperty("TimeoutAction")]
        public Union<string, IntrinsicFunction> TimeoutAction { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-spotprovisioningspecification.html#cfn-emr-cluster-spotprovisioningspecification-timeoutdurationminutes
        /// </summary>
        [JsonProperty("TimeoutDurationMinutes")]
        public Union<int, IntrinsicFunction> TimeoutDurationMinutes { get; set; }

    }
}
