using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel InputAttachment
    /// An input to attach to this channel.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputattachment.html
    /// </summary>
    public class InputAttachment
    {

        /// <summary>
        /// InputAttachmentName
        /// A name for the attachment. This is required if you want to use this input in an input switch action.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputAttachmentName")]
        public Union<string, IntrinsicFunction> InputAttachmentName { get; set; }

        /// <summary>
        /// InputId
        /// The ID of the input to attach.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("InputId")]
        public Union<string, IntrinsicFunction> InputId { get; set; }

        /// <summary>
        /// InputSettings
        /// Information about the content to extract from the input and about the general handling of the
        /// content.
        /// Required: No
        /// Type: InputSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputSettings")]
        public InputSettings InputSettings { get; set; }

    }
}
