using Cake.Core.IO;

namespace Cake.Markdown_Pdf
{
    public static class MarkdownPdfRunnerSettingsExtensions
    {
        public static MarkdownPdfRunnerSettings UseWorkingDirectory(this MarkdownPdfRunnerSettings settings, DirectoryPath workingDirectory)
        {
            settings.WorkingDirectory = workingDirectory;
            return settings;
        }

        public static MarkdownPdfRunnerSettings WithHelp(this MarkdownPdfRunnerSettings settings)
        {
            settings.Help = true;
            return settings;
        }

        public static MarkdownPdfRunnerSettings WithVersion(this MarkdownPdfRunnerSettings settings)
        {
            settings.Version = true;
            return settings;
        }

        public static MarkdownPdfRunnerSettings WithPhantomPath(this MarkdownPdfRunnerSettings settings, string phantomPath)
        {
            settings.PhantomPath = phantomPath;
            return settings;
        }

        public static MarkdownPdfRunnerSettings WithRunningsPath(this MarkdownPdfRunnerSettings settings, string runningsPath)
        {
            settings.RunningsPath = runningsPath;
            return settings;
        }

        public static MarkdownPdfRunnerSettings WithCssPath(this MarkdownPdfRunnerSettings settings, string cssPath)
        {
            settings.CssPath = cssPath;
            return settings;
        }

        public static MarkdownPdfRunnerSettings WithHighlightCssPath(this MarkdownPdfRunnerSettings settings, string highlightCssPath)
        {
            settings.HighlightCssPath = highlightCssPath;
            return settings;
        }

        public static MarkdownPdfRunnerSettings WithRemarkableOptions(this MarkdownPdfRunnerSettings settings, string remarkableOptions)
        {
            settings.RemarkableOptions = remarkableOptions;
            return settings;
        }

        public static MarkdownPdfRunnerSettings WithPaperFormat(this MarkdownPdfRunnerSettings settings, MarkdownPdfPaperFormat paperFormat)
        {
            settings.PaperFormat = paperFormat;
            return settings;
        }

        public static MarkdownPdfRunnerSettings WithOrientation(this MarkdownPdfRunnerSettings settings, MarkdownPdfOrientation orientation)
        {
            settings.Orientation = orientation;
            return settings;
        }

        public static MarkdownPdfRunnerSettings WithPaperBorder(this MarkdownPdfRunnerSettings settings, string border)
        {
            settings.PaperBorder = border;
            return settings;
        }

        public static MarkdownPdfRunnerSettings WithRenderDelay(this MarkdownPdfRunnerSettings settings, int renderDelay)
        {
            settings.RenderDelay = renderDelay;
            return settings;
        }

        public static MarkdownPdfRunnerSettings WithLoadTimeout(this MarkdownPdfRunnerSettings settings, int loadTimeout)
        {
            settings.LoadTimeout = loadTimeout;
            return settings;
        }

        public static MarkdownPdfRunnerSettings WithFilePath(this MarkdownPdfRunnerSettings settings, string filePath)
        {
            settings.FilePath = filePath;
            return settings;
        }

        public static MarkdownPdfRunnerSettings WithOutFilePath(this MarkdownPdfRunnerSettings settings, string outFilePath)
        {
            settings.OutFilePath = outFilePath;
            return settings;
        }
    }
}