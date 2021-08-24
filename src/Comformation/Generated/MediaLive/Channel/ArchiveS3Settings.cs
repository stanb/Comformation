using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel ArchiveS3Settings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-archives3settings.html
    /// </summary>
    public class ArchiveS3Settings
    {

        /// <summary>
        /// CannedAcl
        /// Specify the canned ACL to apply to each S3 request. Defaults to none.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CannedAcl")]
        public Union<string, IntrinsicFunction> CannedAcl { get; set; }

    }
}
