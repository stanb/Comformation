using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.IoTEvents.DetectorModel
{
    /// <summary>
    /// AWS::IoTEvents::DetectorModel DynamoDB
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-dynamodb.html
    /// </summary>
    public class DynamoDB
    {

        /// <summary>
        /// TableName
        /// The name of the DynamoDB table. The tableName value must match the table name of the target DynamoDB
        /// table.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("TableName")]
        public Union<string, IntrinsicFunction> TableName { get; set; }

        /// <summary>
        /// PayloadField
        /// The name of the DynamoDB column that receives the action payload.
        /// If you don&#39;t specify this parameter, the name of the DynamoDB column is payload.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("PayloadField")]
        public Union<string, IntrinsicFunction> PayloadField { get; set; }

        /// <summary>
        /// RangeKeyField
        /// The name of the range key (also called the sort key). The rangeKeyField value must match the sort
        /// key of the target DynamoDB table.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RangeKeyField")]
        public Union<string, IntrinsicFunction> RangeKeyField { get; set; }

        /// <summary>
        /// HashKeyField
        /// The name of the hash key (also called the partition key). The hashKeyField value must match the
        /// partition key of the target DynamoDB table.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HashKeyField")]
        public Union<string, IntrinsicFunction> HashKeyField { get; set; }

        /// <summary>
        /// RangeKeyValue
        /// The value of the range key (also called the sort key).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RangeKeyValue")]
        public Union<string, IntrinsicFunction> RangeKeyValue { get; set; }

        /// <summary>
        /// RangeKeyType
        /// The data type for the range key (also called the sort key), You can specify the following values:
        /// &#39;STRING&#39; - The range key is a string. &#39;NUMBER&#39; - The range key is number.
        /// If you don&#39;t specify rangeKeyField, the default value is &#39;STRING&#39;.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("RangeKeyType")]
        public Union<string, IntrinsicFunction> RangeKeyType { get; set; }

        /// <summary>
        /// HashKeyType
        /// The data type for the hash key (also called the partition key). You can specify the following
        /// values:
        /// &#39;STRING&#39; - The hash key is a string. &#39;NUMBER&#39; - The hash key is a number.
        /// If you don&#39;t specify hashKeyType, the default value is &#39;STRING&#39;.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HashKeyType")]
        public Union<string, IntrinsicFunction> HashKeyType { get; set; }

        /// <summary>
        /// HashKeyValue
        /// The value of the hash key (also called the partition key).
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("HashKeyValue")]
        public Union<string, IntrinsicFunction> HashKeyValue { get; set; }

        /// <summary>
        /// Payload
        /// Information needed to configure the payload.
        /// By default, AWS IoT Events generates a standard payload in JSON for any action. This action payload
        /// contains all attribute-value pairs that have the information about the detector model instance and
        /// the event triggered the action. To configure the action payload, you can use contentExpression.
        /// Required: No
        /// Type: Payload
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Payload")]
        public Payload Payload { get; set; }

        /// <summary>
        /// Operation
        /// The type of operation to perform. You can specify the following values:
        /// &#39;INSERT&#39; - Insert data as a new item into the DynamoDB table. This item uses the specified hash key
        /// as a partition key. If you specified a range key, the item uses the range key as a sort key.
        /// &#39;UPDATE&#39; - Update an existing item of the DynamoDB table with new data. This item&#39;s partition key
        /// must match the specified hash key. If you specified a range key, the range key must match the item&#39;s
        /// sort key. &#39;DELETE&#39; - Delete an existing item of the DynamoDB table. This item&#39;s partition key must
        /// match the specified hash key. If you specified a range key, the range key must match the item&#39;s sort
        /// key.
        /// If you don&#39;t specify this parameter, AWS IoT Events triggers the &#39;INSERT&#39; operation.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Operation")]
        public Union<string, IntrinsicFunction> Operation { get; set; }

    }
}
