using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// Amazon Kinesis Data Analytics Application InputParallelism
    /// The InputParallelism property type specifies the number of in-application streams to create for a given
    /// streaming source for an SQL-based Amazon Kinesis Data Analytics application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-inputparallelism.html
    /// </summary>
    public class InputParallelism
    {

        /// <summary>
        /// Count
        /// The number of in-application streams to create.
        /// Required: No
        /// Type: Integer
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Count")]
        public Union<int, IntrinsicFunction> Count { get; set; }

    }
}