using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.AuditManager.Assessment
{
    /// <summary>
    /// AWS::AuditManager::Assessment
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-auditmanager-assessment.html
    /// </summary>
    public class AssessmentResource : ResourceBase
    {
        public class AssessmentProperties
        {
            /// <summary>
            /// FrameworkId
            /// The unique identifier for the framework.
            /// Required: No
            /// Type: String
            /// Minimum: 36
            /// Maximum: 36
            /// Pattern: ^[a-f0-9]{8}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{12}$
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> FrameworkId { get; set; }

            /// <summary>
            /// AwsAccount
            /// The AWS account associated with the assessment.
            /// Required: No
            /// Type: AWSAccount
            /// Update requires: Replacement
            /// </summary>
            public AWSAccount AwsAccount { get; set; }

            /// <summary>
            /// Tags
            /// The tags associated with the assessment.
            /// Required: No
            /// Type: List of Tag
            /// Update requires: No interruption
            /// </summary>
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// Roles
            /// The roles associated with the assessment.
            /// Required: No
            /// Type: List of Role
            /// Update requires: No interruption
            /// </summary>
            public List<Role> Roles { get; set; }

            /// <summary>
            /// Scope
            /// The wrapper of AWS accounts and services in scope for the assessment.
            /// Required: No
            /// Type: Scope
            /// Update requires: No interruption
            /// </summary>
            public Scope Scope { get; set; }

            /// <summary>
            /// AssessmentReportsDestination
            /// The destination in which evidence reports are stored for the specified assessment.
            /// Required: No
            /// Type: AssessmentReportsDestination
            /// Update requires: No interruption
            /// </summary>
            public AssessmentReportsDestination AssessmentReportsDestination { get; set; }

            /// <summary>
            /// Status
            /// The overall status of the assessment.
            /// Required: No
            /// Type: String
            /// Allowed values: ACTIVE | INACTIVE
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Status { get; set; }

            /// <summary>
            /// Name
            /// The name of the assessment.
            /// Required: No
            /// Type: String
            /// Minimum: 1
            /// Maximum: 300
            /// Pattern: ^[^\\]*$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Description
            /// The description of the assessment.
            /// Required: No
            /// Type: String
            /// Maximum: 1000
            /// Pattern: ^[\w\W\s\S]*$
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

        }

        public string Type { get; } = "AWS::AuditManager::Assessment";

        public AssessmentProperties Properties { get; } = new AssessmentProperties();

    }

    public static class AssessmentAttributes
    {
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> AssessmentId = new ResourceAttribute<Union<string, IntrinsicFunction>>("AssessmentId");
        public static readonly ResourceAttribute<Union<string, IntrinsicFunction>> Arn = new ResourceAttribute<Union<string, IntrinsicFunction>>("Arn");
        public static readonly ResourceAttribute<List<Delegation>> Delegations = new ResourceAttribute<List<Delegation>>("Delegations");
        public static readonly ResourceAttribute<Union<double, IntrinsicFunction>> CreationTime = new ResourceAttribute<Union<double, IntrinsicFunction>>("CreationTime");
    }
}
