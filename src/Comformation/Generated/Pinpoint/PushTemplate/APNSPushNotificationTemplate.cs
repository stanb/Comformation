using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.PushTemplate
{
    /// <summary>
    /// AWS::Pinpoint::PushTemplate APNSPushNotificationTemplate
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-pushtemplate-apnspushnotificationtemplate.html
    /// </summary>
    public class APNSPushNotificationTemplate
    {

        /// <summary>
        /// Action
        /// The action to occur if a recipient taps a push notification that&#39;s based on the message template.
        /// Valid values are:
        /// OPEN_APP - Your app opens or it becomes the foreground app if it was sent to the background. This is
        /// the default action. DEEP_LINK - Your app opens and displays a designated user interface in the app.
        /// This setting uses the deep-linking features of the iOS platform. URL - The default mobile browser on
        /// the recipient&#39;s device opens and loads the web page at a URL that you specify.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Action")]
        public Union<string, IntrinsicFunction> Action { get; set; }

        /// <summary>
        /// MediaUrl
        /// The URL of an image or video to display in push notifications that are based on the message
        /// template.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MediaUrl")]
        public Union<string, IntrinsicFunction> MediaUrl { get; set; }

        /// <summary>
        /// Title
        /// The title to use in push notifications that are based on the message template. This title appears
        /// above the notification message on a recipient&#39;s device.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Title")]
        public Union<string, IntrinsicFunction> Title { get; set; }

        /// <summary>
        /// Sound
        /// The key for the sound to play when the recipient receives a push notification that&#39;s based on the
        /// message template. The value for this key is the name of a sound file in your app&#39;s main bundle or
        /// the Library/Sounds folder in your app&#39;s data container. If the sound file can&#39;t be found or you
        /// specify default for the value, the system plays the default alert sound.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Sound")]
        public Union<string, IntrinsicFunction> Sound { get; set; }

        /// <summary>
        /// Body
        /// The message body to use in push notifications that are based on the message template.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Body")]
        public Union<string, IntrinsicFunction> Body { get; set; }

        /// <summary>
        /// Url
        /// The URL to open in the recipient&#39;s default mobile browser, if a recipient taps a push notification
        /// that&#39;s based on the message template and the value of the Action property is URL.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Url")]
        public Union<string, IntrinsicFunction> Url { get; set; }

    }
}
