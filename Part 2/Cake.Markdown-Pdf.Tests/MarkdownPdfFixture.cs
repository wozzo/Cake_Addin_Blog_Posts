using System;
using Cake.Testing.Fixtures;

namespace Cake.Markdown_Pdf.Tests
{
    public class MarkdownPdfFixture : ToolFixture<MarkdownPdfRunnerSettings>
    {
        public MarkdownPdfFixture() : base("markdown-pdf") { }
        public Action<MarkdownPdfRunnerSettings> RunnerSettings;

        protected override void RunTool()
        {
            var tool = new MarkdownPdfRunner(FileSystem, Environment, ProcessRunner, Tools);
            tool.Run(RunnerSettings);
        }
    }
}
