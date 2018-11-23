using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.EC2.LaunchTemplate
{
    /// <summary>
    /// AWS::EC2::LaunchTemplate
    /// The AWS::EC2::LaunchTemplate resource creates a launch template for an Amazon EC2 instance. A launch template
    /// contains the parameters to launch an instance. For more information, see CreateLaunchTemplate in the Amazon
    /// EC2 API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-launchtemplate.html
    /// </summary>
    public class LaunchTemplateResource : ResourceBase
    {
        public class LaunchTemplateProperties
        {
            /// <summary>
            /// LaunchTemplateName
            /// A name for the launch template.
            /// Length Constraints: Minimum length of 3. Maximum length of 128.
            /// Pattern: [a-zA-Z0-9\(\)\. -/_]+
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> LaunchTemplateName { get; set; }

            /// <summary>
            /// LaunchTemplateData
            /// The information for the launch template.
            /// Required: No
            /// Type: LaunchTemplateData
            /// Update requires: No interruption
            /// </summary>
			public LaunchTemplateData LaunchTemplateData { get; set; }

        }

        public string Type { get; } = "AWS::EC2::LaunchTemplate";

        public LaunchTemplateProperties Properties { get; } = new LaunchTemplateProperties();

    }

	public static class LaunchTemplateAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> LatestVersionNumber = new ResourceAttribute<Union<string, IntrinsicFunction>>("LatestVersionNumber");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> DefaultVersionNumber = new ResourceAttribute<Union<string, IntrinsicFunction>>("DefaultVersionNumber");
	}
}
