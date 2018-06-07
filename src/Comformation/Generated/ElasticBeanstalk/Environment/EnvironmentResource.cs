using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticBeanstalk.Environment
{
    /// <summary>
    /// AWS::ElasticBeanstalk::Environment
    /// Creates or updates an AWS Elastic Beanstalk environment.
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk-environment.html
    /// </summary>
    public class EnvironmentResource : ResourceBase
    {
        public class EnvironmentProperties
        {
            /// <summary>
            /// ApplicationName
            /// The name of the application that is associated with this environment.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk-environment.html#cfn-beanstalk-environment-applicationname
            /// </summary>
			public Union<string, IntrinsicFunction> ApplicationName { get; set; }

            /// <summary>
            /// CNAMEPrefix
            /// A prefix for your Elastic Beanstalk environment URL.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk-environment.html#cfn-beanstalk-environment-cnameprefix
            /// </summary>
			public Union<string, IntrinsicFunction> CNAMEPrefix { get; set; }

            /// <summary>
            /// Description
            /// A description that helps you identify this environment.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk-environment.html#cfn-beanstalk-environment-description
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// EnvironmentName
            /// A name for the Elastic Beanstalk environment. If you don't specify a name, AWS CloudFormation
            /// generates a unique physical ID and uses that ID for the environment name. For more information, see
            /// Name Type.
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk-environment.html#cfn-beanstalk-environment-name
            /// </summary>
			public Union<string, IntrinsicFunction> EnvironmentName { get; set; }

            /// <summary>
            /// OptionSettings
            /// Key-value pairs defining configuration options for this environment, such as the instance type.
            /// These options override the values that are defined in the solution stack or the configuration
            /// template. If you remove any options during a stack update, the removed options revert to default
            /// values.
            /// Required: Yes. The IamInstanceProfile and ServiceRole options are required.
            /// Type: List of Elastic Beanstalk Environment OptionSetting
            /// Update requires: Some interruptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk-environment.html#cfn-beanstalk-environment-optionsettings
            /// </summary>
			public Union<List<OptionSetting>, IntrinsicFunction> OptionSettings { get; set; }

            /// <summary>
            /// PlatformArn
            /// The Amazon Resource Name (ARN) of the custom platform to use with the environment. For more
            /// information, see Custom Platforms in the AWS Elastic Beanstalk Developer Guide.
            /// Note If you specify PlatformArn, then don't specify SolutionStackName.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// Example: "PlatformArn": "arn:aws:elasticbeanstalk:us-east-1::platform/PHP 5. 4 running on 64bit
            /// Amazon Linux/2. 4. 4"
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk-environment.html#cfn-beanstalk-environment-platformarn
            /// </summary>
			public Union<string, IntrinsicFunction> PlatformArn { get; set; }

            /// <summary>
            /// SolutionStackName
            /// The name of an Elastic Beanstalk solution stack that this configuration will use. For more
            /// information, see Supported Platforms in the AWS Elastic Beanstalk Developer Guide.
            /// Note If you specify SolutionStackName, then don't specify PlatformArn or TemplateName.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk-environment.html#cfn-beanstalk-environment-solutionstackname
            /// </summary>
			public Union<string, IntrinsicFunction> SolutionStackName { get; set; }

            /// <summary>
            /// Tags
            /// An arbitrary set of tags (key–value pairs) for this environment.
            /// Required: No
            /// Type: AWS CloudFormation Resource Tags
            /// Update requires: You can update tags only if you update another property that requires that the
            /// environment be replaced, such as the ApplicationName property.
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk-environment.html#cfn-beanstalk-environment-tags
            /// </summary>
			public Union<List<Tag>, IntrinsicFunction> Tags { get; set; }

            /// <summary>
            /// TemplateName
            /// The name of the Elastic Beanstalk configuration template to use with the environment.
            /// Note If you specify TemplateName, then don't specify SolutionStackName.
            /// Required: No
            /// Type: String
            /// Update requires: Some interruptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk-environment.html#cfn-beanstalk-environment-templatename
            /// </summary>
			public Union<string, IntrinsicFunction> TemplateName { get; set; }

            /// <summary>
            /// Tier
            /// Specifies the tier to use in creating this environment. The environment tier that you choose
            /// determines whether Elastic Beanstalk provisions resources to support a web application that handles
            /// HTTP(S) requests or a web application that handles background-processing tasks.
            /// Required: No
            /// Type: Elastic Beanstalk Environment Tier Property Type
            /// Update requires: See Elastic Beanstalk Environment Tier Property Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk-environment.html#cfn-beanstalk-environment-tier
            /// </summary>
			public Union<Tier, IntrinsicFunction> Tier { get; set; }

            /// <summary>
            /// VersionLabel
            /// The version to associate with the environment.
            /// Required: No
            /// Type: String
            /// Update requires: Some interruptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk-environment.html#cfn-beanstalk-environment-versionlabel
            /// </summary>
			public Union<string, IntrinsicFunction> VersionLabel { get; set; }

        }
    
        public string Type { get; } = "AWS::ElasticBeanstalk::Environment";
        
        public EnvironmentProperties Properties { get; } = new EnvironmentProperties();
    }

	public static class EnvironmentAttributes
	{
        public static readonly ResourceAttribute<string> EndpointURL = new ResourceAttribute<string>("EndpointURL");
	}
}
