using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ReceiptRule
{
    /// <summary>
    /// AWS::SES::ReceiptRule AddHeaderAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-addheaderaction.html
    /// </summary>
    public class AddHeaderAction
    {

        /// <summary>
        /// HeaderValue
        /// The content to include in the header. This value can contain up to 2048 characters. It can&#39;t contain
        /// newline (\n) or carriage return (\r) characters.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HeaderValue")]
        public Union<string, IntrinsicFunction> HeaderValue { get; set; }

        /// <summary>
        /// HeaderName
        /// The name of the header to add to the incoming message. The name must contain at least one character,
        /// and can contain up to 50 characters. It consists of alphanumeric (a–z, A–Z, 0–9) characters and
        /// dashes.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HeaderName")]
        public Union<string, IntrinsicFunction> HeaderName { get; set; }

    }
}
