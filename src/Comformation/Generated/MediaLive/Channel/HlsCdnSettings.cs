using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.MediaLive.Channel
{
    /// <summary>
    /// AWS::MediaLive::Channel HlsCdnSettings
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlscdnsettings.html
    /// </summary>
    public class HlsCdnSettings
    {

        /// <summary>
        /// HlsWebdavSettings
        /// The settings for Web VTT captions in the HLS output group.
        /// The parent of this entity is HlsGroupSettings.
        /// Required: No
        /// Type: HlsWebdavSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HlsWebdavSettings")]
        public HlsWebdavSettings HlsWebdavSettings { get; set; }

        /// <summary>
        /// HlsS3Settings
        /// Sets up Amazon S3 as the destination for this HLS output.
        /// Required: No
        /// Type: HlsS3Settings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HlsS3Settings")]
        public HlsS3Settings HlsS3Settings { get; set; }

        /// <summary>
        /// HlsAkamaiSettings
        /// Sets up Akamai as the downstream system for the HLS output group.
        /// Required: No
        /// Type: HlsAkamaiSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HlsAkamaiSettings")]
        public HlsAkamaiSettings HlsAkamaiSettings { get; set; }

        /// <summary>
        /// HlsBasicPutSettings
        /// The settings for Basic Put for the HLS output.
        /// Required: No
        /// Type: HlsBasicPutSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HlsBasicPutSettings")]
        public HlsBasicPutSettings HlsBasicPutSettings { get; set; }

        /// <summary>
        /// HlsMediaStoreSettings
        /// Sets up MediaStore as the destination for the HLS output.
        /// Required: No
        /// Type: HlsMediaStoreSettings
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HlsMediaStoreSettings")]
        public HlsMediaStoreSettings HlsMediaStoreSettings { get; set; }

    }
}
