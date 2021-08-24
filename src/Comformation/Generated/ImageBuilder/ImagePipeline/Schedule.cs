using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.ImageBuilder.ImagePipeline
{
    /// <summary>
    /// AWS::ImageBuilder::ImagePipeline Schedule
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-imagepipeline-schedule.html
    /// </summary>
    public class Schedule
    {

        /// <summary>
        /// ScheduleExpression
        /// 		
        /// The cron expression determines how often EC2 Image Builder evaluates your
        /// 			pipelineExecutionStartCondition.
        /// 		
        /// For information on how to format a cron expression in Image Builder, see Use cron 			expressions in
        /// EC2 Image Builder.
        /// 	
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ScheduleExpression")]
        public Union<string, IntrinsicFunction> ScheduleExpression { get; set; }

        /// <summary>
        /// PipelineExecutionStartCondition
        /// The condition configures when the pipeline should trigger a new image build. When the 	
        /// pipelineExecutionStartCondition is set to 	 EXPRESSION_MATCH_AND_DEPENDENCY_UPDATES_AVAILABLE, and
        /// you use semantic version 			filters on the source image or components in your image recipe, Image
        /// Builder will build a 			new image only when there are new versions of the image or components in
        /// your recipe that 			match the semantic version filter. When it is set to EXPRESSION_MATCH_ONLY, it
        /// 			will build a new image every time the CRON expression matches the current time. For semantic
        /// 			version syntax, see CreateComponent 	in the Image Builder API Reference.
        /// Required: No
        /// Type: String
        /// Allowed values: EXPRESSION_MATCH_AND_DEPENDENCY_UPDATES_AVAILABLE | EXPRESSION_MATCH_ONLY
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PipelineExecutionStartCondition")]
        public Union<string, IntrinsicFunction> PipelineExecutionStartCondition { get; set; }

    }
}
