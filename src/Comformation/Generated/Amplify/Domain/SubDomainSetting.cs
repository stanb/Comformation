using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Amplify.Domain
{
    /// <summary>
    /// AWS::Amplify::Domain SubDomainSetting
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-domain-subdomainsetting.html
    /// </summary>
    public class SubDomainSetting
    {

        /// <summary>
        /// Prefix
        /// The prefix setting for the subdomain.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Prefix")]
        public Union<string, IntrinsicFunction> Prefix { get; set; }

        /// <summary>
        /// BranchName
        /// The branch name setting for the subdomain.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BranchName")]
        public Union<string, IntrinsicFunction> BranchName { get; set; }

    }
}
