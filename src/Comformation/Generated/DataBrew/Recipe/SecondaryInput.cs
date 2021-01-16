using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.DataBrew.Recipe
{
    /// <summary>
    /// AWS::DataBrew::Recipe SecondaryInput
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-recipe-secondaryinput.html
    /// </summary>
    public class SecondaryInput
    {

        /// <summary>
        /// S3InputDefinition
        /// The Amazon S3 location where the data is stored.
        /// Required: No
        /// Type: S3Location
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("S3InputDefinition")]
        public S3Location S3InputDefinition { get; set; }

        /// <summary>
        /// DataCatalogInputDefinition
        /// The AWS Glue Data Catalog parameters for the data.
        /// Required: No
        /// Type: DataCatalogInputDefinition
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("DataCatalogInputDefinition")]
        public DataCatalogInputDefinition DataCatalogInputDefinition { get; set; }

    }
}
