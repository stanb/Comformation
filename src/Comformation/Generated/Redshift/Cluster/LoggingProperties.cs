using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Redshift.Cluster
{
    /// <summary>
    /// Amazon Redshift LoggingProperties
    /// Use the LoggingProperties property of the AWS::Redshift::Cluster resource to configure audit log files,
    /// containing information such as queries and connection attempts, for the cluster.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-cluster-loggingproperties.html
    /// </summary>
    public class LoggingProperties
    {

        /// <summary>
        /// BucketName
        /// The name of an existing S3 bucket where the log files are to be stored.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketName")]
        public Union<string, IntrinsicFunction> BucketName { get; set; }

        /// <summary>
        /// S3KeyPrefix
        /// The prefix applied to the log file names.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3KeyPrefix")]
        public Union<string, IntrinsicFunction> S3KeyPrefix { get; set; }

    }
}
