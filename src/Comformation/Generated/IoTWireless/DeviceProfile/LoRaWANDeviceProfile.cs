using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTWireless.DeviceProfile
{
    /// <summary>
    /// AWS::IoTWireless::DeviceProfile LoRaWANDeviceProfile
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-deviceprofile-lorawandeviceprofile.html
    /// </summary>
    public class LoRaWANDeviceProfile
    {

        /// <summary>
        /// SupportsClassB
        /// The SupportsClassB value.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SupportsClassB")]
        public Union<bool, IntrinsicFunction> SupportsClassB { get; set; }

        /// <summary>
        /// ClassBTimeout
        /// The ClassBTimeout value.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ClassBTimeout")]
        public Union<int, IntrinsicFunction> ClassBTimeout { get; set; }

        /// <summary>
        /// PingSlotPeriod
        /// The PingSlotPeriod value.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PingSlotPeriod")]
        public Union<int, IntrinsicFunction> PingSlotPeriod { get; set; }

        /// <summary>
        /// PingSlotDr
        /// The PingSlotDR value.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PingSlotDr")]
        public Union<int, IntrinsicFunction> PingSlotDr { get; set; }

        /// <summary>
        /// PingSlotFreq
        /// The PingSlotFreq value.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PingSlotFreq")]
        public Union<int, IntrinsicFunction> PingSlotFreq { get; set; }

        /// <summary>
        /// SupportsClassC
        /// The SupportsClassC value.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SupportsClassC")]
        public Union<bool, IntrinsicFunction> SupportsClassC { get; set; }

        /// <summary>
        /// ClassCTimeout
        /// The ClassCTimeout value.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ClassCTimeout")]
        public Union<int, IntrinsicFunction> ClassCTimeout { get; set; }

        /// <summary>
        /// MacVersion
        /// The MAC version (such as OTAA 1. 1 or OTAA 1. 0. 3) to use with this device profile.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MacVersion")]
        public Union<string, IntrinsicFunction> MacVersion { get; set; }

        /// <summary>
        /// RegParamsRevision
        /// The version of regional parameters.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RegParamsRevision")]
        public Union<string, IntrinsicFunction> RegParamsRevision { get; set; }

        /// <summary>
        /// MaxEirp
        /// The MaxEIRP value.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxEirp")]
        public Union<int, IntrinsicFunction> MaxEirp { get; set; }

        /// <summary>
        /// MaxDutyCycle
        /// The MaxDutyCycle value.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxDutyCycle")]
        public Union<int, IntrinsicFunction> MaxDutyCycle { get; set; }

        /// <summary>
        /// SupportsJoin
        /// The SupportsJoin value.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SupportsJoin")]
        public Union<bool, IntrinsicFunction> SupportsJoin { get; set; }

        /// <summary>
        /// RfRegion
        /// The frequency band (RFRegion) value.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RfRegion")]
        public Union<string, IntrinsicFunction> RfRegion { get; set; }

        /// <summary>
        /// Supports32BitFCnt
        /// The Supports32BitFCnt value.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Supports32BitFCnt")]
        public Union<bool, IntrinsicFunction> Supports32BitFCnt { get; set; }

    }
}
