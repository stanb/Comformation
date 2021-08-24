using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Database
{
    /// <summary>
    /// AWS::Glue::Database DataLakePrincipal
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-database-datalakeprincipal.html
    /// </summary>
    public class DataLakePrincipal
    {

        /// <summary>
        /// DataLakePrincipalIdentifier
        /// An identifier for the AWS Lake Formation principal.
        /// Required: Conditional
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataLakePrincipalIdentifier")]
        public Union<string, IntrinsicFunction> DataLakePrincipalIdentifier { get; set; }

    }
}
