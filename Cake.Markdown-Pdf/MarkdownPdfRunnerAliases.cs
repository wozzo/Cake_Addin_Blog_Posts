using System;
using Cake.Core;
using Cake.Core.Annotations;

namespace Cake.Markdown_Pdf
{
    public static class MarkdownPdfRunnerAliases
    {
        [CakeMethodAlias]
        public static IMarkdownPdfRunner MarkdownPdf(this ICakeContext context,
            Action<MarkdownPdfRunnerSettings> configure)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));
            var runner = new MarkdownPdfRunner(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
            return runner.Run(configure);
        }
    }
}