using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.Bucket
{
    /// <summary>
    /// AWS::S3::Bucket OwnershipControls
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-ownershipcontrols.html
    /// </summary>
    public class OwnershipControls
    {

        /// <summary>
        /// Rules
        /// Specifies the container element for object ownership rules.
        /// Required: Yes
        /// Type: List of OwnershipControlsRule
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Rules")]
        public List<OwnershipControlsRule> Rules { get; set; }

    }
}
