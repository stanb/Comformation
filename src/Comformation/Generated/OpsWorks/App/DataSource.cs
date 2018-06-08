using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.App
{
    /// <summary>
    /// AWS OpsWorks App DataSource
    /// DataSource is a property of the AWS::OpsWorks::App resource that specifies a database to associate with an AWS
    /// OpsWorks app.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opsworks-app-datasource.html
    /// </summary>
    public class DataSource
    {

        /// <summary>
        /// Arn
        /// The ARN of the data source.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Arn")]
        public Union<string, IntrinsicFunction> Arn { get; set; }

        /// <summary>
        /// DatabaseName
        /// The name of the database.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("DatabaseName")]
        public Union<string, IntrinsicFunction> DatabaseName { get; set; }

        /// <summary>
        /// Type
        /// The type of the data source, such as AutoSelectOpsworksMysqlInstance, OpsworksMysqlInstance, or
        /// RdsDbInstance. For valid values, see the DataSource type in the AWS OpsWorks Stacks API Reference.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
