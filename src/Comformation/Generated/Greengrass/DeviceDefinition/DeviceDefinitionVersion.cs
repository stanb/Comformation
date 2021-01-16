using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Greengrass.DeviceDefinition
{
    /// <summary>
    /// AWS::Greengrass::DeviceDefinition DeviceDefinitionVersion
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-devicedefinition-devicedefinitionversion.html
    /// </summary>
    public class DeviceDefinitionVersion
    {

        /// <summary>
        /// Devices
        /// The devices in this version.
        /// Required: Yes
        /// Type: List of Device
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Devices")]
        public List<Device> Devices { get; set; }

    }
}
