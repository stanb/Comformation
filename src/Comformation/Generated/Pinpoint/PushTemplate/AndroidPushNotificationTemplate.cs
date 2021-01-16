using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.PushTemplate
{
    /// <summary>
    /// AWS::Pinpoint::PushTemplate AndroidPushNotificationTemplate
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-pushtemplate-androidpushnotificationtemplate.html
    /// </summary>
    public class AndroidPushNotificationTemplate
    {

        /// <summary>
        /// Action
        /// The action to occur if a recipient taps a push notification that&#39;s based on the message template.
        /// Valid values are:
        /// OPEN_APP - Your app opens or it becomes the foreground app if it was sent to the background. This is
        /// the default action. DEEP_LINK - Your app opens and displays a designated user interface in the app.
        /// This action uses the deep-linking features of the Android platform. URL - The default mobile browser
        /// on the recipient&#39;s device opens and loads the web page at a URL that you specify.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Action")]
        public Union<string, IntrinsicFunction> Action { get; set; }

        /// <summary>
        /// ImageUrl
        /// The URL of an image to display in a push notification that&#39;s based on the message template.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ImageUrl")]
        public Union<string, IntrinsicFunction> ImageUrl { get; set; }

        /// <summary>
        /// SmallImageIconUrl
        /// The URL of the small icon image to display in the status bar and the content view of a push
        /// notification that&#39;s based on the message template.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SmallImageIconUrl")]
        public Union<string, IntrinsicFunction> SmallImageIconUrl { get; set; }

        /// <summary>
        /// Title
        /// The title to use in a push notification that&#39;s based on the message template. This title appears
        /// above the notification message on a recipient&#39;s device.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Title")]
        public Union<string, IntrinsicFunction> Title { get; set; }

        /// <summary>
        /// ImageIconUrl
        /// The URL of the large icon image to display in the content view of a push notification that&#39;s based
        /// on the message template.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ImageIconUrl")]
        public Union<string, IntrinsicFunction> ImageIconUrl { get; set; }

        /// <summary>
        /// Sound
        /// The sound to play when a recipient receives a push notification that&#39;s based on the message
        /// template. You can use the default stream or specify the file name of a sound resource that&#39;s bundled
        /// in your app. On an Android platform, the sound file must reside in /res/raw/.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Sound")]
        public Union<string, IntrinsicFunction> Sound { get; set; }

        /// <summary>
        /// Body
        /// The message body to use in a push notification that&#39;s based on the message template.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Body")]
        public Union<string, IntrinsicFunction> Body { get; set; }

        /// <summary>
        /// Url
        /// The URL to open in a recipient&#39;s default mobile browser, if a recipient taps a push notification
        /// that&#39;s based on the message template and the value of the Action property is URL.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Url")]
        public Union<string, IntrinsicFunction> Url { get; set; }

    }
}
