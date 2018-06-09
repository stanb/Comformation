using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentGroup
{
    /// <summary>
    /// AWS CodeDeploy DeploymentGroup Deployment Revision S3Location
    /// S3Location is a property of the AWS CodeDeploy DeploymentGroup Deployment Revision property that specifies the
    /// location of an application revision that is stored in Amazon Simple Storage Service (Amazon S3).
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-deployment-revision-s3location.html
    /// </summary>
    public class S3Location
    {

        /// <summary>
        /// Bucket
        /// The name of the S3 bucket where the application revision is stored.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Bucket")]
        public Union<string, IntrinsicFunction> Bucket { get; set; }

        /// <summary>
        /// BundleType
        /// The file type of the application revision, such as tar, tgz, or zip. For valid values, see
        /// S3Location in the AWS CodeDeploy API Reference.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("BundleType")]
        public Union<string, IntrinsicFunction> BundleType { get; set; }

        /// <summary>
        /// ETag
        /// The Amazon S3 ETag (a file checksum) of the application revision. If you don&#39;t specify a value, AWS
        /// CodeDeploy skips the ETag validation of your application revision.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("ETag")]
        public Union<string, IntrinsicFunction> ETag { get; set; }

        /// <summary>
        /// Key
        /// The file name of the application revision (Amazon S3 object name).
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Version
        /// For versioning-enabled buckets, a specific version of the application revision.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Version")]
        public Union<string, IntrinsicFunction> Version { get; set; }

    }
}
