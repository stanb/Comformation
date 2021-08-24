using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTSiteWise.AccessPolicy
{
    /// <summary>
    /// AWS::IoTSiteWise::AccessPolicy IamRole
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-accesspolicy-iamrole.html
    /// </summary>
    public class IamRole
    {

        /// <summary>
        /// arn
        /// The ARN of the IAM role. For more information, see IAM ARNs in the IAM User Guide.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("arn")]
        public Union<string, IntrinsicFunction> arn { get; set; }

    }
}
