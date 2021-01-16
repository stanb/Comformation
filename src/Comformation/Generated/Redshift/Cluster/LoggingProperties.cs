using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Redshift.Cluster
{
    /// <summary>
    /// AWS::Redshift::Cluster LoggingProperties
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshift-cluster-loggingproperties.html
    /// </summary>
    public class LoggingProperties
    {

        /// <summary>
        /// BucketName
        /// The name of an existing S3 bucket where the log files are to be stored.
        /// Constraints:
        /// Must be in the same region as the cluster The cluster must have read bucket and put object
        /// permissions
        /// Required: Yes
        /// Type: String
        /// Maximum: 2147483647
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketName")]
        public Union<string, IntrinsicFunction> BucketName { get; set; }

        /// <summary>
        /// S3KeyPrefix
        /// The prefix applied to the log file names.
        /// Constraints:
        /// Cannot exceed 512 characters Cannot contain spaces( ), double quotes (&quot;), single quotes (&#39;), a
        /// backslash (\), or control characters. The hexadecimal codes for invalid characters are: x00 to x20
        /// x22 x27 x5c x7f or larger
        /// Required: No
        /// Type: String
        /// Maximum: 2147483647
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3KeyPrefix")]
        public Union<string, IntrinsicFunction> S3KeyPrefix { get; set; }

    }
}
