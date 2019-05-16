using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.Template
{
    /// <summary>
    /// AWS::SES::Template Template
    /// The content of the email, composed of a subject line, an HTML part, and a text-only part.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-template-template.html
    /// </summary>
    public class Template
    {

        /// <summary>
        /// HtmlPart
        /// The HTML body of the email.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HtmlPart")]
        public Union<string, IntrinsicFunction> HtmlPart { get; set; }

        /// <summary>
        /// TextPart
        /// The email body that is visible to recipients whose email clients don&#39;t display HTML content.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TextPart")]
        public Union<string, IntrinsicFunction> TextPart { get; set; }

        /// <summary>
        /// TemplateName
        /// The name of the template. You specify this name when you send email using the SendTemplatedEmail or
        /// SendBulkTemplatedEmail operations.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("TemplateName")]
        public Union<string, IntrinsicFunction> TemplateName { get; set; }

        /// <summary>
        /// SubjectPart
        /// The subject line of the email.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SubjectPart")]
        public Union<string, IntrinsicFunction> SubjectPart { get; set; }

    }
}
