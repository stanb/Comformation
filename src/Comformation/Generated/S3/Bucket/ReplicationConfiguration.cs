using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon S3 Bucket ReplicationConfiguration
    /// ReplicationConfiguration is a property of the AWS::S3::Bucket resource that specifies replication rules and
    /// the AWS Identity and Access Management (IAM) role Amazon Simple Storage Service (Amazon S3) uses to replicate
    /// objects.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationconfiguration.html
    /// </summary>
    public class ReplicationConfiguration
    {

        /// <summary>
        /// Role
        /// The Amazon Resource Name (ARN) of an AWS Identity and Access Management (IAM) role that Amazon S3
        /// assumes when replicating objects. For more information, see How to Set Up Cross-Region Replication
        /// in the Amazon Simple Storage Service Developer Guide.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Role")]
        public Union<string, IntrinsicFunction> Role { get; set; }

        /// <summary>
        /// Rules
        /// A replication rule that specifies which objects to replicate and where they are stored.
        /// Required: Yes
        /// Type: List of ReplicationRule
        /// </summary>
        [JsonProperty("Rules")]
        public List<ReplicationRule> Rules { get; set; }

    }
}
