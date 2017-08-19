using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.Markdown_Pdf
{
    public class MarkdownPdfRunnerSettings : ToolSettings
    {
        internal void Evaluate(ProcessArgumentBuilder args)
        {
            if (Help)
                args.Append("--help");
            if (Version)
                args.Append("--version");
            if (!string.IsNullOrWhiteSpace(PhantomPath))
                args.Append($"--phantom-path {PhantomPath}");
            if (!string.IsNullOrWhiteSpace(RunningsPath))
                args.Append($"--runnings-path {RunningsPath}");
            if (!string.IsNullOrWhiteSpace(CssPath))
                args.Append($"--css-path {CssPath}");
            if (!string.IsNullOrWhiteSpace(HighlightCssPath))
                args.Append($"--highlight-css-path {HighlightCssPath}");
            if (!string.IsNullOrWhiteSpace(RemarkableOptions))
                args.Append($"--remarkable-options {RemarkableOptions}");
            if (PaperFormat != MarkdownPdfPaperFormat.None)
                args.Append($"--paper-format {PaperFormat}");
            if (Orientation != MarkdownPdfOrientation.None)
                args.Append($"--paper-orientation {Orientation}");
            if (!string.IsNullOrWhiteSpace(PaperBorder))
                args.Append($"--paper-border {PaperBorder}");
            if (RenderDelay > 0)
                args.Append($"--render-delay {RenderDelay}");
            if (LoadTimeout > 0)
                args.Append($"--load-timeout {LoadTimeout}");
            if (!string.IsNullOrWhiteSpace(OutFilePath))
                args.Append($"--out {OutFilePath}");
            if (!string.IsNullOrWhiteSpace(FilePath))
                args.Append(FilePath);
        }

        public bool Help { get; set; }
        public bool Version { get; set; }
        public string FilePath { get; set; }
        public string PhantomPath { get; set; }
        public string RunningsPath { get; set; }
        public string CssPath { get; set; }
        public string HighlightCssPath { get; set; }
        public string RemarkableOptions { get; set; }
        public MarkdownPdfPaperFormat PaperFormat { get; set; }
        public MarkdownPdfOrientation Orientation { get; set; }
        public string PaperBorder { get; set; }
        public int RenderDelay { get; set; }
        public int LoadTimeout { get; set; }
        public string OutFilePath { get; set; }
    }
}