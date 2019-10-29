using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.LakeFormation.Permissions
{
    /// <summary>
    /// AWS::LakeFormation::Permissions DatabaseResource
    /// A structure for the database object.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-databaseresource.html
    /// </summary>
    public class DatabaseResource
    {

        /// <summary>
        /// Name
        /// The name of the database resource. Unique to the Data Catalog.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
