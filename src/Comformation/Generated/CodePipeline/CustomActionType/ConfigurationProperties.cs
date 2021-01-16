using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.CustomActionType
{
    /// <summary>
    /// AWS::CodePipeline::CustomActionType ConfigurationProperties
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-customactiontype-configurationproperties.html
    /// </summary>
    public class ConfigurationProperties
    {

        /// <summary>
        /// Description
        /// The description of the action configuration property that is displayed to users.
        /// Required: No
        /// Type: String
        /// Minimum: 1
        /// Maximum: 160
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// Key
        /// Whether the configuration property is a key.
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Key")]
        public Union<bool, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Name
        /// The name of the action configuration property.
        /// Required: Yes
        /// Type: String
        /// Minimum: 1
        /// Maximum: 50
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Queryable
        /// Indicates that the property is used with PollForJobs. When creating a custom action, an action can
        /// have up to one queryable property. If it has one, that property must be both required and not
        /// secret.
        /// If you create a pipeline with a custom action type, and that custom action contains a queryable
        /// property, the value for that configuration property is subject to other restrictions. The value must
        /// be less than or equal to twenty (20) characters. The value can contain only alphanumeric characters,
        /// underscores, and hyphens.
        /// Required: No
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Queryable")]
        public Union<bool, IntrinsicFunction> Queryable { get; set; }

        /// <summary>
        /// Required
        /// Whether the configuration property is a required value.
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Required")]
        public Union<bool, IntrinsicFunction> Required { get; set; }

        /// <summary>
        /// Secret
        /// Whether the configuration property is secret. Secrets are hidden from all calls except for
        /// GetJobDetails, GetThirdPartyJobDetails, PollForJobs, and PollForThirdPartyJobs.
        /// When updating a pipeline, passing * * * * * without changing any other values of the action
        /// preserves the previous value of the secret.
        /// Required: Yes
        /// Type: Boolean
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Secret")]
        public Union<bool, IntrinsicFunction> Secret { get; set; }

        /// <summary>
        /// Type
        /// The type of the configuration property.
        /// Required: No
        /// Type: String
        /// Allowed values: Boolean | Number | String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
