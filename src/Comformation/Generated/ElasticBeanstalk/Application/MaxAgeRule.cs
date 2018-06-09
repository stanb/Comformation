using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticBeanstalk.Application
{
    /// <summary>
    /// AWS Elastic Beanstalk Application MaxAgeRule
    /// The MaxAgeRule property type specifies a lifecycle rule that deletes application versions after the specified
    /// number of days for an AWS Elastic Beanstalk application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-maxagerule.html
    /// </summary>
    public class MaxAgeRule
    {

        /// <summary>
        /// DeleteSourceFromS3
        /// Set to true to delete a version&#39;s source bundle from Amazon S3 when Elastic Beanstalk deletes the
        /// application version.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeleteSourceFromS3")]
        public Union<bool, IntrinsicFunction> DeleteSourceFromS3 { get; set; }

        /// <summary>
        /// Enabled
        /// Specify true to apply the rule, or false to disable it.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Enabled")]
        public Union<bool, IntrinsicFunction> Enabled { get; set; }

        /// <summary>
        /// MaxAgeInDays
        /// Specify the number of days to retain an application versions.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxAgeInDays")]
        public Union<int, IntrinsicFunction> MaxAgeInDays { get; set; }

    }
}
