using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisFirehose.DeliveryStream
{
    /// <summary>
    /// AWS::KinesisFirehose::DeliveryStream InputFormatConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-inputformatconfiguration.html
    /// </summary>
    public class InputFormatConfiguration
    {

        /// <summary>
        /// Deserializer
        /// Specifies which deserializer to use. You can choose either the Apache Hive JSON SerDe or the OpenX
        /// JSON SerDe. If both are non-null, the server rejects the request.
        /// Required: No
        /// Type: Deserializer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Deserializer")]
        public Deserializer Deserializer { get; set; }

    }
}
