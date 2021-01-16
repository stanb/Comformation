using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel FecOutputSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-fecoutputsettings.html
    /// </summary>
    public class FecOutputSettings
    {

        /// <summary>
        /// RowLength
        /// The parameter L from SMPTE 2022-1. The width of the FEC protection matrix. Must be between 1 and 20,
        /// inclusive. If only Column FEC is used, then larger values increase robustness. If Row FEC is used,
        /// then this is the number of transport stream packets per row error correction packet, and the value
        /// must be between 4 and 20, inclusive, if includeFec is columnAndRow. If includeFec is column, this
        /// value must be 1 to 20, inclusive.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RowLength")]
        public Union<int, IntrinsicFunction> RowLength { get; set; }

        /// <summary>
        /// ColumnDepth
        /// The parameter D from SMPTE 2022-1. The height of the FEC protection matrix. The number of transport
        /// stream packets per column error correction packet. The number must be between 4 and 20, inclusive.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ColumnDepth")]
        public Union<int, IntrinsicFunction> ColumnDepth { get; set; }

        /// <summary>
        /// IncludeFec
        /// Enables column only or column and row-based FEC.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IncludeFec")]
        public Union<string, IntrinsicFunction> IncludeFec { get; set; }

    }
}
