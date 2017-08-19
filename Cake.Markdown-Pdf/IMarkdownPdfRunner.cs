using System;

namespace Cake.Markdown_Pdf
{
    public interface IMarkdownPdfRunner
    {
        IMarkdownPdfRunner Run(Action<MarkdownPdfRunnerSettings> configure = null);
        IMarkdownPdfRunner Run(MarkdownPdfRunnerSettings settings);
    }
}