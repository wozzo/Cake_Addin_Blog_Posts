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
                args.Append(MarkdownPdfOptions.Help);
            if (Version)
                args.Append($"{MarkdownPdfOptions.Version}");
            if (!string.IsNullOrWhiteSpace(PhantomPath))
                args.Append($"{MarkdownPdfOptions.PhantomPath} {PhantomPath}");
            if (!string.IsNullOrWhiteSpace(RunningsPath))
                args.Append($"{MarkdownPdfOptions.RunningsPath} {RunningsPath}");
            if (!string.IsNullOrWhiteSpace(CssPath))
                args.Append($"{MarkdownPdfOptions.CssPath} {CssPath}");
            if (!string.IsNullOrWhiteSpace(HighlightCssPath))
                args.Append($"{MarkdownPdfOptions.HighlightCssPath} {HighlightCssPath}");
            if (!string.IsNullOrWhiteSpace(RemarkableOptions))
                args.Append($"{MarkdownPdfOptions.RemarkableOptions} {RemarkableOptions}");
            if (PaperFormat != MarkdownPdfPaperFormat.None)
                args.Append($"{MarkdownPdfOptions.PaperFormat} {PaperFormat}");
            if (Orientation != MarkdownPdfOrientation.None)
                args.Append($"{MarkdownPdfOptions.Orientation} {Orientation}");
            if (!string.IsNullOrWhiteSpace(PaperBorder))
                args.Append($"{MarkdownPdfOptions.PaperBorder} {PaperBorder}");
            if (RenderDelay > 0)
                args.Append($"{MarkdownPdfOptions.RenderDelay} {RenderDelay}");
            if (LoadTimeout > 0)
                args.Append($"{MarkdownPdfOptions.LoadTimeout} {LoadTimeout}");
            if (!string.IsNullOrWhiteSpace(OutFilePath))
                args.Append($"{MarkdownPdfOptions.OutFilePath} {OutFilePath}");
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