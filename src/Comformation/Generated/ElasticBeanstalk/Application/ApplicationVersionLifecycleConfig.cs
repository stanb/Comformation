using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticBeanstalk.Application
{
    /// <summary>
    /// AWS Elastic Beanstalk Application ApplicationVersionLifecycleConfig
    /// The ApplicationVersionLifecycleConfig property type specifies the application version lifecycle settings for
    /// an AWS Elastic Beanstalk application. It defines the rules that Elastic Beanstalk applies to an application's
    /// versions in order to avoid hitting the per-region limit for application versions.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-applicationversionlifecycleconfig.html
    /// </summary>
    public class ApplicationVersionLifecycleConfig
    {

        /// <summary>
        /// MaxAgeRule
        /// Specifies a max age rule to restrict the length of time that application versions are retained for
        /// an application.
        /// Required: No
        /// Type: Elastic Beanstalk Application MaxAgeRule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxAgeRule")]
        public Union<MaxAgeRule, IntrinsicFunction> MaxAgeRule { get; set; }

        /// <summary>
        /// MaxCountRule
        /// Specifies a max count rule to restrict the number of application versions that are retained for an
        /// application.
        /// Required: No
        /// Type: Elastic Beanstalk Application MaxCountRule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxCountRule")]
        public Union<MaxCountRule, IntrinsicFunction> MaxCountRule { get; set; }

    }
}
