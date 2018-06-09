using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DMS.Endpoint
{
    /// <summary>
    /// AWS DMS Endpoint DynamoDBSettings
    /// Use the DynamoDBSettings property to specify settings for an DynamoDB endpoint for an AWS::DMS::Endpoint
    /// resource.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-dynamodbsettings.html
    /// </summary>
    public class DynamoDbSettings
    {

        /// <summary>
        /// ServiceAccessRoleArn
        /// The Amazon Resource Name (ARN) used by the service access IAM role.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("ServiceAccessRoleArn")]
        public Union<string, IntrinsicFunction> ServiceAccessRoleArn { get; set; }

    }
}
