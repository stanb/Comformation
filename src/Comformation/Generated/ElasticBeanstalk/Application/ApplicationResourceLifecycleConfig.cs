using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticBeanstalk.Application
{
    /// <summary>
    /// AWS Elastic Beanstalk Application ApplicationResourceLifecycleConfig
    /// The ApplicationResourceLifecycleConfig property type specifies lifecycle settings for resources that belong to
    /// the application, and the service role that AWS Elastic Beanstalk assumes in order to apply lifecycle settings.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-applicationresourcelifecycleconfig.html
    /// </summary>
    public class ApplicationResourceLifecycleConfig
    {

        /// <summary>
        /// ServiceRole
        /// The ARN of an IAM service role that Elastic Beanstalk has permission to assume.
        /// Required: Conditional. If you specify the VersionLifecycleConfig property, you must specify this
        /// property.
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceRole")]
        public Union<string, IntrinsicFunction> ServiceRole { get; set; }

        /// <summary>
        /// VersionLifecycleConfig
        /// Defines lifecycle settings for application versions.
        /// Required: No
        /// Type: Elastic Beanstalk Application ApplicationVersionLifecycleConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VersionLifecycleConfig")]
        public ApplicationVersionLifecycleConfig VersionLifecycleConfig { get; set; }

    }
}
