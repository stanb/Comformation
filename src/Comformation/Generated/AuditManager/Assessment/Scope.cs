using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AuditManager.Assessment
{
    /// <summary>
    /// AWS::AuditManager::Assessment Scope
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-auditmanager-assessment-scope.html
    /// </summary>
    public class Scope
    {

        /// <summary>
        /// AwsAccounts
        /// The AWS accounts included in the scope of the assessment.
        /// Required: No
        /// Type: List of AWSAccount
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AwsAccounts")]
        public List<AWSAccount> AwsAccounts { get; set; }

        /// <summary>
        /// AwsServices
        /// The AWS services included in the scope of the assessment.
        /// Required: No
        /// Type: List of AWSService
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("AwsServices")]
        public List<AWSService> AwsServices { get; set; }

    }
}
