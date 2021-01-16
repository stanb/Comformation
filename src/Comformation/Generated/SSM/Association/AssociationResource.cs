using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.Association
{
    /// <summary>
    /// AWS::SSM::Association
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-association.html
    /// </summary>
    public class AssociationResource : ResourceBase
    {
        public class AssociationProperties
        {
            /// <summary>
            /// AssociationName
            /// Specify a descriptive name for the association.
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
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> InstanceId { get; set; }

            /// <summary>
            /// Name
            /// The name of the SSM document that contains the configuration information for the instance. You can
            /// specify Command or Automation documents. The documents can be AWS-predefined documents, documents
            /// you created, or a document that is shared with you from another account. For SSM documents that are
            /// shared with you from other AWS accounts, you must specify the complete SSM document ARN, in the
            /// following format:
            /// arn:partition:ssm:region:account-id:document/document-name
            /// For example: arn:aws:ssm:us-east-2:12345678912:document/My-Shared-Document
            /// For AWS-predefined documents and SSM documents you created in your account, you only need to specify
            /// the document name. For example, AWS-ApplyPatchBaseline or My-Document.
            /// Required: Yes
            /// Type: String
            /// Pattern: ^[a-zA-Z0-9_\-. :/]{3,128}$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

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
            /// Update requires: No interruption
            /// </summary>
            public List<Target> Targets { get; set; }

            /// <summary>
            /// OutputLocation
            /// An S3 bucket where you want to store the output details of the request.
            /// Required: No
            /// Type: InstanceAssociationOutputLocation
            /// Update requires: No interruption
            /// </summary>
            public InstanceAssociationOutputLocation OutputLocation { get; set; }

            /// <summary>
            /// AutomationTargetParameterName
            /// Specify the target for the association. This target is required for associations that use an
            /// Automation document and target resources by using rate controls.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 50
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> AutomationTargetParameterName { get; set; }

            /// <summary>
            /// MaxErrors
            /// The number of errors that are allowed before the system stops sending requests to run the
            /// association on additional targets. You can specify either an absolute number of errors, for example
            /// 10, or a percentage of the target set, for example 10%. If you specify 3, for example, the system
            /// stops sending requests when the fourth error is received. If you specify 0, then the system stops
            /// sending requests after the first error is returned. If you run an association on 50 instances and
            /// set MaxError to 10%, then the system stops sending the request when the sixth error is received.
            /// Executions that are already running an association when MaxErrors is reached are allowed to
            /// complete, but some of these executions may fail as well. If you need to ensure that there won&#39;t be
            /// more than max-errors failed executions, set MaxConcurrency to 1 so that executions proceed one at a
            /// time.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 7
            /// Pattern: ^([1-9][0-9]*|[0]|[1-9][0-9]%|[0-9]%|100%)$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> MaxErrors { get; set; }

            /// <summary>
            /// MaxConcurrency
            /// The maximum number of targets allowed to run the association at the same time. You can specify a
            /// number, for example 10, or a percentage of the target set, for example 10%. The default value is
            /// 100%, which means all targets run the association at the same time.
            /// If a new instance starts and attempts to run an association while Systems Manager is running
            /// MaxConcurrency associations, the association is allowed to run. During the next association
            /// interval, the new instance will process its association within the limit specified for
            /// MaxConcurrency.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 7
            /// Pattern: ^([1-9][0-9]*|[1-9][0-9]%|[1-9]%|100%)$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> MaxConcurrency { get; set; }

            /// <summary>
            /// ComplianceSeverity
            /// The severity level that is assigned to the association.
            /// Required: No
            /// Type: String
            /// Allowed values: CRITICAL | HIGH | LOW | MEDIUM | UNSPECIFIED
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> ComplianceSeverity { get; set; }

            /// <summary>
            /// SyncCompliance
            /// The mode for generating association compliance. You can specify AUTO or MANUAL. In AUTO mode, the
            /// system uses the status of the association execution to determine the compliance status. If the
            /// association execution runs successfully, then the association is COMPLIANT. If the association
            /// execution doesn&#39;t run successfully, the association is NON-COMPLIANT.
            /// In MANUAL mode, you must specify the AssociationId as a parameter for the PutComplianceItems API
            /// action. In this case, compliance data is not managed by State Manager. It is managed by your direct
            /// call to the PutComplianceItems API action.
            /// By default, all associations use AUTO mode.
            /// Required: No
            /// Type: String
            /// Allowed values: AUTO | MANUAL
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> SyncCompliance { get; set; }

            /// <summary>
            /// WaitForSuccessTimeoutSeconds
            /// The number of seconds the service should wait for the association status to show &quot;Success&quot; before
            /// proceeding with the stack execution. If the association status doesn&#39;t show &quot;Success&quot; after the
            /// specified number of seconds, then stack creation fails.
            /// Required: No
            /// Type: Integer
            /// Update requires: No interruption
            /// </summary>
            public Union<int, IntrinsicFunction> WaitForSuccessTimeoutSeconds { get; set; }

            /// <summary>
            /// ApplyOnlyAtCronInterval
            /// By default, when you create a new associations, the system runs it immediately after it is created
            /// and then according to the schedule you specified. Specify this option if you don&#39;t want an
            /// association to run immediately after you create it.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> ApplyOnlyAtCronInterval { get; set; }

        }

        public string Type { get; } = "AWS::SSM::Association";

        public AssociationProperties Properties { get; } = new AssociationProperties();

    }

    public static class AssociationAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> AssociationId = new ResourceAttribute<Union<string, IntrinsicFunction>>("AssociationId");
    }
}
