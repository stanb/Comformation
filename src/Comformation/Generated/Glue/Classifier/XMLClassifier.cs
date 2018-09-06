using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Glue.Classifier
{
    /// <summary>
    /// AWS Glue Classifier XMLClassifier
    /// The XMLClassifier property type specifies specifies an AWS Glue classifier for XML content.
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-classifier-xmlclassifier.html
    /// </summary>
    public class XMLClassifier
    {

        /// <summary>
        /// RowTag
        /// The XML tag designating the element that contains each record in an XML document being parsed. Note
        /// that this cannot identify a self-closing element (closed by /&amp;gt;). An empty row element that
        /// contains only attributes can be parsed as long as it ends with a closing tag. For example, &amp;lt;row
        /// item_a=&quot;A&quot; item_b=&quot;B&quot;&amp;gt;&amp;lt;/row&amp;gt; is okay, but &amp;lt;row item_a=&quot;A&quot; item_b=&quot;B&quot; /&amp;gt; is not.
        /// Required: Yes
        /// Type: String
        /// Update requires: No Interruption
        /// </summary>
        [JsonProperty("RowTag")]
        public Union<string, IntrinsicFunction> RowTag { get; set; }

        /// <summary>
        /// Classification
        /// An identifier of the data format that the classifier matches.
        /// Required: Yes
        /// Type: String
        /// Update requires: No Interruption
        /// </summary>
        [JsonProperty("Classification")]
        public Union<string, IntrinsicFunction> Classification { get; set; }

        /// <summary>
        /// Name
        /// The name of the classifier.
        /// Required: Yes
        /// Type: String
        /// Update requires: Replacement
        /// </summary>
        [JsonProperty("Name")]
        public Union<string, IntrinsicFunction> Name { get; set; }

    }
}
