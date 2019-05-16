using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::Application InputParallelism
    /// For an SQL-based Amazon Kinesis Data Analytics application, describes the number of in-application streams to
    /// create for a given streaming source.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-inputparallelism.html
    /// </summary>
    public class InputParallelism
    {

        /// <summary>
        /// Count
        /// The number of in-application streams to create.
        /// Required: No
        /// Type: Integer
        /// Minimum: 1
        /// Maximum: 64
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Count")]
        public Union<int, IntrinsicFunction> Count { get; set; }

    }
}
