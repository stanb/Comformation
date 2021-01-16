using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Lambda.CodeSigningConfig
{
    /// <summary>
    /// AWS::Lambda::CodeSigningConfig CodeSigningPolicies
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-codesigningconfig-codesigningpolicies.html
    /// </summary>
    public class CodeSigningPolicies
    {

        /// <summary>
        /// UntrustedArtifactOnDeployment
        /// Code signing configuration policy for deployment validation failure. If you set the policy to
        /// Enforce, Lambda blocks the deployment request if signature validation checks fail. If you set the
        /// policy to Warn, Lambda allows the deployment and creates a CloudWatch log.
        /// Default value: Warn
        /// Required: Yes
        /// Type: String
        /// Allowed values: Enforce | Warn
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("UntrustedArtifactOnDeployment")]
        public Union<string, IntrinsicFunction> UntrustedArtifactOnDeployment { get; set; }

    }
}
