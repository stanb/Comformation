using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.DeliveryChannel
{
    /// <summary>
    /// AWS::Config::DeliveryChannel ConfigSnapshotDeliveryProperties
    /// Provides options for how often AWS Config delivers 			configuration snapshots to the Amazon S3 bucket in your
    /// delivery 			channel.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-config-deliverychannel-configsnapshotdeliveryproperties.html
    /// </summary>
    public class ConfigSnapshotDeliveryProperties
    {

        /// <summary>
        /// DeliveryFrequency
        /// 		
        /// The frequency with which AWS Config delivers configuration 			snapshots.
        /// 	
        /// Required: No
        /// Type: String
        /// Allowed Values: One_Hour | Six_Hours | Three_Hours | Twelve_Hours | TwentyFour_Hours
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeliveryFrequency")]
        public Union<string, IntrinsicFunction> DeliveryFrequency { get; set; }

    }
}
