using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LaunchTemplate
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-launchtemplate.html
    /// </summary>
    public class LaunchTemplateResource : ResourceBase
    {
        public class LaunchTemplateProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-launchtemplate.html#cfn-ec2-launchtemplate-launchtemplatename
            /// </summary>
			public Union<string, IntrinsicFunction> LaunchTemplateName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-launchtemplate.html#cfn-ec2-launchtemplate-launchtemplatedata
            /// </summary>
			public Union<LaunchTemplateData, IntrinsicFunction> LaunchTemplateData { get; set; }

        }
    
        public string Type { get; } = "AWS::EC2::LaunchTemplate";
        
        public LaunchTemplateProperties Properties { get; } = new LaunchTemplateProperties();
    }

	public static class LaunchTemplateAttributes
	{
        public static readonly ResourceAttribute<string> LatestVersionNumber = new ResourceAttribute<string>("LatestVersionNumber");
        public static readonly ResourceAttribute<string> DefaultVersionNumber = new ResourceAttribute<string>("DefaultVersionNumber");
	}
}
