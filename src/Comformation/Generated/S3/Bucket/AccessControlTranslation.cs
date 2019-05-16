using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket AccessControlTranslation
    /// Specify this only in a cross-account scenario (where source and destination bucket owners are not the same),
    /// and you want to change replica ownership to the AWS account that owns the destination bucket. If this is not
    /// specified in the replication configuration, the replicas are owned by same AWS account that owns the source
    /// object.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-accesscontroltranslation.html
    /// </summary>
    public class AccessControlTranslation
    {

        /// <summary>
        /// Owner
        /// Specifies the replica ownership. For default and valid values, see PUT bucket replication in the
        /// Amazon Simple Storage Service API Reference.
        /// Required: Yes
        /// Type: String
        /// Allowed Values: Destination
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Owner")]
        public Union<string, IntrinsicFunction> Owner { get; set; }

    }
}
