using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.DeliveryChannel
{
    /// <summary>
    /// AWS Config DeliveryChannel ConfigSnapshotDeliveryProperties
    /// ConfigSnapshotDeliveryProperties is a property of the AWS::Config::DeliveryChannel resource that specifies how
    /// AWS Config delivers configuration snapshots to the S3 bucket in your delivery channel.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-deliverychannel-configsnapshotdeliveryproperties.html
    /// </summary>
    public class ConfigSnapshotDeliveryProperties
    {

        /// <summary>
        /// DeliveryFrequency
        /// The frequency with which AWS Config delivers configuration snapshots. For valid values, see
        /// ConfigSnapshotDeliveryProperties in the AWS Config API Reference.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("DeliveryFrequency")]
        public Union<string, IntrinsicFunction> DeliveryFrequency { get; set; }

    }
}
