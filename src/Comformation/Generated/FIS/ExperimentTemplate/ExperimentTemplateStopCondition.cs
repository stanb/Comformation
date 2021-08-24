using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.FIS.ExperimentTemplate
{
    /// <summary>
    /// AWS::FIS::ExperimentTemplate ExperimentTemplateStopCondition
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fis-experimenttemplate-experimenttemplatestopcondition.html
    /// </summary>
    public class ExperimentTemplateStopCondition
    {

        /// <summary>
        /// Source
        /// The source for the stop condition. Specify aws:cloudwatch:alarm if the stop condition is defined by
        /// a CloudWatch alarm. Specify none if there is no stop condition.
        /// Required: Yes
        /// Type: String
        /// Maximum: 64
        /// Pattern: [\S]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Source")]
        public Union<string, IntrinsicFunction> Source { get; set; }

        /// <summary>
        /// Value
        /// The Amazon Resource Name (ARN) of the CloudWatch alarm. This is required if the source is a
        /// CloudWatch alarm.
        /// Required: No
        /// Type: String
        /// Minimum: 20
        /// Maximum: 2048
        /// Pattern: [\s\S]+
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Value")]
        public Union<string, IntrinsicFunction> Value { get; set; }

    }
}
