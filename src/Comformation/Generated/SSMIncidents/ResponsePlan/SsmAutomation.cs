using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSMIncidents.ResponsePlan
{
    /// <summary>
    /// AWS::SSMIncidents::ResponsePlan SsmAutomation
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmincidents-responseplan-ssmautomation.html
    /// </summary>
    public class SsmAutomation
    {

        /// <summary>
        /// RoleArn
        /// The Amazon Resource Name (ARN) of the role that the automation document will assume when running
        /// commands.
        /// Required: Yes
        /// Type: String
        /// Minimum: 0
        /// Maximum: 1000
        /// Pattern: ^arn:aws(-cn|-us-gov)?:iam::([0-9]{12})?:role/. +$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RoleArn")]
        public Union<string, IntrinsicFunction> RoleArn { get; set; }

        /// <summary>
        /// DocumentName
        /// The automation document&#39;s name.
        /// Required: Yes
        /// Type: String
        /// Pattern: ^[a-zA-Z0-9_\-. :/]{3,128}$
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DocumentName")]
        public Union<string, IntrinsicFunction> DocumentName { get; set; }

        /// <summary>
        /// DocumentVersion
        /// The automation document&#39;s version to use when running.
        /// Required: No
        /// Type: String
        /// Minimum: 0
        /// Maximum: 128
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DocumentVersion")]
        public Union<string, IntrinsicFunction> DocumentVersion { get; set; }

        /// <summary>
        /// TargetAccount
        /// The account that the automation document will be run in. This can be in either the management
        /// account or an application account.
        /// Required: No
        /// Type: String
        /// Allowed values: IMPACTED_ACCOUNT | RESPONSE_PLAN_OWNER_ACCOUNT
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TargetAccount")]
        public Union<string, IntrinsicFunction> TargetAccount { get; set; }

        /// <summary>
        /// Parameters
        /// The key-value pair parameters to use when running the automation document.
        /// Required: No
        /// Type: List of SsmParameter
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Parameters")]
        public List<SsmParameter> Parameters { get; set; }

    }
}
