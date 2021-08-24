using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IVS.RecordingConfiguration
{
    /// <summary>
    /// AWS::IVS::RecordingConfiguration DestinationConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-recordingconfiguration-destinationconfiguration.html
    /// </summary>
    public class DestinationConfiguration
    {

        /// <summary>
        /// S3
        /// An S3 destination configuration where recorded videos will be stored. See the
        /// S3DestinationConfiguration property type for more information.
        /// Required: Yes
        /// Type: S3DestinationConfiguration
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("S3")]
        public S3DestinationConfiguration S3 { get; set; }

    }
}
