using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTSiteWise.AccessPolicy
{
    /// <summary>
    /// AWS::IoTSiteWise::AccessPolicy AccessPolicyIdentity
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-accesspolicy-accesspolicyidentity.html
    /// </summary>
    public class AccessPolicyIdentity
    {

        /// <summary>
        /// User
        /// The AWS SSO user to which this access policy maps.
        /// Required: No
        /// Type: User
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("User")]
        public User User { get; set; }

        /// <summary>
        /// IamUser
        /// An IAM user identity.
        /// Required: No
        /// Type: IamUser
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IamUser")]
        public IamUser IamUser { get; set; }

        /// <summary>
        /// IamRole
        /// An IAM role identity.
        /// Required: No
        /// Type: IamRole
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("IamRole")]
        public IamRole IamRole { get; set; }

    }
}
