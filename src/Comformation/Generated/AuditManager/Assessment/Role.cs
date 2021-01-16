using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AuditManager.Assessment
{
    /// <summary>
    /// AWS::AuditManager::Assessment Role
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-auditmanager-assessment-role.html
    /// </summary>
    public class Role
    {

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

    }
}
