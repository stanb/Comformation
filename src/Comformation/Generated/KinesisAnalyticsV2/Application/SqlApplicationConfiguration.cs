using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// Amazon Kinesis Data Analytics Application SqlApplicationConfiguration
    /// The SqlApplicationConfiguration property type specifies the inputs, outputs, and reference data sources for an
    /// SQL-based Kinesis Data Analytics application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-sqlapplicationconfiguration.html
    /// </summary>
    public class SqlApplicationConfiguration
    {

        /// <summary>
        /// Inputs
        /// The array of input objects describing the input streams used by the application.
        /// Required: No
        /// Type: List of Input
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Inputs")]
        public List<Input> Inputs { get; set; }

    }
}
