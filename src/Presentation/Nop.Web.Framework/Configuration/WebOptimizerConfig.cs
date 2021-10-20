using System.Text.Json.Serialization;
using Nop.Core.Configuration;
using WebOptimizer;

namespace Nop.Web.Framework.Configuration
{
    public class WebOptimizerConfig : WebOptimizerOptions, IConfig
    {
        #region Ctor

        public WebOptimizerConfig()
        {
            EnableDiskCache = true;
        }

        #endregion

        /// <summary>
        /// A value indicating whether JS file bundling and minification is enabled
        /// </summary>
        public bool EnableJsBundling { get; private set; } = true;

        /// <summary>
        /// A value indicating whether CSS file bundling and minification is enabled
        /// </summary>
        public bool EnableCssBundling { get; private set; } = true;

        /// <summary>
        /// Gets or sets a suffix for the js-file name of generated bundles
        /// </summary>
        public string JavaScriptBundleSuffix { get; private set; } = ".scripts";

        /// <summary>
        /// Gets or sets a suffix for the css-file name of generated bundles
        /// </summary>
        public string CssBundleSuffix { get; private set; } = ".styles";

        /// <summary>
        /// Gets a section name to load configuration
        /// </summary>
        [JsonIgnore]
        public string Name => "WebOptimizer";
    }
}