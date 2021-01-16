using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// AWS::KinesisFirehose::DeliveryStream OutputFormatConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-outputformatconfiguration.html
    /// </summary>
    public class OutputFormatConfiguration
    {

        /// <summary>
        /// Serializer
        /// Specifies which serializer to use. You can choose either the ORC SerDe or the Parquet SerDe. If both
        /// are non-null, the server rejects the request.
        /// Required: No
        /// Type: Serializer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Serializer")]
        public Serializer Serializer { get; set; }

    }
}
