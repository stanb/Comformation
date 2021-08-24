using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket ReplicationConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationconfiguration.html
    /// </summary>
    public class ReplicationConfiguration
    {

        /// <summary>
        /// Role
        /// The Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM) role that Amazon S3
        /// assumes when replicating objects. For more information, see How to Set Up Replication in the Amazon
        /// S3 User Guide.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Role")]
        public Union<string, IntrinsicFunction> Role { get; set; }

        /// <summary>
        /// Rules
        /// A container for one or more replication rules. A replication configuration must have at least one
        /// rule and can contain a maximum of 1,000 rules.
        /// Required: Yes
        /// Type: List of ReplicationRule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Rules")]
        public List<ReplicationRule> Rules { get; set; }

    }
}
