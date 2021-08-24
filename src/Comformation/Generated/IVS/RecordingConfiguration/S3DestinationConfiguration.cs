using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IVS.RecordingConfiguration
{
    /// <summary>
    /// AWS::IVS::RecordingConfiguration S3DestinationConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-recordingconfiguration-s3destinationconfiguration.html
    /// </summary>
    public class S3DestinationConfiguration
    {

        /// <summary>
        /// BucketName
        /// Location (S3 bucket name) where recorded videos will be stored.
        /// Required: Yes
        /// Type: String
        /// Minimum: 3
        /// Maximum: 63
        /// Pattern: ^[a-z0-9-. ]+$
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("BucketName")]
        public Union<string, IntrinsicFunction> BucketName { get; set; }

    }
}
