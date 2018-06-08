using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticBeanstalk.ConfigurationTemplate
{
    /// <summary>
    /// AWS Elastic Beanstalk ConfigurationTemplate SourceConfiguration
    /// Use settings from another Elastic Beanstalk configuration template for the
    /// AWS::ElasticBeanstalk::ConfigurationTemplate resource type.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk-configurationtemplate-sourceconfiguration.html
    /// </summary>
    public class SourceConfiguration
    {

        /// <summary>
        /// ApplicationName
        /// The name of the Elastic Beanstalk application that contains the configuration template that you want
        /// to use.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("ApplicationName")]
        public Union<string, IntrinsicFunction> ApplicationName { get; set; }

        /// <summary>
        /// TemplateName
        /// The name of the configuration template.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("TemplateName")]
        public Union<string, IntrinsicFunction> TemplateName { get; set; }

    }
}
