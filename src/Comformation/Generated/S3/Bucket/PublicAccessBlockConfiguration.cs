using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket PublicAccessBlockConfiguration
    /// Specifies the Block Public Access configuration for an Amazon S3 bucket.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-publicaccessblockconfiguration.html
    /// </summary>
    public class PublicAccessBlockConfiguration
    {

        /// <summary>
        /// BlockPublicAcls
        /// Specifies whether Amazon S3 should block public access control lists (ACLs) for this bucket and
        /// objects in this bucket. Setting this element to TRUE causes the following behavior:
        /// PUT Bucket acl and PUT Object acl calls fail if the specified ACL is public. PUT Object calls fail
        /// if the request includes a public ACL.
        /// Enabling this setting doesn&#39;t affect existing policies or ACLs.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BlockPublicAcls")]
        public Union<bool, IntrinsicFunction> BlockPublicAcls { get; set; }

        /// <summary>
        /// BlockPublicPolicy
        /// Specifies whether Amazon S3 should block public bucket policies for this bucket. Setting this
        /// element to TRUE causes Amazon S3 to reject calls to PUT Bucket policy if the specified bucket policy
        /// allows public access.
        /// Enabling this setting doesn&#39;t affect existing bucket policies.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BlockPublicPolicy")]
        public Union<bool, IntrinsicFunction> BlockPublicPolicy { get; set; }

        /// <summary>
        /// IgnorePublicAcls
        /// Specifies whether Amazon S3 should ignore public ACLs for this bucket and objects in this bucket.
        /// Setting this element to TRUE causes Amazon S3 to ignore all public ACLs on this bucket and objects
        /// in this bucket.
        /// Enabling this setting doesn&#39;t affect the persistence of any existing ACLs and doesn&#39;t prevent new
        /// public ACLs from being set.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IgnorePublicAcls")]
        public Union<bool, IntrinsicFunction> IgnorePublicAcls { get; set; }

        /// <summary>
        /// RestrictPublicBuckets
        /// Specifies whether Amazon S3 should restrict public bucket policies for this bucket. Setting this
        /// element to TRUE restricts access to this bucket to only AWS services and authorized users within
        /// this account if the bucket has a public policy.
        /// Enabling this setting doesn&#39;t affect previously stored bucket policies, except that public and
        /// cross-account access within any public bucket policy, including non-public delegation to specific
        /// accounts, is blocked.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RestrictPublicBuckets")]
        public Union<bool, IntrinsicFunction> RestrictPublicBuckets { get; set; }

    }
}
