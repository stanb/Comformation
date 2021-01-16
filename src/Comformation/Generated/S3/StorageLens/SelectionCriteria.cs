using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.S3.StorageLens
{
    /// <summary>
    /// AWS::S3::StorageLens SelectionCriteria
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-selectioncriteria.html
    /// </summary>
    public class SelectionCriteria
    {

        /// <summary>
        /// MaxDepth
        /// This property contains the details of the max depth that S3 Storage Lens will collect metrics up to.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MaxDepth")]
        public Union<int, IntrinsicFunction> MaxDepth { get; set; }

        /// <summary>
        /// Delimiter
        /// This property contains the details of the S3 Storage Lens delimiter being used.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Delimiter")]
        public Union<string, IntrinsicFunction> Delimiter { get; set; }

        /// <summary>
        /// MinStorageBytesPercentage
        /// This property contains the details of the minimum storage bytes percentage threshold that S3 Storage
        /// Lens will collect metrics up to.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("MinStorageBytesPercentage")]
        public Union<double, IntrinsicFunction> MinStorageBytesPercentage { get; set; }

    }
}
