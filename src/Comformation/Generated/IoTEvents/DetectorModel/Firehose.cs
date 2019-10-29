using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTEvents.DetectorModel
{
    /// <summary>
    /// AWS::IoTEvents::DetectorModel Firehose
    /// Sends information about the detector model instance and the event which triggered the action to a Kinesis Data
    /// Firehose delivery stream.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-firehose.html
    /// </summary>
    public class Firehose
    {

        /// <summary>
        /// DeliveryStreamName
        /// The name of the Kinesis Data Firehose delivery stream where the data is written.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DeliveryStreamName")]
        public Union<string, IntrinsicFunction> DeliveryStreamName { get; set; }

        /// <summary>
        /// Separator
        /// A character separator that is used to separate records written to the Kinesis Data Firehose delivery
        /// stream. Valid values are: &#39;\n&#39; (newline), &#39;\t&#39; (tab), &#39;\r\n&#39; (Windows newline), &#39;,&#39; (comma).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Separator")]
        public Union<string, IntrinsicFunction> Separator { get; set; }

    }
}
