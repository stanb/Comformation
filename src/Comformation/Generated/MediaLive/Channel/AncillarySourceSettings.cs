using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel AncillarySourceSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-ancillarysourcesettings.html
    /// </summary>
    public class AncillarySourceSettings
    {

        /// <summary>
        /// SourceAncillaryChannelNumber
        /// Specifies the number (1 to 4) of the captions channel you want to extract from the ancillary
        /// captions. If you plan to convert the ancillary captions to another format, complete this field. If
        /// you plan to choose Embedded as the captions destination in the output (to pass through all the
        /// channels in the ancillary captions), leave this field blank because MediaLive ignores the field.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SourceAncillaryChannelNumber")]
        public Union<int, IntrinsicFunction> SourceAncillaryChannelNumber { get; set; }

    }
}
