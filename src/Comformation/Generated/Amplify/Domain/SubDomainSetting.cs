using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Amplify.Domain
{
    /// <summary>
    /// AWS::Amplify::Domain SubDomainSetting
    /// The SubDomainSetting property type allows you to connect a subdomain (e. g. foo. yourdomain. com) to a
    /// specific branch.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-domain-subdomainsetting.html
    /// </summary>
    public class SubDomainSetting
    {

        /// <summary>
        /// Prefix
        /// Prefix setting for the Subdomain.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Prefix")]
        public Union<string, IntrinsicFunction> Prefix { get; set; }

        /// <summary>
        /// BranchName
        /// Branch name setting for the Subdomain.
        /// Required: Yes
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("BranchName")]
        public Union<string, IntrinsicFunction> BranchName { get; set; }

    }
}
