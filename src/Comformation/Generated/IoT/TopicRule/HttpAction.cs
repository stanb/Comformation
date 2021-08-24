using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.TopicRule
{
    /// <summary>
    /// AWS::IoT::TopicRule HttpAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-httpaction.html
    /// </summary>
    public class HttpAction
    {

        /// <summary>
        /// ConfirmationUrl
        /// The URL to which AWS IoT sends a confirmation message. The value of the confirmation URL must be a
        /// prefix of the endpoint URL. If you do not specify a confirmation URL AWS IoT uses the endpoint URL
        /// as the confirmation URL. If you use substitution templates in the confirmationUrl, you must create
        /// and enable topic rule destinations that match each possible value of the substitution template
        /// before traffic is allowed to your endpoint URL.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ConfirmationUrl")]
        public Union<string, IntrinsicFunction> ConfirmationUrl { get; set; }

        /// <summary>
        /// Headers
        /// The HTTP headers to send with the message data.
        /// Required: No
        /// Type: List of HttpActionHeader
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Headers")]
        public List<HttpActionHeader> Headers { get; set; }

        /// <summary>
        /// Url
        /// The endpoint URL. If substitution templates are used in the URL, you must also specify a
        /// confirmationUrl. If this is a new destination, a new TopicRuleDestination is created if possible.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Url")]
        public Union<string, IntrinsicFunction> Url { get; set; }

        /// <summary>
        /// Auth
        /// The authentication method to use when sending data to an HTTPS endpoint.
        /// Required: No
        /// Type: HttpAuthorization
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Auth")]
        public HttpAuthorization Auth { get; set; }

    }
}
