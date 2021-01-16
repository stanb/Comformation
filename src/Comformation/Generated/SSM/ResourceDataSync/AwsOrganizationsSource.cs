using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.SSM.ResourceDataSync
{
    /// <summary>
    /// AWS::SSM::ResourceDataSync AwsOrganizationsSource
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-resourcedatasync-awsorganizationssource.html
    /// </summary>
    public class AwsOrganizationsSource
    {

        /// <summary>
        /// OrganizationSourceType
        /// If an AWS Organization is present, this is either OrganizationalUnits or EntireOrganization. For
        /// OrganizationalUnits, the data is aggregated from a set of organization units. For
        /// EntireOrganization, the data is aggregated from the entire AWS Organization.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 64
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("OrganizationSourceType")]
        public Union<string, IntrinsicFunction> OrganizationSourceType { get; set; }

        /// <summary>
        /// OrganizationalUnits
        /// The AWS Organizations organization units included in the sync.
        /// Required: No
        /// Type: List of String
        /// Maximum: 1000
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("OrganizationalUnits")]
        public List<Union<string, IntrinsicFunction>> OrganizationalUnits { get; set; }

    }
}
