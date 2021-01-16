using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel DvbSdtSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsdtsettings.html
    /// </summary>
    public class DvbSdtSettings
    {

        /// <summary>
        /// ServiceProviderName
        /// The service provider name placed in the serviceDescriptor in the Service Description Table (SDT).
        /// The maximum length is 256 characters.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceProviderName")]
        public Union<string, IntrinsicFunction> ServiceProviderName { get; set; }

        /// <summary>
        /// OutputSdt
        /// Selects a method of inserting SDT information into an output stream. The sdtFollow setting copies
        /// SDT information from input stream to output stream. The sdtFollowIfPresent setting copies SDT
        /// information from input stream to output stream if SDT information is present in the input.
        /// Otherwise, it falls back on the user-defined values. The sdtManual setting means that the user will
        /// enter the SDT information. The sdtNone setting means that the output stream will not contain SDT
        /// information.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OutputSdt")]
        public Union<string, IntrinsicFunction> OutputSdt { get; set; }

        /// <summary>
        /// ServiceName
        /// The service name placed in the serviceDescriptor in the Service Description Table (SDT). The maximum
        /// length is 256 characters.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceName")]
        public Union<string, IntrinsicFunction> ServiceName { get; set; }

        /// <summary>
        /// RepInterval
        /// The number of milliseconds between instances of this table in the output transport stream.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RepInterval")]
        public Union<int, IntrinsicFunction> RepInterval { get; set; }

    }
}
