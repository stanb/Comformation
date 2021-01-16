using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.Campaign
{
    /// <summary>
    /// AWS::Pinpoint::Campaign CampaignEmailMessage
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaignemailmessage.html
    /// </summary>
    public class CampaignEmailMessage
    {

        /// <summary>
        /// FromAddress
        /// The verified email address to send the email from. The default address is the FromAddress specified
        /// for the email channel for the application.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("FromAddress")]
        public Union<string, IntrinsicFunction> FromAddress { get; set; }

        /// <summary>
        /// HtmlBody
        /// The body of the email, in HTML format, for recipients whose email clients render HTML content.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HtmlBody")]
        public Union<string, IntrinsicFunction> HtmlBody { get; set; }

        /// <summary>
        /// Title
        /// The subject line, or title, of the email.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Title")]
        public Union<string, IntrinsicFunction> Title { get; set; }

        /// <summary>
        /// Body
        /// The body of the email for recipients whose email clients don&#39;t render HTML content.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Body")]
        public Union<string, IntrinsicFunction> Body { get; set; }

    }
}
