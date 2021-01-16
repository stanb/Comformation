using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Config.DeliveryChannel
{
    /// <summary>
    /// AWS::Config::DeliveryChannel ConfigSnapshotDeliveryProperties
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
        /// Allowed values: One_Hour | Six_Hours | Three_Hours | Twelve_Hours | TwentyFour_Hours
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeliveryFrequency")]
        public Union<string, IntrinsicFunction> DeliveryFrequency { get; set; }

    }
}
