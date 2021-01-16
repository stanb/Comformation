using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ElasticBeanstalk.Application
{
    /// <summary>
    /// AWS::ElasticBeanstalk::Application MaxCountRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-maxcountrule.html
    /// </summary>
    public class MaxCountRule
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
        /// MaxCount
        /// Specify the maximum number of application versions to retain.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxCount")]
        public Union<int, IntrinsicFunction> MaxCount { get; set; }

    }
}
