using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.CustomActionType
{
    /// <summary>
    /// AWS CodePipeline CustomActionType ConfigurationProperties
    /// ConfigurationProperties is a property of the AWS::CodePipeline::CustomActionType resource that defines a
    /// configuration for an AWS CodePipeline custom action.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codepipeline-customactiontype-configurationproperties.html
    /// </summary>
    public class ConfigurationProperties
    {

        /// <summary>
        /// Description
        /// A description of this configuration property that will be displayed to users.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// Key
        /// Indicates whether the configuration property is a key.
        /// Required: Yes
        /// Type: Boolean
        /// </summary>
        [JsonProperty("Key")]
        public Union<bool, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Name
        /// A name for this configuration property.
        /// Required: Yes
        /// Type: String
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Queryable
        /// Indicates whether the configuration property will be used with the PollForJobs call. A custom action
        /// can have one queryable property. The queryable property must be required (see the Required property)
        /// and must not be secret (see the Secret property). For more information, see the queryable contents
        /// for the ActionConfigurationProperty data type in the AWS CodePipeline API Reference.
        /// Required: No
        /// Type: Boolean
        /// </summary>
        [JsonProperty("Queryable")]
        public Union<bool, IntrinsicFunction> Queryable { get; set; }

        /// <summary>
        /// Required
        /// Indicates whether the configuration property is a required value.
        /// Required: Yes
        /// Type: Boolean
        /// </summary>
        [JsonProperty("Required")]
        public Union<bool, IntrinsicFunction> Required { get; set; }

        /// <summary>
        /// Secret
        /// Indicates whether the configuration property is secret. Secret configuration properties are hidden
        /// from all AWS CodePipeline calls except for GetJobDetails, GetThirdPartyJobDetails, PollForJobs, and
        /// PollForThirdPartyJobs.
        /// Required: Yes
        /// Type: Boolean
        /// </summary>
        [JsonProperty("Secret")]
        public Union<bool, IntrinsicFunction> Secret { get; set; }

        /// <summary>
        /// Type
        /// The type of the configuration property, such as String, Number, or Boolean.
        /// Required: No
        /// Type: String
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
