using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket OwnershipControlsRule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-ownershipcontrolsrule.html
    /// </summary>
    public class OwnershipControlsRule
    {

        /// <summary>
        /// ObjectOwnership
        /// Specifies an object ownership rule.
        /// Allowed values: ObjectWriter | BucketOwnerPreferred
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ObjectOwnership")]
        public Union<string, IntrinsicFunction> ObjectOwnership { get; set; }

    }
}
