using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.Association
{
    /// <summary>
    /// AWS::SSM::Association
    /// The AWS::SSM::Association resource associates an SSM document in AWS Systems Manager with managed instances
    /// that contain a configuration agent to process the document.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-association.html
    /// </summary>
    public class AssociationResource : ResourceBase
    {
        public class AssociationProperties
        {
            /// <summary>
            /// AssociationName
            /// The name of the association.
            /// Required: No
            /// Type: String
            /// Pattern: ^[a-zA-Z0-9_\-. ]{3,128}$
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> AssociationName { get; set; }

            /// <summary>
            /// DocumentVersion
            /// The version of the SSM document to associate with the target.
            /// Required: No
            /// Type: String
            /// Pattern: ([$]LATEST|[$]DEFAULT|^[1-9][0-9]*$)
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> DocumentVersion { get; set; }

            /// <summary>
            /// InstanceId
            /// The ID of the instance that the SSM document is associated with. You must specify the InstanceId or
            /// Targets property.
            /// Note InstanceId has been deprecated. To specify an instance ID for an association, use the Targets
            /// parameter. If you use the parameter InstanceId, you cannot use the parameters AssociationName,
            /// DocumentVersion, MaxErrors, MaxConcurrency, OutputLocation, or ScheduleExpression. To use these
            /// parameters, you must use the Targets parameter.
            /// Required: Conditional
            /// Type: String
            /// Pattern: (^i-(\w{8}|\w{17})$)|(^mi-\w{17}$)
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> InstanceId { get; set; }

            /// <summary>
            /// Name
            /// The name of the Systems Manager document.
            /// Required: Yes
            /// Type: String
            /// Pattern: ^[a-zA-Z0-9_\-. :/]{3,128}$
            /// Update requires: Replacement
            /// </summary>
			public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// OutputLocation
            /// An Amazon S3 bucket where you want to store the output details of the request.
            /// Required: No
            /// Type: InstanceAssociationOutputLocation
            /// Update requires: No interruption
            /// </summary>
			public InstanceAssociationOutputLocation OutputLocation { get; set; }

            /// <summary>
            /// Parameters
            /// The parameters for the runtime configuration of the document.
            /// Required: No
            /// Type: Map of ParameterValues
            /// Update requires: No interruption
            /// </summary>
			public Dictionary<string, ParameterValues> Parameters { get; set; }

            /// <summary>
            /// ScheduleExpression
            /// A cron expression that specifies a schedule when the association runs.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 256
            /// Update requires: No interruption
            /// </summary>
			public Union<string, IntrinsicFunction> ScheduleExpression { get; set; }

            /// <summary>
            /// Targets
            /// The targets for the association. You must specify the InstanceId or Targets property.
            /// Required: Conditional
            /// Type: List of Target
            /// Maximum: 5
            /// Update requires: Replacement
            /// </summary>
			public List<Target> Targets { get; set; }

        }

        public string Type { get; } = "AWS::SSM::Association";

        public AssociationProperties Properties { get; } = new AssociationProperties();

    }
}
