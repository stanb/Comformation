using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.MLTransform
{
    /// <summary>
    /// AWS::Glue::MLTransform InputRecordTables
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-mltransform-inputrecordtables.html
    /// </summary>
    public class InputRecordTables
    {

        /// <summary>
        /// GlueTables
        /// The database and table in the AWS Glue Data Catalog that is used for input or output data.
        /// Required: No
        /// Type: List of GlueTables
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("GlueTables")]
        public List<GlueTables> GlueTables { get; set; }

    }
}
