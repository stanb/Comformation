using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel InputLossBehavior
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputlossbehavior.html
    /// </summary>
    public class InputLossBehavior
    {

        /// <summary>
        /// InputLossImageColor
        /// When the input loss image type is &quot;color,&quot; this field specifies the color to use. Value: 6 hex
        /// characters that represent the values of RGB.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputLossImageColor")]
        public Union<string, IntrinsicFunction> InputLossImageColor { get; set; }

        /// <summary>
        /// BlackFrameMsec
        /// On input loss, the number of milliseconds to substitute black into the output before switching to
        /// the frame specified by inputLossImageType. A value x, where 0 &amp;lt;= x &amp;lt;= 1,000,000 and a value of
        /// 1,000,000, is interpreted as infinite.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BlackFrameMsec")]
        public Union<int, IntrinsicFunction> BlackFrameMsec { get; set; }

        /// <summary>
        /// InputLossImageType
        /// Indicates whether to substitute a solid color or a slate into the output after the input loss
        /// exceeds blackFrameMsec.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputLossImageType")]
        public Union<string, IntrinsicFunction> InputLossImageType { get; set; }

        /// <summary>
        /// InputLossImageSlate
        /// When the input loss image type is &quot;slate,&quot; these fields specify the parameters for accessing the
        /// slate.
        /// Required: No
        /// Type: InputLocation
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputLossImageSlate")]
        public InputLocation InputLossImageSlate { get; set; }

        /// <summary>
        /// RepeatFrameMsec
        /// On input loss, the number of milliseconds to repeat the previous picture before substituting black
        /// into the output. A value x, where 0 &amp;lt;= x &amp;lt;= 1,000,000 and a value of 1,000,000, is interpreted
        /// as infinite.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RepeatFrameMsec")]
        public Union<int, IntrinsicFunction> RepeatFrameMsec { get; set; }

    }
}
