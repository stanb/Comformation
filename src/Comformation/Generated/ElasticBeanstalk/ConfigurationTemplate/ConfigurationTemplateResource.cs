using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticBeanstalk.ConfigurationTemplate
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticbeanstalk-configurationtemplate.html
    /// </summary>
    public class ConfigurationTemplateResource : ResourceBase
    {
        public class ConfigurationTemplateProperties
        {
            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticbeanstalk-configurationtemplate.html#cfn-elasticbeanstalk-configurationtemplate-applicationname
            /// </summary>
			public Union<string, IntrinsicFunction> ApplicationName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticbeanstalk-configurationtemplate.html#cfn-elasticbeanstalk-configurationtemplate-description
            /// </summary>
			public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticbeanstalk-configurationtemplate.html#cfn-elasticbeanstalk-configurationtemplate-environmentid
            /// </summary>
			public Union<string, IntrinsicFunction> EnvironmentId { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticbeanstalk-configurationtemplate.html#cfn-elasticbeanstalk-configurationtemplate-optionsettings
            /// </summary>
			public Union<List<ConfigurationOptionSetting>, IntrinsicFunction> OptionSettings { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticbeanstalk-configurationtemplate.html#cfn-elasticbeanstalk-configurationtemplate-platformarn
            /// </summary>
			public Union<string, IntrinsicFunction> PlatformArn { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticbeanstalk-configurationtemplate.html#cfn-elasticbeanstalk-configurationtemplate-solutionstackname
            /// </summary>
			public Union<string, IntrinsicFunction> SolutionStackName { get; set; }

            /// <summary>
            ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticbeanstalk-configurationtemplate.html#cfn-elasticbeanstalk-configurationtemplate-sourceconfiguration
            /// </summary>
			public Union<SourceConfiguration, IntrinsicFunction> SourceConfiguration { get; set; }

        }
    
        public string Type { get; } = "AWS::ElasticBeanstalk::ConfigurationTemplate";
        
        public ConfigurationTemplateProperties Properties { get; } = new ConfigurationTemplateProperties();
    }
}
