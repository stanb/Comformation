using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticBeanstalk.ConfigurationTemplate
{
    /// <summary>
    /// AWS::ElasticBeanstalk::ConfigurationTemplate
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticbeanstalk-configurationtemplate.html
    /// </summary>
    public class ConfigurationTemplateResource : ResourceBase
    {
        public class ConfigurationTemplateProperties
        {
            /// <summary>
            /// ApplicationName
            /// The name of the Elastic Beanstalk application to associate with this configuration template.
            /// Required: Yes
            /// Type: String
            /// Minimum: 1
            /// Maximum: 100
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ApplicationName { get; set; }

            /// <summary>
            /// Description
            /// An optional description for this configuration.
            /// Required: No
            /// Type: String
            /// Maximum: 200
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// EnvironmentId
            /// The ID of an environment whose settings you want to use to create the configuration template. You
            /// must specify EnvironmentId if you don&#39;t specify PlatformArn, SolutionStackName, or
            /// SourceConfiguration.
            /// Required: Conditional
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> EnvironmentId { get; set; }

            /// <summary>
            /// OptionSettings
            /// Option values for the Elastic Beanstalk configuration, such as the instance type. If specified,
            /// these values override the values obtained from the solution stack or the source configuration
            /// template. For a complete list of Elastic Beanstalk configuration options, see Option Values in the
            /// AWS Elastic Beanstalk Developer Guide.
            /// Required: No
            /// Type: List of ConfigurationOptionSetting
            /// Update requires: No interruption
            /// </summary>
            public List<ConfigurationOptionSetting> OptionSettings { get; set; }

            /// <summary>
            /// PlatformArn
            /// The Amazon Resource Name (ARN) of the custom platform. For more information, see Custom Platforms in
            /// the AWS Elastic Beanstalk Developer Guide.
            /// Note If you specify PlatformArn, then don&#39;t specify SolutionStackName.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> PlatformArn { get; set; }

            /// <summary>
            /// SolutionStackName
            /// The name of an Elastic Beanstalk solution stack (platform version) that this configuration uses. For
            /// example, 64bit Amazon Linux 2013. 09 running Tomcat 7 Java 7. A solution stack specifies the
            /// operating system, runtime, and application server for a configuration template. It also determines
            /// the set of configuration options as well as the possible and default values. For more information,
            /// see Supported Platforms in the AWS Elastic Beanstalk Developer Guide.
            /// You must specify SolutionStackName if you don&#39;t specify PlatformArn, EnvironmentId, or
            /// SourceConfiguration.
            /// Use the ListAvailableSolutionStacks API to obtain a list of available solution stacks.
            /// Required: Conditional
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> SolutionStackName { get; set; }

            /// <summary>
            /// SourceConfiguration
            /// An Elastic Beanstalk configuration template to base this one on. If specified, Elastic Beanstalk
            /// uses the configuration values from the specified configuration template to create a new
            /// configuration.
            /// Values specified in OptionSettings override any values obtained from the SourceConfiguration.
            /// You must specify SourceConfiguration if you don&#39;t specify PlatformArn, EnvironmentId, or
            /// SolutionStackName.
            /// Constraint: If both solution stack name and source configuration are specified, the solution stack
            /// of the source configuration template must match the specified solution stack name.
            /// Required: Conditional
            /// Type: SourceConfiguration
            /// Update requires: Replacement
            /// </summary>
            public SourceConfiguration SourceConfiguration { get; set; }

        }

        public string Type { get; } = "AWS::ElasticBeanstalk::ConfigurationTemplate";

        public ConfigurationTemplateProperties Properties { get; } = new ConfigurationTemplateProperties();

    }
}
