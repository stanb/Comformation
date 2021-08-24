using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.LakeFormation.Permissions
{
    /// <summary>
    /// AWS::LakeFormation::Permissions DataLakePrincipal
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-datalakeprincipal.html
    /// </summary>
    public class DataLakePrincipal
    {

        /// <summary>
        /// DataLakePrincipalIdentifier
        /// An identifier for the Lake Formation principal.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataLakePrincipalIdentifier")]
        public Union<string, IntrinsicFunction> DataLakePrincipalIdentifier { get; set; }

    }
}
