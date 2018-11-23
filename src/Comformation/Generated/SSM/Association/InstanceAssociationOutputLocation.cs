using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.Association
{
    /// <summary>
    /// AWS Systems Manager Association InstanceAssociationOutputLocation
    /// InstanceAssociationOutputLocation is a property of the AWS::SSM::Association resource that specifies an Amazon
    /// S3 bucket where you want to store the results of this association request.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-association-instanceassociationoutputlocation.html
    /// </summary>
    public class InstanceAssociationOutputLocation
    {

        /// <summary>
        /// S3Location
        /// An Amazon S3 bucket where you want to store the results of this request.
        /// Required: No
        /// Type: S3OutputLocation
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3Location")]
        public S3OutputLocation S3Location { get; set; }

    }
}
