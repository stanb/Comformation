using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MSK.Cluster
{
    /// <summary>
    /// AWS::MSK::Cluster Firehose
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-cluster-firehose.html
    /// </summary>
    public class Firehose
    {

        /// <summary>
        /// DeliveryStream
        /// The Kinesis Data Firehose delivery stream that is the destination for broker logs.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeliveryStream")]
        public Union<string, IntrinsicFunction> DeliveryStream { get; set; }

        /// <summary>
        /// Enabled
        /// Specifies whether broker logs get sent to the specified Kinesis Data Firehose delivery stream.
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

    }
}
