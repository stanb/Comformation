using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTWireless.TaskDefinition
{
    /// <summary>
    /// AWS::IoTWireless::TaskDefinition LoRaWANGatewayVersion
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-taskdefinition-lorawangatewayversion.html
    /// </summary>
    public class LoRaWANGatewayVersion
    {

        /// <summary>
        /// PackageVersion
        /// The version of the wireless gateway firmware.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PackageVersion")]
        public Union<string, IntrinsicFunction> PackageVersion { get; set; }

        /// <summary>
        /// Model
        /// The model number of the wireless gateway.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Model")]
        public Union<string, IntrinsicFunction> Model { get; set; }

        /// <summary>
        /// Station
        /// The basic station version of the wireless gateway.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Station")]
        public Union<string, IntrinsicFunction> Station { get; set; }

    }
}
