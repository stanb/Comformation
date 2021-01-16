using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTEvents.DetectorModel
{
    /// <summary>
    /// AWS::IoTEvents::DetectorModel IotSiteWise
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-iotsitewise.html
    /// </summary>
    public class IotSiteWise
    {

        /// <summary>
        /// EntryId
        /// A unique identifier for this entry. You can use the entry ID to track which data entry causes an
        /// error in case of failure. The default is a new unique identifier.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EntryId")]
        public Union<string, IntrinsicFunction> EntryId { get; set; }

        /// <summary>
        /// PropertyAlias
        /// The alias of the asset property.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PropertyAlias")]
        public Union<string, IntrinsicFunction> PropertyAlias { get; set; }

        /// <summary>
        /// PropertyValue
        /// The value to send to the asset property. This value contains timestamp, quality, and value (TQV)
        /// information.
        /// Required: No
        /// Type: AssetPropertyValue
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PropertyValue")]
        public AssetPropertyValue PropertyValue { get; set; }

        /// <summary>
        /// AssetId
        /// The ID of the asset that has the specified property.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AssetId")]
        public Union<string, IntrinsicFunction> AssetId { get; set; }

        /// <summary>
        /// PropertyId
        /// The ID of the asset property.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PropertyId")]
        public Union<string, IntrinsicFunction> PropertyId { get; set; }

    }
}
