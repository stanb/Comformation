using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalytics.Application
{
    /// <summary>
    ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-input.html
    /// </summary>
    public class Input
    {

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-input.html#cfn-kinesisanalytics-application-input-nameprefix
        /// </summary>
        [JsonProperty("NamePrefix")]
        public Union<string, IntrinsicFunction> NamePrefix { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-input.html#cfn-kinesisanalytics-application-input-inputschema
        /// </summary>
        [JsonProperty("InputSchema")]
        public Union<InputSchema, IntrinsicFunction> InputSchema { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-input.html#cfn-kinesisanalytics-application-input-kinesisstreamsinput
        /// </summary>
        [JsonProperty("KinesisStreamsInput")]
        public Union<KinesisStreamsInput, IntrinsicFunction> KinesisStreamsInput { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-input.html#cfn-kinesisanalytics-application-input-kinesisfirehoseinput
        /// </summary>
        [JsonProperty("KinesisFirehoseInput")]
        public Union<KinesisFirehoseInput, IntrinsicFunction> KinesisFirehoseInput { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-input.html#cfn-kinesisanalytics-application-input-inputprocessingconfiguration
        /// </summary>
        [JsonProperty("InputProcessingConfiguration")]
        public Union<InputProcessingConfiguration, IntrinsicFunction> InputProcessingConfiguration { get; set; }

        /// <summary>
        ///  http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-input.html#cfn-kinesisanalytics-application-input-inputparallelism
        /// </summary>
        [JsonProperty("InputParallelism")]
        public Union<InputParallelism, IntrinsicFunction> InputParallelism { get; set; }

    }
}
