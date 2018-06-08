using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticBeanstalk.ConfigurationTemplate
{
    /// <summary>
    /// AWS Elastic Beanstalk ConfigurationTemplate ConfigurationOptionSetting
    /// The ConfigurationOptionSetting property type specifies an option for an AWS Elastic Beanstalk configuration
    /// template.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-configurationtemplate-configurationoptionsetting.html
    /// </summary>
    public class ConfigurationOptionSetting
    {

        /// <summary>
        /// Namespace
        /// A unique namespace that identifies the option's associated AWS resource. For a list of namespaces
        /// that you can use, see Configuration Options in the AWS Elastic Beanstalk Developer Guide.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Namespace")]
        public Union<string, IntrinsicFunction> Namespace { get; set; }

        /// <summary>
        /// OptionName
        /// The name of the configuration option. For a list of options that you can use, see Configuration
        /// Options in the AWS Elastic Beanstalk Developer Guide.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("OptionName")]
        public Union<string, IntrinsicFunction> OptionName { get; set; }

        /// <summary>
        /// ResourceName
        /// A unique resource name for the option setting. Use this property for a time–based scaling
        /// configuration option.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("ResourceName")]
        public Union<string, IntrinsicFunction> ResourceName { get; set; }

        /// <summary>
        /// Value
        /// The current value for the configuration option.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
