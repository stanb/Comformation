using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::Application InputProcessingConfiguration
    /// For an SQL-based Amazon Kinesis Data Analytics application, describes a processor that is used to preprocess
    /// the records in the stream before being processed by your application code. Currently, the only input processor
    /// available is AWS Lambda.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-inputprocessingconfiguration.html
    /// </summary>
    public class InputProcessingConfiguration
    {

        /// <summary>
        /// InputLambdaProcessor
        /// The InputLambdaProcessor that is used to preprocess the records in the stream before being processed
        /// by your application code.
        /// Required: No
        /// Type: InputLambdaProcessor
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputLambdaProcessor")]
        public InputLambdaProcessor InputLambdaProcessor { get; set; }

    }
}
