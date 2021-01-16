using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AuditManager.Assessment
{
    /// <summary>
    /// AWS::AuditManager::Assessment Delegation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-auditmanager-assessment-delegation.html
    /// </summary>
    public class Delegation
    {

        /// <summary>
        /// LastUpdated
        /// Specifies when the delegation was last updated.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("LastUpdated")]
        public Union<double, IntrinsicFunction> LastUpdated { get; set; }

        /// <summary>
        /// ControlSetId
        /// The identifier for the associated control set.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 300
        /// Pattern: ^[\w\W\s\S]*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ControlSetId")]
        public Union<string, IntrinsicFunction> ControlSetId { get; set; }

        /// <summary>
        /// CreationTime
        /// Specifies when the delegation was created.
        /// Required: No
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CreationTime")]
        public Union<double, IntrinsicFunction> CreationTime { get; set; }

        /// <summary>
        /// CreatedBy
        /// The IAM user or role that created the delegation.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 100
        /// Pattern: ^[a-zA-Z0-9\s-_()\[\]]+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("CreatedBy")]
        public Union<string, IntrinsicFunction> CreatedBy { get; set; }

        /// <summary>
        /// RoleArn
        /// The Amazon Resource Name (ARN) of the IAM role.
        /// Required: No
        /// Type: String
        /// Minimum: 20
        /// Maximum: 2048
        /// Pattern: ^arn:. *:iam:. *
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// AssessmentName
        /// The name of the associated assessment.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 300
        /// Pattern: ^[\w\W\s\S]*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AssessmentName")]
        public Union<string, IntrinsicFunction> AssessmentName { get; set; }

        /// <summary>
        /// Comment
        /// The comment related to the delegation.
        /// Required: No
        /// Type: String
        /// Maximum: 350
        /// Pattern: ^[\w\W\s\S]*$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Comment")]
        public Union<string, IntrinsicFunction> Comment { get; set; }

        /// <summary>
        /// Id
        /// The unique identifier for the delegation.
        /// Required: No
        /// Type: String
        /// Minimum: 36
        /// Maximum: 36
        /// Pattern: ^[a-f0-9]{8}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{12}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// RoleType
        /// The type of customer persona.
        /// Note In CreateAssessment, RoleType can only be PROCESS_OWNER.
        /// Required: No
        /// Type: String
        /// Allowed values: PROCESS_OWNER | RESOURCE_OWNER
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleType")]
        public Union<string, IntrinsicFunction> RoleType { get; set; }

        /// <summary>
        /// AssessmentId
        /// The identifier for the associated assessment.
        /// Required: No
        /// Type: String
        /// Minimum: 36
        /// Maximum: 36
        /// Pattern: ^[a-f0-9]{8}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{12}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AssessmentId")]
        public Union<string, IntrinsicFunction> AssessmentId { get; set; }

        /// <summary>
        /// Status
        /// The status of the delegation.
        /// Required: No
        /// Type: String
        /// Allowed values: COMPLETE | IN_PROGRESS | UNDER_REVIEW
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Status")]
        public Union<string, IntrinsicFunction> Status { get; set; }

    }
}
