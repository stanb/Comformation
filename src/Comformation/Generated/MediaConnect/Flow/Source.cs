using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaConnect.Flow
{
    /// <summary>
    /// AWS::MediaConnect::Flow Source
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-source.html
    /// </summary>
    public class Source
    {

        /// <summary>
        /// SourceArn
        /// The ARN of the source.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourceArn")]
        public Union<string, IntrinsicFunction> SourceArn { get; set; }

        /// <summary>
        /// Decryption
        /// The type of encryption that is used on the content ingested from the source.
        /// Required: No
        /// Type: Encryption
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Decryption")]
        public Encryption Decryption { get; set; }

        /// <summary>
        /// Description
        /// A description of the source. This description is not visible outside of the current AWS account.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// EntitlementArn
        /// The ARN of the entitlement that allows you to subscribe to content that comes from another AWS
        /// account. The entitlement is set by the content originator and the ARN is generated as part of the
        /// originator’s flow.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("EntitlementArn")]
        public Union<string, IntrinsicFunction> EntitlementArn { get; set; }

        /// <summary>
        /// IngestIp
        /// The IP address that the flow listens on for incoming content.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IngestIp")]
        public Union<string, IntrinsicFunction> IngestIp { get; set; }

        /// <summary>
        /// IngestPort
        /// The port that the flow listens on for incoming content. If the protocol of the source is Zixi, the
        /// port must be set to 2088.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IngestPort")]
        public Union<int, IntrinsicFunction> IngestPort { get; set; }

        /// <summary>
        /// MaxBitrate
        /// The maximum bitrate for RIST, RTP, and RTP-FEC streams.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxBitrate")]
        public Union<int, IntrinsicFunction> MaxBitrate { get; set; }

        /// <summary>
        /// MaxLatency
        /// The maximum latency in milliseconds for a RIST or Zixi-based source.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxLatency")]
        public Union<int, IntrinsicFunction> MaxLatency { get; set; }

        /// <summary>
        /// Name
        /// The name of the source.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Protocol
        /// The protocol that is used by the source.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Protocol")]
        public Union<string, IntrinsicFunction> Protocol { get; set; }

        /// <summary>
        /// StreamId
        /// The stream ID that you want to use for the transport. This parameter applies only to Zixi-based
        /// streams.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("StreamId")]
        public Union<string, IntrinsicFunction> StreamId { get; set; }

        /// <summary>
        /// VpcInterfaceName
        /// The name of the VPC interface that the source content comes from.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VpcInterfaceName")]
        public Union<string, IntrinsicFunction> VpcInterfaceName { get; set; }

        /// <summary>
        /// WhitelistCidr
        /// The range of IP addresses that are allowed to contribute content to your source. Format the IP
        /// addresses as a Classless Inter-Domain Routing (CIDR) block; for example, 10. 0. 0. 0/16.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("WhitelistCidr")]
        public Union<string, IntrinsicFunction> WhitelistCidr { get; set; }

    }
}
