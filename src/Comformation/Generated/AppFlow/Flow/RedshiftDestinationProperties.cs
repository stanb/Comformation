using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AppFlow.Flow
{
    /// <summary>
    /// AWS::AppFlow::Flow RedshiftDestinationProperties
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-redshiftdestinationproperties.html
    /// </summary>
    public class RedshiftDestinationProperties
    {

        /// <summary>
        /// Object
        /// The object specified in the Amazon Redshift flow destination.
        /// Required: Yes
        /// Type: String
        /// Maximum: 512
        /// Pattern: \S+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Object")]
        public Union<string, IntrinsicFunction> Object { get; set; }

        /// <summary>
        /// IntermediateBucketName
        /// The intermediate bucket that Amazon AppFlow uses when moving data into Amazon Redshift.
        /// Required: Yes
        /// Type: String
        /// Minimum: 3
        /// Maximum: 63
        /// Pattern: \S+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IntermediateBucketName")]
        public Union<string, IntrinsicFunction> IntermediateBucketName { get; set; }

        /// <summary>
        /// BucketPrefix
        /// The object key for the bucket in which Amazon AppFlow places the destination files.
        /// Required: No
        /// Type: String
        /// Maximum: 512
        /// Pattern: . *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BucketPrefix")]
        public Union<string, IntrinsicFunction> BucketPrefix { get; set; }

        /// <summary>
        /// ErrorHandlingConfig
        /// The settings that determine how Amazon AppFlow handles an error when placing data in the Amazon
        /// Redshift destination. For example, this setting would determine if the flow should fail after one
        /// insertion error, or continue and attempt to insert every record regardless of the initial failure.
        /// ErrorHandlingConfig is a part of the destination connector details.
        /// Required: No
        /// Type: ErrorHandlingConfig
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ErrorHandlingConfig")]
        public ErrorHandlingConfig ErrorHandlingConfig { get; set; }

    }
}
