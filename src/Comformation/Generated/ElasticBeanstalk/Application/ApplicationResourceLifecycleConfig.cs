using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticBeanstalk.Application
{
    /// <summary>
    /// AWS::ElasticBeanstalk::Application ApplicationResourceLifecycleConfig
    /// The resource lifecycle configuration for an application. Defines lifecycle settings for resources that belong
    /// to the application, and the service role that Elastic Beanstalk assumes in order to apply lifecycle settings.
    /// The version lifecycle configuration defines lifecycle settings for application versions.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-applicationresourcelifecycleconfig.html
    /// </summary>
    public class ApplicationResourceLifecycleConfig
    {

        /// <summary>
        /// ServiceRole
        /// The ARN of an IAM service role that Elastic Beanstalk has permission to assume.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceRole")]
        public Union<string, IntrinsicFunction> ServiceRole { get; set; }

        /// <summary>
        /// VersionLifecycleConfig
        /// Defines lifecycle settings for application versions.
        /// Required: No
        /// Type: ApplicationVersionLifecycleConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("VersionLifecycleConfig")]
        public ApplicationVersionLifecycleConfig VersionLifecycleConfig { get; set; }

    }
}
