using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.FIS.ExperimentTemplate
{
    /// <summary>
    /// AWS::FIS::ExperimentTemplate
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fis-experimenttemplate.html
    /// </summary>
    public class ExperimentTemplateResource : ResourceBase
    {
        public class ExperimentTemplateProperties
        {
            /// <summary>
            /// Description
            /// A description for the experiment template.
            /// Required: Yes
            /// Type: String
            /// Maximum: 512
            /// Pattern: [\s\S]+
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Targets
            /// The targets for the experiment.
            /// Required: Yes
            /// Type: Map of ExperimentTemplateTarget
            /// Update requires: No interruption
            /// </summary>
            public Dictionary<string, ExperimentTemplateTarget> Targets { get; set; }

            /// <summary>
            /// Actions
            /// The actions for the experiment.
            /// Required: No
            /// Type: Map of ExperimentTemplateAction
            /// Update requires: No interruption
            /// </summary>
            public Dictionary<string, ExperimentTemplateAction> Actions { get; set; }

            /// <summary>
            /// StopConditions
            /// The stop conditions.
            /// Required: Yes
            /// Type: List of ExperimentTemplateStopCondition
            /// Update requires: No interruption
            /// </summary>
            public List<ExperimentTemplateStopCondition> StopConditions { get; set; }

            /// <summary>
            /// RoleArn
            /// The Amazon Resource Name (ARN) of an IAM role that grants the AWS FIS service permission to perform
            /// service actions on your behalf.
            /// Required: Yes
            /// Type: String
            /// Minimum: 20
            /// Maximum: 2048
            /// Pattern: [\S]+
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// Tags
            /// The tags to apply to the experiment template.
            /// Required: Yes
            /// Type: Map of String
            /// Update requires: Replacement
            /// </summary>
            public Dictionary<string, Union<string, IntrinsicFunction>> Tags { get; set; }

        }

        public string Type { get; } = "AWS::FIS::ExperimentTemplate";

        public ExperimentTemplateProperties Properties { get; } = new ExperimentTemplateProperties();

    }

    public static class ExperimentTemplateAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Id = new ResourceAttribute<Union<string, IntrinsicFunction>>("Id");
    }
}
