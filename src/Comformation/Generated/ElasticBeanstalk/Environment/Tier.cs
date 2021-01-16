using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticBeanstalk.Environment
{
    /// <summary>
    /// AWS::ElasticBeanstalk::Environment Tier
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk-environment-tier.html
    /// </summary>
    public class Tier
    {

        /// <summary>
        /// Name
        /// The name of this environment tier.
        /// Valid values:
        /// For Web server tier – WebServer For Worker tier – Worker
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Type
        /// The type of this environment tier.
        /// Valid values:
        /// For Web server tier – Standard For Worker tier – SQS/HTTP
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Version
        /// The version of this environment tier. When you don&#39;t set a value to it, Elastic Beanstalk uses the
        /// latest compatible worker tier version.
        /// Note This member is deprecated. Any specific version that you set may become out of date. We
        /// recommend leaving it unspecified.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Version")]
        public Union<string, IntrinsicFunction> Version { get; set; }

    }
}
