using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS::IoT::TopicRule IotSiteWiseAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-iotsitewiseaction.html
    /// </summary>
    public class IotSiteWiseAction
    {

        /// <summary>
        /// RoleArn
        /// The ARN of the role that grants AWS IoT permission to send an asset property value to AWS IoT
        /// SiteWise. (&quot;Action&quot;: &quot;iotsitewise:BatchPutAssetPropertyValue&quot;). The trust policy can restrict access
        /// to specific asset hierarchy paths.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// PutAssetPropertyValueEntries
        /// A list of asset property value entries.
        /// Required: Yes
        /// Type: List of PutAssetPropertyValueEntry
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PutAssetPropertyValueEntries")]
        public List<PutAssetPropertyValueEntry> PutAssetPropertyValueEntries { get; set; }

    }
}
