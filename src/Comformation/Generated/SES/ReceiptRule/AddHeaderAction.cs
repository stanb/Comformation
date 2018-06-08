using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.ReceiptRule
{
    /// <summary>
    /// Amazon Simple Email Service ReceiptRule AddHeaderAction
    /// The AddHeaderAction property type add a header to email it recieves on behalf of one or more email addresses
    /// or domains that you own.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-addheaderaction.html
    /// </summary>
    public class AddHeaderAction
    {

        /// <summary>
        /// HeaderValue
        /// Must be less than 2048 characters, and must not contain newline characters ("\r" or "\n").
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HeaderValue")]
        public Union<string, IntrinsicFunction> HeaderValue { get; set; }

        /// <summary>
        /// HeaderName
        /// The name of the header to add. Must be between 1 and 50 characters, inclusive, and consist of
        /// alphanumeric (a-z, A-Z, 0-9) characters and dashes only.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HeaderName")]
        public Union<string, IntrinsicFunction> HeaderName { get; set; }

    }
}
