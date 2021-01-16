using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticBeanstalk.Application
{
    /// <summary>
    /// AWS::ElasticBeanstalk::Application ApplicationVersionLifecycleConfig
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-applicationversionlifecycleconfig.html
    /// </summary>
    public class ApplicationVersionLifecycleConfig
    {

        /// <summary>
        /// MaxAgeRule
        /// Specify a max age rule to restrict the length of time that application versions are retained for an
        /// application.
        /// Required: No
        /// Type: MaxAgeRule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxAgeRule")]
        public MaxAgeRule MaxAgeRule { get; set; }

        /// <summary>
        /// MaxCountRule
        /// Specify a max count rule to restrict the number of application versions that are retained for an
        /// application.
        /// Required: No
        /// Type: MaxCountRule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxCountRule")]
        public MaxCountRule MaxCountRule { get; set; }

    }
}
