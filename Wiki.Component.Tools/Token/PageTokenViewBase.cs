namespace Wiki.Component.Tools.Token
{
    public abstract class PageTokenViewBase : IPageTokenView
    {
        public static readonly string HiddenTokenName = "hiddenToken";
        /// <inheritdoc />
        /// <summary>
        /// Generates the page token.
        /// </summary>
        /// <returns></returns>
        public abstract string GeneratePageToken();

        /// <inheritdoc />
        /// <summary>
        /// Gets the get last page token from Form
        /// </summary>
        public abstract string GetLastPageToken { get; }

        /// <inheritdoc />
        /// <summary>
        /// Gets a value indicating whether [tokens match].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [tokens match]; otherwise, <c>false</c>.
        /// </value>
        public abstract bool TokensMatch { get; }

    }
}
