using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.AuditManager.Assessment
{
    /// <summary>
    /// AWS::AuditManager::Assessment AssessmentReportsDestination
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-auditmanager-assessment-assessmentreportsdestination.html
    /// </summary>
    public class AssessmentReportsDestination
    {

        /// <summary>
        /// Destination
        /// The destination of the assessment report.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 1024
        /// Pattern: ^(S|s)3:\/\/[a-zA-Z0-9-_\/. ]+$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Destination")]
        public Union<string, IntrinsicFunction> Destination { get; set; }

        /// <summary>
        /// DestinationType
        /// The destination type, such as Amazon S3.
        /// Required: No
        /// Type: String
        /// Allowed values: S3
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DestinationType")]
        public Union<string, IntrinsicFunction> DestinationType { get; set; }

    }
}
