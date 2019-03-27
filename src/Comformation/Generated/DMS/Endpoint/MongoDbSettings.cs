using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DMS.Endpoint
{
    /// <summary>
    /// AWS DMS Endpoint MongoDbSettings
    /// Use the MongoDbSettings property to specify settings for a MongoDB endpoint for a AWS::DMS::Endpoint resource.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-endpoint-mongodbsettings.html
    /// </summary>
    public class MongoDbSettings
    {

        /// <summary>
        /// AuthSource
        /// The MongoDB database name. This attribute is not used when you specify NO for AuthType. The default
        /// is admin.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("AuthSource")]
        public Union<string, IntrinsicFunction> AuthSource { get; set; }

        /// <summary>
        /// AuthMechanism
        /// The authentication mechanism you use to access the MongoDB source endpoint.
        /// Valid values: DEFAULT, MONGODB_CR, SCRAM_SHA_1
        /// For MongoDB version 2. x, use MONGODB_CR. For MongoDB version 3. x, use SCRAM_SHA_1. This attribute
        /// is not used when authType=No.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("AuthMechanism")]
        public Union<string, IntrinsicFunction> AuthMechanism { get; set; }

        /// <summary>
        /// Username
        /// The user name you use to access the MongoDB source endpoint.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Username")]
        public Union<string, IntrinsicFunction> Username { get; set; }

        /// <summary>
        /// DocsToInvestigate
        /// Indicates the number of documents to preview to determine the document organization. Use this
        /// attribute when NestingLevel is set to ONE.
        /// Must be a positive value greater than 0. Default value is 1000.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("DocsToInvestigate")]
        public Union<string, IntrinsicFunction> DocsToInvestigate { get; set; }

        /// <summary>
        /// ServerName
        /// The name of the server on the MongoDB source endpoint.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("ServerName")]
        public Union<string, IntrinsicFunction> ServerName { get; set; }

        /// <summary>
        /// Port
        /// The port value for the MongoDB source endpoint.
        /// Required: No
        /// Type: Integer
        /// </summary>
        [JsonProperty("Port")]
        public Union<int, IntrinsicFunction> Port { get; set; }

        /// <summary>
        /// ExtractDocId
        /// Specifies the document ID. Use this attribute when NestingLevel is set to NONE. Default value is
        /// false.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("ExtractDocId")]
        public Union<string, IntrinsicFunction> ExtractDocId { get; set; }

        /// <summary>
        /// DatabaseName
        /// The database name on the MongoDB source endpoint.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("DatabaseName")]
        public Union<string, IntrinsicFunction> DatabaseName { get; set; }

        /// <summary>
        /// AuthType
        /// The authentication type you use to access the MongoDB source endpoint.
        /// When NO is specified, user name and password parameters are not used and can be empty.
        /// Valid values: NO, PASSWORD
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("AuthType")]
        public Union<string, IntrinsicFunction> AuthType { get; set; }

        /// <summary>
        /// Password
        /// The password for the user account you use to access the MongoDB source endpoint.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Password")]
        public Union<string, IntrinsicFunction> Password { get; set; }

        /// <summary>
        /// NestingLevel
        /// Specifies either document or table mode.
        /// Valid values: NONE, ONE
        /// Default value is NONE. Specify NONE to use document mode. Specify ONE to use table mode.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("NestingLevel")]
        public Union<string, IntrinsicFunction> NestingLevel { get; set; }

    }
}
