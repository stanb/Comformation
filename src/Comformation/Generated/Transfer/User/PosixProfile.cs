using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Transfer.User
{
    /// <summary>
    /// AWS::Transfer::User PosixProfile
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transfer-user-posixprofile.html
    /// </summary>
    public class PosixProfile
    {

        /// <summary>
        /// Uid
        /// The POSIX user ID used for all EFS operations by this user.
        /// Required: Yes
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Uid")]
        public Union<double, IntrinsicFunction> Uid { get; set; }

        /// <summary>
        /// SecondaryGids
        /// The secondary POSIX group IDs used for all EFS operations by this user.
        /// Required: No
        /// Type: List of Double
        /// Maximum: 16
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("SecondaryGids")]
        public List<Union<double, IntrinsicFunction>> SecondaryGids { get; set; }

        /// <summary>
        /// Gid
        /// The POSIX group ID used for all EFS operations by this user.
        /// Required: Yes
        /// Type: Double
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Gid")]
        public Union<double, IntrinsicFunction> Gid { get; set; }

    }
}
