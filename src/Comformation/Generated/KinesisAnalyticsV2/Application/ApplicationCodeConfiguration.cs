using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// Amazon Kinesis Data Analytics Application ApplicationCodeConfiguration
    /// The ApplicationCodeConfiguration property type specifies a code configuration for a Java-based Kinesis Data
    /// Analytics application.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationcodeconfiguration.html
    /// </summary>
    public class ApplicationCodeConfiguration
    {

        /// <summary>
        /// CodeContentType
        /// The location and type of the application code.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CodeContentType")]
        public Union<string, IntrinsicFunction> CodeContentType { get; set; }

        /// <summary>
        /// CodeContent
        /// Specifies whether the code content is in text or zip format.
        /// Required: Yes
        /// Type: CodeContent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CodeContent")]
        public CodeContent CodeContent { get; set; }

    }
}
