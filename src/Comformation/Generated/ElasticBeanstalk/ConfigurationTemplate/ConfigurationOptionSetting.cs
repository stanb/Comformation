using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticBeanstalk.ConfigurationTemplate
{
    /// <summary>
    /// AWS::ElasticBeanstalk::ConfigurationTemplate ConfigurationOptionSetting
    /// The ConfigurationOptionSetting property type specifies an option for an AWS Elastic Beanstalk configuration
    /// template.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-configurationtemplate-configurationoptionsetting.html
    /// </summary>
    public class ConfigurationOptionSetting
    {

        /// <summary>
        /// Namespace
        /// A unique namespace that identifies the option&#39;s associated AWS resource.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Namespace")]
        public Union<string, IntrinsicFunction> Namespace { get; set; }

        /// <summary>
        /// OptionName
        /// The name of the configuration option.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OptionName")]
        public Union<string, IntrinsicFunction> OptionName { get; set; }

        /// <summary>
        /// ResourceName
        /// A unique resource name for the option setting. Use it for a time–based scaling configuration option.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 256
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ResourceName")]
        public Union<string, IntrinsicFunction> ResourceName { get; set; }

        /// <summary>
        /// Value
        /// The current value for the configuration option.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
