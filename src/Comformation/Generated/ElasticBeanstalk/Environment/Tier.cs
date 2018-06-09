using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticBeanstalk.Environment
{
    /// <summary>
    /// Elastic Beanstalk Environment Tier Property Type
    /// Describes the environment tier for an AWS::ElasticBeanstalk::Environment resource. For more information, see
    /// Environment Tiers in the AWS Elastic Beanstalk Developer Guide.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk-environment-tier.html
    /// </summary>
    public class Tier
    {

        /// <summary>
        /// Name
        /// The name of the environment tier. You can specify WebServer or Worker.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Type
        /// The type of this environment tier. You can specify Standard for the WebServer tier or SQS/HTTP for
        /// the Worker tier.
        /// Required: No
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

        /// <summary>
        /// Version
        /// The version of this environment tier.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Version")]
        public Union<string, IntrinsicFunction> Version { get; set; }

    }
}
