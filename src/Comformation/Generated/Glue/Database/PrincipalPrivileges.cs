using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Database
{
    /// <summary>
    /// AWS::Glue::Database PrincipalPrivileges
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-database-principalprivileges.html
    /// </summary>
    public class PrincipalPrivileges
    {

        /// <summary>
        /// Permissions
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: List of String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Permissions")]
        public List<Union<string, IntrinsicFunction>> Permissions { get; set; }

        /// <summary>
        /// Principal
        /// Not currently supported by AWS CloudFormation.
        /// Required: No
        /// Type: DataLakePrincipal
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Principal")]
        public DataLakePrincipal Principal { get; set; }

    }
}
