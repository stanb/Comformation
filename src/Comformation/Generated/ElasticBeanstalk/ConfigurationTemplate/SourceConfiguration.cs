using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticBeanstalk.ConfigurationTemplate
{
    /// <summary>
    /// AWS::ElasticBeanstalk::ConfigurationTemplate SourceConfiguration
    /// An AWS Elastic Beanstalk configuration template to base a new one on. You can use it to define a
    /// AWS::ElasticBeanstalk::ConfigurationTemplate resource.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-configurationtemplate-sourceconfiguration.html
    /// </summary>
    public class SourceConfiguration
    {

        /// <summary>
        /// ApplicationName
        /// The name of the application associated with the configuration.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ApplicationName")]
        public Union<string, IntrinsicFunction> ApplicationName { get; set; }

        /// <summary>
        /// TemplateName
        /// The name of the configuration template.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 100
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TemplateName")]
        public Union<string, IntrinsicFunction> TemplateName { get; set; }

    }
}
