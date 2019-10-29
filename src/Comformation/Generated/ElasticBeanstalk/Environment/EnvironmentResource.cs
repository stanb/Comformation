using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticBeanstalk.Environment
{
    /// <summary>
    /// AWS::ElasticBeanstalk::Environment
    /// The AWS::ElasticBeanstalk::Environment resource is an AWS Elastic Beanstalk resource type that specifies an
    /// Elastic Beanstalk environment.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk-environment.html
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
            /// Minimum: 1
            /// Maximum: 100
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ApplicationName { get; set; }

            /// <summary>
            /// CNAMEPrefix
            /// If specified, the environment attempts to use this value as the prefix for the CNAME in your Elastic
            /// Beanstalk environment URL. If not specified, the CNAME is generated automatically by appending a
            /// random alphanumeric string to the environment name.
            /// Required: No
            /// Type: String
            /// Minimum: 4
            /// Maximum: 63
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> CNAMEPrefix { get; set; }

            /// <summary>
            /// Description
            /// Your description for this environment.
            /// Required: No
            /// Type: String
            /// Maximum: 200
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// EnvironmentName
            /// A unique name for the environment.
            /// Constraint: Must be from 4 to 40 characters in length. The name can contain only letters, numbers,
            /// and hyphens. It can&#39;t start or end with a hyphen. This name must be unique within a region in your
            /// account.
            /// If you don&#39;t specify the CNAMEPrefix parameter, the environment name becomes part of the CNAME, and
            /// therefore part of the visible URL for your application.
            /// If you don&#39;t specify an environment name, AWS CloudFormation generates a unique physical ID and uses
            /// that ID for the environment name. For more information, see Name Type.
            /// Important If you specify a name, you cannot perform updates that require replacement of this
            /// resource. You can perform updates that require no or some interruption. If you must replace the
            /// resource, specify a new name.
            /// Required: No
            /// Type: String
            /// Minimum: 4
            /// Maximum: 40
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> EnvironmentName { get; set; }

            /// <summary>
            /// OptionSettings
            /// Key-value pairs defining configuration options for this environment, such as the instance type.
            /// These options override the values that are defined in the solution stack or the configuration
            /// template. If you remove any options during a stack update, the removed options retain their current
            /// values.
            /// Required: Yes. The IamInstanceProfile option is required.
            /// Required: No
            /// Type: List of OptionSetting
            /// Update requires: No interruption
            /// </summary>
			public List<OptionSetting> OptionSettings { get; set; }

            /// <summary>
            /// PlatformArn
            /// The Amazon Resource Name (ARN) of the custom platform to use with the environment. For more
            /// information, see Custom Platforms in the AWS Elastic Beanstalk Developer Guide.
            /// Note If you specify PlatformArn, don&#39;t specify SolutionStackName.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> PlatformArn { get; set; }

            /// <summary>
            /// SolutionStackName
            /// The name of an Elastic Beanstalk solution stack (platform version) to use with the environment. If
            /// specified, Elastic Beanstalk sets the configuration values to the default values associated with the
            /// specified solution stack. For a list of current solution stacks, see Elastic Beanstalk Supported
            /// Platforms in the AWS Elastic Beanstalk Platforms guide.
            /// Note If you specify SolutionStackName, don&#39;t specify PlatformArn or TemplateName.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SolutionStackName { get; set; }

            /// <summary>
            /// Tags
            /// Specifies the tags applied to resources in the environment.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
			public List<Tag> Tags { get; set; }

            /// <summary>
            /// TemplateName
            /// The name of the Elastic Beanstalk configuration template to use with the environment.
            /// Note If you specify TemplateName, then don&#39;t specify SolutionStackName.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> TemplateName { get; set; }

            /// <summary>
            /// Tier
            /// Specifies the tier to use in creating this environment. The environment tier that you choose
            /// determines whether Elastic Beanstalk provisions resources to support a web application that handles
            /// HTTP(S) requests or a web application that handles background-processing tasks.
            /// Required: No
            /// Type: Tier
            /// Update requires: Some interruptions
            /// </summary>
			public Tier Tier { get; set; }

            /// <summary>
            /// VersionLabel
            /// The name of the application version to deploy.
            /// Default: If not specified, Elastic Beanstalk attempts to deploy the sample application.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> VersionLabel { get; set; }

        }

        public string Type { get; } = "AWS::ElasticBeanstalk::Environment";

        public EnvironmentProperties Properties { get; } = new EnvironmentProperties();

    }

	public static class EnvironmentAttributes
	{
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> EndpointURL = new ResourceAttribute<Union<string, IntrinsicFunction>>("EndpointURL");
	}
}
