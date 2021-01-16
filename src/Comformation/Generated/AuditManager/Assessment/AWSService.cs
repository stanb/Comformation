using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AuditManager.Assessment
{
    /// <summary>
    /// AWS::AuditManager::Assessment AWSService
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-auditmanager-assessment-awsservice.html
    /// </summary>
    public class AWSService
    {

        /// <summary>
        /// ServiceName
        /// The name of the AWS service.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 40
        /// Pattern: ^[a-zA-Z0-9-\s(). ]+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("ServiceName")]
        public Union<string, IntrinsicFunction> ServiceName { get; set; }

    }
}
