using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalytics.Application
{
    /// <summary>
    /// Amazon Kinesis Data Analytics Application InputProcessingConfiguration
    /// The InputProcessingConfiguration property type specifies a processing configuration for a Kinesis Data
    /// Analytics Application Input for an Amazon Kinesis Data Analytics application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-inputprocessingconfiguration.html
    /// </summary>
    public class InputProcessingConfiguration
    {

        /// <summary>
        /// InputLambdaProcessor
        /// The InputLambdaProcessor that is used to preprocess the records in the stream before they are
        /// processed by your application code.
        /// Required: No
        /// Type: Kinesis Data Analytics Application InputLambdaProcessor
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("InputLambdaProcessor")]
        public Union<InputLambdaProcessor, IntrinsicFunction> InputLambdaProcessor { get; set; }

    }
}
