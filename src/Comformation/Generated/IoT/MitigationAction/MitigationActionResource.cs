using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoT.MitigationAction
{
    /// <summary>
    /// AWS::IoT::MitigationAction
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-mitigationaction.html
    /// </summary>
    public class MitigationActionResource : ResourceBase
    {
        public class MitigationActionProperties
        {
            /// <summary>
            /// ActionName
            /// The friendly name of the mitigation action.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> ActionName { get; set; }

            /// <summary>
            /// RoleArn
            /// The IAM role ARN used to apply this mitigation action.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> RoleArn { get; set; }

            /// <summary>
            /// Tags
            /// Metadata that can be used to manage the mitigation action.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// ActionParams
            /// The set of parameters for this mitigation action. The parameters vary, depending on the kind of
            /// action you apply.
            /// Required: Yes
            /// Type: ActionParams
            /// Update requires: No interruption
            /// </summary>
            public ActionParams ActionParams { get; set; }

        }

        public string Type { get; } = "AWS::IoT::MitigationAction";

        public MitigationActionProperties Properties { get; } = new MitigationActionProperties();

    }

    public static class MitigationActionAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> MitigationActionArn = new ResourceAttribute<Union<string, IntrinsicFunction>>("MitigationActionArn");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> MitigationActionId = new ResourceAttribute<Union<string, IntrinsicFunction>>("MitigationActionId");
    }
}
