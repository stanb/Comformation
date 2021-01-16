using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTWireless.ServiceProfile
{
    /// <summary>
    /// AWS::IoTWireless::ServiceProfile LoRaWANServiceProfile
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-serviceprofile-lorawanserviceprofile.html
    /// </summary>
    public class LoRaWANServiceProfile
    {

        /// <summary>
        /// AddGwMetadata
        /// The AddGWMetaData value.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AddGwMetadata")]
        public Union<bool, IntrinsicFunction> AddGwMetadata { get; set; }

    }
}
