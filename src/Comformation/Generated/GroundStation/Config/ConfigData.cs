using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.GroundStation.Config
{
    /// <summary>
    /// AWS::GroundStation::Config ConfigData
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-config-configdata.html
    /// </summary>
    public class ConfigData
    {

        /// <summary>
        /// AntennaDownlinkConfig
        /// Provides information for an antenna downlink config object. Antenna downlink config objects are used
        /// to provide parameters for downlinks where no demodulation or decoding is performed by Ground Station
        /// (RF over IP downlinks).
        /// Required: No
        /// Type: AntennaDownlinkConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AntennaDownlinkConfig")]
        public AntennaDownlinkConfig AntennaDownlinkConfig { get; set; }

        /// <summary>
        /// TrackingConfig
        /// Provides information for a tracking config object. Tracking config objects are used to provide
        /// parameters about how to track the satellite through the sky during a contact.
        /// Required: No
        /// Type: TrackingConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TrackingConfig")]
        public TrackingConfig TrackingConfig { get; set; }

        /// <summary>
        /// DataflowEndpointConfig
        /// Provides information for a dataflow endpoint config object. Dataflow endpoint config objects are
        /// used to provide parameters about which IP endpoint(s) to use during a contact. Dataflow endpoints
        /// are where Ground Station sends data during a downlink contact and where Ground Station receives data
        /// to send to the satellite during an uplink contact.
        /// Required: No
        /// Type: DataflowEndpointConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataflowEndpointConfig")]
        public DataflowEndpointConfig DataflowEndpointConfig { get; set; }

        /// <summary>
        /// AntennaDownlinkDemodDecodeConfig
        /// Provides information for a downlink demod decode config object. Downlink demod decode config objects
        /// are used to provide parameters for downlinks where the Ground Station service will demodulate and
        /// decode the downlinked data.
        /// Required: No
        /// Type: AntennaDownlinkDemodDecodeConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AntennaDownlinkDemodDecodeConfig")]
        public AntennaDownlinkDemodDecodeConfig AntennaDownlinkDemodDecodeConfig { get; set; }

        /// <summary>
        /// AntennaUplinkConfig
        /// Provides information for an uplink config object. Uplink config objects are used to provide
        /// parameters for uplink contacts.
        /// Required: No
        /// Type: AntennaUplinkConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AntennaUplinkConfig")]
        public AntennaUplinkConfig AntennaUplinkConfig { get; set; }

        /// <summary>
        /// UplinkEchoConfig
        /// Provides information for an uplink echo config object. Uplink echo config objects are used to
        /// provide parameters for uplink echo during uplink contacts.
        /// Required: No
        /// Type: UplinkEchoConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UplinkEchoConfig")]
        public UplinkEchoConfig UplinkEchoConfig { get; set; }

        /// <summary>
        /// S3RecordingConfig
        /// Provides information for an S3 recording config object. S3 recording config objects are used to
        /// provide parameters for S3 recording during downlink contacts.
        /// Required: No
        /// Type: S3RecordingConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3RecordingConfig")]
        public S3RecordingConfig S3RecordingConfig { get; set; }

    }
}
