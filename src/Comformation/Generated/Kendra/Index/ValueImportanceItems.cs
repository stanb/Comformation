using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.Index
{
    /// <summary>
    /// AWS::Kendra::Index ValueImportanceItems
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-index-valueimportanceitems.html
    /// </summary>
    public class ValueImportanceItems
    {

        /// <summary>
        /// ValueImportanceItems_
        /// </summary>
        [JsonProperty("ValueImportanceItems")]
        public List<ValueImportanceItem> ValueImportanceItems_ { get; set; }

    }
}
