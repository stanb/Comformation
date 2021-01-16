using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.Campaign
{
    /// <summary>
    /// AWS::Pinpoint::Campaign Message
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html
    /// </summary>
    public class Message
    {

        /// <summary>
        /// JsonBody
        /// The JSON payload to use for a silent push notification.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("JsonBody")]
        public Union<string, IntrinsicFunction> JsonBody { get; set; }

        /// <summary>
        /// Action
        /// The action to occur if a recipient taps the push notification. Valid values are:
        /// OPEN_APP - Your app opens or it becomes the foreground app if it was sent to the background. This is
        /// the default action. DEEP_LINK - Your app opens and displays a designated user interface in the app.
        /// This setting uses the deep-linking features of iOS and Android. URL - The default mobile browser on
        /// the recipient&#39;s device opens and loads the web page at a URL that you specify.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Action")]
        public Union<string, IntrinsicFunction> Action { get; set; }

        /// <summary>
        /// MediaUrl
        /// The URL of the image or video to display in the push notification.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MediaUrl")]
        public Union<string, IntrinsicFunction> MediaUrl { get; set; }

        /// <summary>
        /// TimeToLive
        /// The number of seconds that the push-notification service should keep the message, if the service is
        /// unable to deliver the notification the first time. This value is converted to an expiration value
        /// when it&#39;s sent to a push-notification service. If this value is 0, the service treats the
        /// notification as if it expires immediately and the service doesn&#39;t store or try to deliver the
        /// notification again.
        /// This value doesn&#39;t apply to messages that are sent through the Amazon Device Messaging (ADM)
        /// service.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TimeToLive")]
        public Union<int, IntrinsicFunction> TimeToLive { get; set; }

        /// <summary>
        /// ImageSmallIconUrl
        /// The URL of the image to display as the small, push-notification icon, such as a small version of the
        /// icon for the app.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ImageSmallIconUrl")]
        public Union<string, IntrinsicFunction> ImageSmallIconUrl { get; set; }

        /// <summary>
        /// ImageUrl
        /// The URL of an image to display in the push notification.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ImageUrl")]
        public Union<string, IntrinsicFunction> ImageUrl { get; set; }

        /// <summary>
        /// Title
        /// The title to display above the notification message on a recipient&#39;s device.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Title")]
        public Union<string, IntrinsicFunction> Title { get; set; }

        /// <summary>
        /// ImageIconUrl
        /// The URL of the image to display as the push-notification icon, such as the icon for the app.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ImageIconUrl")]
        public Union<string, IntrinsicFunction> ImageIconUrl { get; set; }

        /// <summary>
        /// SilentPush
        /// Specifies whether the notification is a silent push notification, which is a push notification that
        /// doesn&#39;t display on a recipient&#39;s device. Silent push notifications can be used for cases such as
        /// updating an app&#39;s configuration, displaying messages in an in-app message center, or supporting
        /// phone home functionality.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SilentPush")]
        public Union<bool, IntrinsicFunction> SilentPush { get; set; }

        /// <summary>
        /// Body
        /// The body of the notification message. The maximum number of characters is 200.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Body")]
        public Union<string, IntrinsicFunction> Body { get; set; }

        /// <summary>
        /// RawContent
        /// The raw, JSON-formatted string to use as the payload for the notification message. If specified,
        /// this value overrides all other content for the message.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RawContent")]
        public Union<string, IntrinsicFunction> RawContent { get; set; }

        /// <summary>
        /// Url
        /// The URL to open in a recipient&#39;s default mobile browser, if a recipient taps the push notification
        /// and the value of the Action property is URL.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Url")]
        public Union<string, IntrinsicFunction> Url { get; set; }

    }
}
