using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTSiteWise.Asset
{
    /// <summary>
    /// AWS::IoTSiteWise::Asset AssetProperty
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-asset-assetproperty.html
    /// </summary>
    public class AssetProperty
    {

        /// <summary>
        /// LogicalId
        /// The LogicalID of the asset property.
        /// The maximum length is 256 characters, with the pattern [^\u0000-\u001F\u007F]+.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LogicalId")]
        public Union<string, IntrinsicFunction> LogicalId { get; set; }

        /// <summary>
        /// Alias
        /// The property alias that identifies the property, such as an OPC-UA server data stream path (for
        /// example, /company/windfarm/3/turbine/7/temperature). For more information, see Mapping industrial
        /// data streams to asset properties in the AWS IoT SiteWise User Guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Alias")]
        public Union<string, IntrinsicFunction> Alias { get; set; }

        /// <summary>
        /// NotificationState
        /// The MQTT notification state (enabled or disabled) for this asset property. When the notification
        /// state is enabled, AWS IoT SiteWise publishes property value updates to a unique MQTT topic. For more
        /// information, see Interacting with other services in the AWS IoT SiteWise User Guide.
        /// If you omit this parameter, the notification state is set to DISABLED.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("NotificationState")]
        public Union<string, IntrinsicFunction> NotificationState { get; set; }

    }
}
