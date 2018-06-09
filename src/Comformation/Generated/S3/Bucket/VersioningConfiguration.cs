using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// Amazon S3 Bucket VersioningConfiguration
    /// Describes the versioning state of an AWS::S3::Bucket resource. For more information, see PUT Bucket versioning
    /// in the Amazon Simple Storage Service API Reference.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-versioningconfig.html
    /// </summary>
    public class VersioningConfiguration
    {

        /// <summary>
        /// Status
        /// The versioning state of an Amazon S3 bucket. If you enable versioning, you must suspend versioning
        /// to disable it.
        /// Valid values include Enabled and Suspended. The default is Suspended.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Status")]
        public Union<string, IntrinsicFunction> Status { get; set; }

    }
}
