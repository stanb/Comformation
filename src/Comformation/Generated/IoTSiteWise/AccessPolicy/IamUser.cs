using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTSiteWise.AccessPolicy
{
    /// <summary>
    /// AWS::IoTSiteWise::AccessPolicy IamUser
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-accesspolicy-iamuser.html
    /// </summary>
    public class IamUser
    {

        /// <summary>
        /// arn
        /// The ARN of the IAM user. For more information, see IAM ARNs in the IAM User Guide.
        /// Note If you delete the IAM user, access policies that contain this identity include an empty arn.
        /// You can delete the access policy for the IAM user that no longer exists.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("arn")]
        public Union<string, IntrinsicFunction> arn { get; set; }

    }
}
