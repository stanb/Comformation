using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticBeanstalk.ConfigurationTemplate
{
    /// <summary>
    /// AWS::ElasticBeanstalk::ConfigurationTemplate
    /// Creates a configuration template for an Elastic Beanstalk application. You can use configuration templates to
    /// deploy different versions of an application by using the configuration settings that you define in the
    /// configuration template.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-beanstalk-configurationtemplate.html
    /// </summary>
    public class ConfigurationTemplateResource : ResourceBase
    {
        public class ConfigurationTemplateProperties
        {
            /// <summary>
            /// ApplicationName
            /// Name of the Elastic Beanstalk application that is associated with this configuration template.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> ApplicationName { get; set; }

            /// <summary>
            /// Description
            /// An optional description for this configuration.
            /// Type: String
            /// Required: No
            /// Update requires: Some interruptions
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// EnvironmentId
            /// An environment whose settings you want to use to create the configuration template. You must specify
            /// this property if you don't specify the SolutionStackName or SourceConfiguration properties.
            /// Type: String
            /// Required: Conditional
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> EnvironmentId { get; set; }

            /// <summary>
            /// OptionSettings
            /// The options for the Elastic Beanstalk configuration, such as the instance type. For a complete list
            /// of Elastic Beanstalk configuration options, see Option Values, in the AWS Elastic Beanstalk
            /// Developer Guide.
            /// Type: List of Elastic Beanstalk ConfigurationTemplate ConfigurationOptionSetting
            /// Required: No
            /// Update requires: Some interruptions
            /// </summary>
			public Union<List<ConfigurationOptionSetting>, IntrinsicFunction> OptionSettings { get; set; }

            /// <summary>
            /// PlatformArn
            /// The Amazon Resource Name (ARN) of the custom platform. For more information, see Custom Platforms in
            /// the AWS Elastic Beanstalk Developer Guide.
            /// Note If you specify PlatformArn, then don't specify SolutionStackName.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> PlatformArn { get; set; }

            /// <summary>
            /// SolutionStackName
            /// The name of an Elastic Beanstalk solution stack that this configuration will use. A solution stack
            /// specifies the operating system, architecture, and application server for a configuration template,
            /// such as 64bit Amazon Linux 2013. 09 running Tomcat 7 Java 7. For more information, see Supported
            /// Platforms in the AWS Elastic Beanstalk Developer Guide.
            /// You must specify this property if you don't specify the PlatformArn, EnvironmentId, or
            /// SourceConfiguration properties.
            /// Type: String
            /// Required: Conditional
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> SolutionStackName { get; set; }

            /// <summary>
            /// SourceConfiguration
            /// A configuration template that is associated with another Elastic Beanstalk application. If you
            /// specify the SolutionStackName property and the SourceConfiguration property, the solution stack in
            /// the source configuration template must match the value that you specified for the SolutionStackName
            /// property.
            /// You must specify this property if you don't specify the EnvironmentId or SolutionStackName
            /// properties.
            /// Type: Elastic Beanstalk ConfigurationTemplate SourceConfiguration
            /// Required: Conditional
            /// Update requires: Replacement
            /// </summary>
			public Union<SourceConfiguration, IntrinsicFunction> SourceConfiguration { get; set; }

        }
    
        public string Type { get; } = "AWS::ElasticBeanstalk::ConfigurationTemplate";
        
        public ConfigurationTemplateProperties Properties { get; } = new ConfigurationTemplateProperties();
    }
}
