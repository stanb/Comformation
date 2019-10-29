using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.LakeFormation.DataLakeSettings
{
    /// <summary>
    /// AWS::LakeFormation::DataLakeSettings DataLakePrincipal
    /// The AWS Lake Formation principal.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-datalakesettings-datalakeprincipal.html
    /// </summary>
    public class DataLakePrincipal
    {

        /// <summary>
        /// DataLakePrincipalIdentifier
        /// An identifier for the AWS Lake Formation principal.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataLakePrincipalIdentifier")]
        public Union<string, IntrinsicFunction> DataLakePrincipalIdentifier { get; set; }

    }
}
