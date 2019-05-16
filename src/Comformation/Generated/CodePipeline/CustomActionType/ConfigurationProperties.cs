using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.CodePipeline.CustomActionType
{
    /// <summary>
    /// Missing documentation http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codepipeline-customactiontype-configurationproperties.html
    /// </summary>
    public class ConfigurationProperties
    {

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("Description")]
        public Union<string, IntrinsicFunction> Description { get; set; }

        /// <summary>
        /// Key
        /// </summary>
        [JsonProperty("Key")]
        public Union<bool, IntrinsicFunction> Key { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

        /// <summary>
        /// Queryable
        /// </summary>
        [JsonProperty("Queryable")]
        public Union<bool, IntrinsicFunction> Queryable { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("Required")]
        public Union<bool, IntrinsicFunction> Required { get; set; }

        /// <summary>
        /// Secret
        /// </summary>
        [JsonProperty("Secret")]
        public Union<bool, IntrinsicFunction> Secret { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        [JsonProperty("Type")]
        public Union<string, IntrinsicFunction> Type { get; set; }

    }
}
