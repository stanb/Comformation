using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.Template
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-template-template.html
    /// </summary>
    public class Template
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-template-template.html#cfn-ses-template-template-htmlpart
        /// </summary>
        [JsonProperty("HtmlPart")]
        public Union<string, IntrinsicFunction> HtmlPart { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-template-template.html#cfn-ses-template-template-textpart
        /// </summary>
        [JsonProperty("TextPart")]
        public Union<string, IntrinsicFunction> TextPart { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-template-template.html#cfn-ses-template-template-templatename
        /// </summary>
        [JsonProperty("TemplateName")]
        public Union<string, IntrinsicFunction> TemplateName { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-template-template.html#cfn-ses-template-template-subjectpart
        /// </summary>
        [JsonProperty("SubjectPart")]
        public Union<string, IntrinsicFunction> SubjectPart { get; set; }

    }
}
