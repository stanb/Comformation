using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS::IoT::TopicRule PutAssetPropertyValueEntry
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-putassetpropertyvalueentry.html
    /// </summary>
    public class PutAssetPropertyValueEntry
    {

        /// <summary>
        /// AssetId
        /// The ID of the AWS IoT SiteWise asset. You must specify either a propertyAlias or both an aliasId and
        /// a propertyId. Accepts substitution templates.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AssetId")]
        public Union<string, IntrinsicFunction> AssetId { get; set; }

        /// <summary>
        /// EntryId
        /// Optional. A unique identifier for this entry that you can define to better track which message
        /// caused an error in case of failure. Accepts substitution templates. Defaults to a new UUID.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EntryId")]
        public Union<string, IntrinsicFunction> EntryId { get; set; }

        /// <summary>
        /// PropertyAlias
        /// The name of the property alias associated with your asset property. You must specify either a
        /// propertyAlias or both an aliasId and a propertyId. Accepts substitution templates.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PropertyAlias")]
        public Union<string, IntrinsicFunction> PropertyAlias { get; set; }

        /// <summary>
        /// PropertyId
        /// The ID of the asset&#39;s property. You must specify either a propertyAlias or both an aliasId and a
        /// propertyId. Accepts substitution templates.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PropertyId")]
        public Union<string, IntrinsicFunction> PropertyId { get; set; }

        /// <summary>
        /// PropertyValues
        /// A list of property values to insert that each contain timestamp, quality, and value (TQV)
        /// information.
        /// Required: Yes
        /// Type: List of AssetPropertyValue
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PropertyValues")]
        public List<AssetPropertyValue> PropertyValues { get; set; }

    }
}
