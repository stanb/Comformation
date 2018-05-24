using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SES.Template
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-template.html
    /// </summary>
    public class TemplateResource : ResourceBase
    {
        public class TemplateProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-template.html#cfn-ses-template-template
            /// </summary>
			public Union<Template, IntrinsicFunction> Template { get; set; }

        }
    
        public string Type { get; } = "AWS::SES::Template";
        
        public TemplateProperties Properties { get; } = new TemplateProperties();
    }
}
