using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.Template
{
    /// <summary>
    /// AWS::SES::Template
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-template.html
    /// </summary>
    public class TemplateResource : ResourceBase
    {
        public class TemplateProperties
        {
            /// <summary>
            /// Template
            /// The content of the email, composed of a subject line, an HTML part, and a text-only part.
            /// Required: No
            /// Type: Template
            /// Update requires: No interruption
            /// </summary>
            public Template Template { get; set; }

        }

        public string Type { get; } = "AWS::SES::Template";

        public TemplateProperties Properties { get; } = new TemplateProperties();

    }
}
