using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticBeanstalk.Application
{
    /// <summary>
    /// AWS::ElasticBeanstalk::Application ApplicationResourceLifecycleConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-applicationresourcelifecycleconfig.html
    /// </summary>
    public class ApplicationResourceLifecycleConfig
    {

        /// <summary>
        /// ServiceRole
        /// The ARN of an IAM service role that Elastic Beanstalk has permission to assume.
        /// The ServiceRole property is required the first time that you provide a ResourceLifecycleConfig for
        /// the application. After you provide it once, Elastic Beanstalk persists the Service Role with the
        /// application, and you don&#39;t need to specify it again. You can, however, specify it in subsequent
        /// updates to change the Service Role to another value.
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
