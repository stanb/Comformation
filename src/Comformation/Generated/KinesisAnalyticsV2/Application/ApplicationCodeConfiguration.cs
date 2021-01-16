using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.KinesisAnalyticsV2.Application
{
    /// <summary>
    /// AWS::KinesisAnalyticsV2::Application ApplicationCodeConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-application-applicationcodeconfiguration.html
    /// </summary>
    public class ApplicationCodeConfiguration
    {

        /// <summary>
        /// CodeContentType
        /// Specifies whether the code content is in text or zip format.
        /// Required: Yes
        /// Type: String
        /// Allowed values: PLAINTEXT | ZIPFILE
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CodeContentType")]
        public Union<string, IntrinsicFunction> CodeContentType { get; set; }

        /// <summary>
        /// CodeContent
        /// The location and type of the application code.
        /// Required: Yes
        /// Type: CodeContent
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CodeContent")]
        public CodeContent CodeContent { get; set; }

    }
}
