using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.LakeFormation.Permissions
{
    /// <summary>
    /// AWS::LakeFormation::Permissions Resource
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-resource.html
    /// </summary>
    public class Resource
    {

        /// <summary>
        /// TableResource
        /// 	
        /// A structure for the table object. A table is a metadata definition that represents your data. You
        /// can Grant and Revoke table privileges to a principal.
        /// Required: No
        /// Type: TableResource
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TableResource")]
        public TableResource TableResource { get; set; }

        /// <summary>
        /// DatabaseResource
        /// 	
        /// A structure for the database object.
        /// 		
        /// Required: No
        /// Type: DatabaseResource
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DatabaseResource")]
        public DatabaseResource DatabaseResource { get; set; }

        /// <summary>
        /// DataLocationResource
        /// Currently not supported by AWS CloudFormation.
        /// Required: No
        /// Type: DataLocationResource
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataLocationResource")]
        public DataLocationResource DataLocationResource { get; set; }

        /// <summary>
        /// TableWithColumnsResource
        /// Currently not supported by AWS CloudFormation.
        /// Required: No
        /// Type: TableWithColumnsResource
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TableWithColumnsResource")]
        public TableWithColumnsResource TableWithColumnsResource { get; set; }

    }
}
