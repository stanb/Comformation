using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Comformation.IntrinsicFunctions;

namespace Comformation.Kendra.DataSource
{
    /// <summary>
    /// AWS::Kendra::DataSource SqlConfiguration
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-sqlconfiguration.html
    /// </summary>
    public class SqlConfiguration
    {

        /// <summary>
        /// QueryIdentifiersEnclosingOption
        /// Determines whether Amazon Kendra encloses SQL identifiers for tables and column names in double
        /// quotes (&quot;) when making a database query. You can set the value to DOUBLE_QUOTES or NONE.
        /// By default, Amazon Kendra passes SQL identifiers the way that they are entered into the data source
        /// configuration. It does not change the case of identifiers or enclose them in quotes.
        /// PostgreSQL internally converts uppercase characters to lower case characters in identifiers unless
        /// they are quoted. Choosing this option encloses identifiers in quotes so that PostgreSQL does not
        /// convert the character&#39;s case.
        /// For MySQL databases, you must enable the ansi_quotes option when you set this field to
        /// DOUBLE_QUOTES.
        /// Required: No
        /// Type: String
        /// Update requires: No interruption
        /// </summary>
        [JsonProperty("QueryIdentifiersEnclosingOption")]
        public Union<string, IntrinsicFunction> QueryIdentifiersEnclosingOption { get; set; }

    }
}
