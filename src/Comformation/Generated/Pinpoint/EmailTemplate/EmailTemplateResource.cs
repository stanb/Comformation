using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.Pinpoint.EmailTemplate
{
    /// <summary>
    /// AWS::Pinpoint::EmailTemplate
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-emailtemplate.html
    /// </summary>
    public class EmailTemplateResource : ResourceBase
    {
        public class EmailTemplateProperties
        {
            /// <summary>
            /// HtmlPart
            /// The message body, in HTML format, to use in email messages that are based on the message template.
            /// We recommend using HTML format for email clients that render HTML content. You can include links,
            /// formatted text, and more in an HTML message.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> HtmlPart { get; set; }

            /// <summary>
            /// TextPart
            /// The message body, in plain text format, to use in email messages that are based on the message
            /// template. We recommend using plain text format for email clients that don&#39;t render HTML content and
            /// clients that are connected to high-latency networks, such as mobile devices.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> TextPart { get; set; }

            /// <summary>
            /// TemplateName
            /// The name of the message template.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> TemplateName { get; set; }

            /// <summary>
            /// TemplateDescription
            /// A custom description of the message template.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> TemplateDescription { get; set; }

            /// <summary>
            /// DefaultSubstitutions
            /// A JSON object that specifies the default values to use for message variables in the message
            /// template. This object is a set of key-value pairs. Each key defines a message variable in the
            /// template. The corresponding value defines the default value for that variable. When you create a
            /// message that&#39;s based on the template, you can override these defaults with message-specific and
            /// address-specific variables and values.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> DefaultSubstitutions { get; set; }

            /// <summary>
            /// Subject
            /// The subject line, or title, to use in email messages that are based on the message template.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Subject { get; set; }

            /// <summary>
            /// Tags
            /// A string-to-string map of key-value pairs that defines the tags to associate with the message
            /// template. Each tag consists of a required tag key and an associated tag value.
            /// Required: No
            /// Type: Json
            /// Update requires: No interruption
            /// </summary>
            public Union<Newtonsoft.Json.Linq.JToken, IntrinsicFunction> Tags { get; set; }

        }

        public string Type { get; } = "AWS::Pinpoint::EmailTemplate";

        public EmailTemplateProperties Properties { get; } = new EmailTemplateProperties();

    }

    public static class EmailTemplateAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
    }
}
