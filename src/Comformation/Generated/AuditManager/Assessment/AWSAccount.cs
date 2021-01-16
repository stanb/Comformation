using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AuditManager.Assessment
{
    /// <summary>
    /// AWS::AuditManager::Assessment AWSAccount
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-auditmanager-assessment-awsaccount.html
    /// </summary>
    public class AWSAccount
    {

        /// <summary>
        /// Id
        /// The identifier for the specified AWS account.
        /// Required: No
        /// Type: String
        /// Minimum: 12
        /// Maximum: 12
        /// Pattern: ^[0-9]{12}$
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Id")]
        public Union<string, IntrinsicFunction> Id { get; set; }

        /// <summary>
        /// EmailAddress
        /// The email address associated with the specified AWS account.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 320
        /// Pattern: ^. *@. *$
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("EmailAddress")]
        public Union<string, IntrinsicFunction> EmailAddress { get; set; }

        /// <summary>
        /// Name
        /// The name of the specified AWS account.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 50
        /// Pattern: ^[\u0020-\u007E]+$
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
