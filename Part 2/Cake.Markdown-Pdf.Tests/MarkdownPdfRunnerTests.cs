using Shouldly;
using Xunit;

namespace Cake.Markdown_Pdf.Tests
{
    public class MarkdownPdfRunnerTests
    {
        private const string TestFilePath = "testpath/testfile.md";
        private const string TestCssFilePath = "testpath/testcssfile.css";


        private readonly MarkdownPdfFixture fixture = new MarkdownPdfFixture();

        [Fact]
        public void No_Settings_Should_Use_Correct_Argument_Provided_In_MarkdownPdfRunnerSettings()
        {
            fixture.RunnerSettings = null;
            var result = fixture.Run();
            result.Args.ShouldBe("");
        }

        [Fact]
        public void WithFilePath_Settings_Should_Use_Correct_Argument_Provided_In_MarkdownPdfRunnerSettings()
        {
            fixture.RunnerSettings = s => s.WithFilePath(TestFilePath);
            var result = fixture.Run();
            result.Args.ShouldBe(TestFilePath);
        }

        [Fact]
        public void WithHelp_Settings_Should_Use_Correct_Argument_Provided_In_MarkdownPdfRunnerSettings()
        {
            fixture.RunnerSettings = s => s.WithHelp();
            var result = fixture.Run();
            result.Args.ShouldBe("--help");
        }

        [Fact]
        public void WithFilePath_And_CssFilePath_Settings_Should_Use_Correct_Argument_Provided_In_MarkdownPdfRunnerSettings()
        {
            fixture.RunnerSettings = s => s.WithFilePath(TestFilePath).WithCssPath(TestCssFilePath);
            var result = fixture.Run();
            result.Args.ShouldBe($"--css-path {TestCssFilePath} {TestFilePath}");
        }
    }
}