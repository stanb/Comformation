using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodeDeploy.DeploymentGroup
{
    /// <summary>
    /// AWS::CodeDeploy::DeploymentGroup S3Location
    /// S3Location is a property of the CodeDeploy DeploymentGroup Revision property that specifies the location of an
    /// application revision that is stored in Amazon Simple Storage Service (S3).
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codedeploy-deploymentgroup-deployment-revision-s3location.html
    /// </summary>
    public class S3Location
    {

        /// <summary>
        /// Bucket
        /// The name of the Amazon S3 bucket where the application revision is stored.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Bucket")]
        public Union<string, IntrinsicFunction> Bucket { get; set; }

        /// <summary>
        /// BundleType
        /// The file type of the application revision. Must be one of the following:
        /// JSON tar: A tar archive file. tgz: A compressed tar archive file. YAML zip: A zip archive file.
        /// Required: No
        /// Type: String
        /// Allowed Values: JSON | YAML | tar | tgz | zip
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BundleType")]
        public Union<string, IntrinsicFunction> BundleType { get; set; }

        /// <summary>
        /// ETag
        /// The ETag of the Amazon S3 object that represents the bundled artifacts for the application revision.
        /// If the ETag is not specified as an input parameter, ETag validation of the object is skipped.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ETag")]
        public Union<string, IntrinsicFunction> ETag { get; set; }

        /// <summary>
        /// Key
        /// The name of the Amazon S3 object that represents the bundled artifacts for the application revision.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<string, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Version
        /// A specific version of the Amazon S3 object that represents the bundled artifacts for the application
        /// revision.
        /// If the version is not specified, the system uses the most recent version by default.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Version")]
        public Union<string, IntrinsicFunction> Version { get; set; }

    }
}
