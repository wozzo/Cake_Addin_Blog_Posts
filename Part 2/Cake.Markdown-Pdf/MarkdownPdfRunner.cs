using System;
using System.Collections.Generic;
using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.Markdown_Pdf
{
    public class MarkdownPdfRunner : Tool<MarkdownPdfRunnerSettings>, IMarkdownPdfRunner
    {
        public MarkdownPdfRunner(IFileSystem fileSystem, ICakeEnvironment environment, IProcessRunner processRunner, IToolLocator tools)
            : base(fileSystem, environment, processRunner, tools) { }

        protected override string GetToolName() => "Markdown-pdf Runner";

        protected override IEnumerable<string> GetToolExecutableNames() => new[] { "markdown-pdf.cmd", "markdown-pdf" };

        private static ProcessArgumentBuilder GetSettingsArguments(MarkdownPdfRunnerSettings settings)
        {
            var args = new ProcessArgumentBuilder();
            settings?.Evaluate(args);
            return args;
        }

        public IMarkdownPdfRunner Run(Action<MarkdownPdfRunnerSettings> configure = null)
        {
            var settings = new MarkdownPdfRunnerSettings();
            configure?.Invoke(settings);
            return Run(settings);
        }

        public IMarkdownPdfRunner Run(MarkdownPdfRunnerSettings settings)
        {
            var args = GetSettingsArguments(settings);
            Run(settings, args);
            return this;
        }
    }
}
