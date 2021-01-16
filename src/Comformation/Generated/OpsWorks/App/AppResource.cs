using System;
using System.Collections.Generic;
using Comformation.IntrinsicFunctions;

namespace Comformation.OpsWorks.App
{
    /// <summary>
    /// AWS::OpsWorks::App
    /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-app.html
    /// </summary>
    public class AppResource : ResourceBase
    {
        public class AppProperties
        {
            /// <summary>
            /// AppSource
            /// A Source object that specifies the app repository.
            /// Required: No
            /// Type: Source
            /// Update requires: No interruption
            /// </summary>
            public Source AppSource { get; set; }

            /// <summary>
            /// Attributes
            /// One or more user-defined key/value pairs to be added to the stack attributes.
            /// Required: No
            /// Type: Map of String
            /// Update requires: No interruption
            /// </summary>
            public Dictionary<string, Union<string, IntrinsicFunction>> Attributes { get; set; }

            /// <summary>
            /// DataSources
            /// The app&#39;s data source.
            /// Required: No
            /// Type: List of DataSource
            /// Update requires: No interruption
            /// </summary>
            public List<DataSource> DataSources { get; set; }

            /// <summary>
            /// Description
            /// A description of the app.
            /// Required: No
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Description { get; set; }

            /// <summary>
            /// Domains
            /// The app virtual host settings, with multiple domains separated by commas. For example: &#39;www.
            /// example. com, example. com&#39;
            /// Required: No
            /// Type: List of String
            /// Update requires: No interruption
            /// </summary>
            public List<Union<string, IntrinsicFunction>> Domains { get; set; }

            /// <summary>
            /// EnableSsl
            /// Whether to enable SSL for the app.
            /// Required: No
            /// Type: Boolean
            /// Update requires: No interruption
            /// </summary>
            public Union<bool, IntrinsicFunction> EnableSsl { get; set; }

            /// <summary>
            /// Environment
            /// An array of EnvironmentVariable objects that specify environment variables to be associated with the
            /// app. After you deploy the app, these variables are defined on the associated app server instance.
            /// For more information, see Environment Variables.
            /// There is no specific limit on the number of environment variables. However, the size of the
            /// associated data structure - which includes the variables&#39; names, values, and protected flag values -
            /// cannot exceed 20 KB. This limit should accommodate most if not all use cases. Exceeding it will
            /// cause an exception with the message, &quot;Environment: is too large (maximum is 20KB). &quot;
            /// Note If you have specified one or more environment variables, you cannot modify the stack&#39;s Chef
            /// version.
            /// Required: No
            /// Type: List of EnvironmentVariable
            /// Update requires: No interruption
            /// </summary>
            public List<EnvironmentVariable> Environment { get; set; }

            /// <summary>
            /// Name
            /// The app name.
            /// Required: Yes
            /// Type: String
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Name { get; set; }

            /// <summary>
            /// Shortname
            /// The app&#39;s short name.
            /// Required: No
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> Shortname { get; set; }

            /// <summary>
            /// SslConfiguration
            /// An SslConfiguration object with the SSL configuration.
            /// Required: No
            /// Type: SslConfiguration
            /// Update requires: No interruption
            /// </summary>
            public SslConfiguration SslConfiguration { get; set; }

            /// <summary>
            /// StackId
            /// The stack ID.
            /// Required: Yes
            /// Type: String
            /// Update requires: Replacement
            /// </summary>
            public Union<string, IntrinsicFunction> StackId { get; set; }

            /// <summary>
            /// Type
            /// The app type. Each supported type is associated with a particular layer. For example, PHP
            /// applications are associated with a PHP layer. AWS OpsWorks Stacks deploys an application to those
            /// instances that are members of the corresponding layer. If your app isn&#39;t one of the standard types,
            /// or you prefer to implement your own Deploy recipes, specify other.
            /// Required: Yes
            /// Type: String
            /// Allowed values: aws-flow-ruby | java | nodejs | other | php | rails | static
            /// Update requires: No interruption
            /// </summary>
            public Union<string, IntrinsicFunction> Type { get; set; }

        }

        public string Type { get; } = "AWS::OpsWorks::App";

        public AppProperties Properties { get; } = new AppProperties();

    }
}
