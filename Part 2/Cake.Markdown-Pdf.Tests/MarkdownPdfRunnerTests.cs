using Shouldly;
using Xunit;

namespace Cake.Markdown_Pdf.Tests
{
    public class MarkdownPdfRunnerTests
    {
        private const string TestFilePath = "testpath/testfile.md";
        private const string TestPhantomPath = "testpath/testphantom";
        private const string TestRunningsPath = "testpath/testrunnings";
        private const string TestCssPath = "testpath/testcssfile.css";
        private const string TestHighlightCssPath = "testpath/testhighlightcss.css";
        private const string TestRemarkableOptions = "{\"test\" : \"json\"}";
        private const string TestPaperBorder = "testpath/testpaperborder";
        private const string TestOutFilePath = "testpath/testoutfilepath.pdf";

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
        public void WithVersion_Settings_Should_Use_Correct_Argument_Provided_In_MarkdownPdfRunnerSettings()
        {
            fixture.RunnerSettings = s => s.WithVersion();
            var result = fixture.Run();
            result.Args.ShouldBe("--version");
        }

        [Fact]
        public void WithPhantomPath_Settings_Should_Use_Correct_Argument_Provided_In_MarkdownPdfRunnerSettings()
        {
            fixture.RunnerSettings = s => s.WithPhantomPath(TestPhantomPath);
            var result = fixture.Run();
            result.Args.ShouldBe($"--phantom-path {TestPhantomPath}");
        }

        [Fact]
        public void WithRunningsPath_Settings_Should_Use_Correct_Argument_Provided_In_MarkdownPdfRunnerSettings()
        {
            fixture.RunnerSettings = s => s.WithRunningsPath(TestRunningsPath);
            var result = fixture.Run();
            result.Args.ShouldBe($"--runnings-path {TestRunningsPath}");
        }

        [Fact]
        public void WithCssPath_Settings_Should_Use_Correct_Argument_Provided_In_MarkdownPdfRunnerSettings()
        {
            fixture.RunnerSettings = s => s.WithCssPath(TestCssPath);
            var result = fixture.Run();
            result.Args.ShouldBe($"--css-path {TestCssPath}");
        }

        [Fact]
        public void WithHighlightCssPath_Settings_Should_Use_Correct_Argument_Provided_In_MarkdownPdfRunnerSettings()
        {
            fixture.RunnerSettings = s => s.WithHighlightCssPath(TestHighlightCssPath);
            var result = fixture.Run();
            result.Args.ShouldBe($"--highlight-css-path {TestHighlightCssPath}");
        }

        [Fact]
        public void WithRemarkableOptions_Settings_Should_Use_Correct_Argument_Provided_In_MarkdownPdfRunnerSettings()
        {
            fixture.RunnerSettings = s => s.WithRemarkableOptions(TestRemarkableOptions);
            var result = fixture.Run();
            result.Args.ShouldBe($"--remarkable-options {TestRemarkableOptions}");
        }

        [Theory]
        [InlineData(MarkdownPdfPaperFormat.A3)]
        [InlineData(MarkdownPdfPaperFormat.A4)]
        [InlineData(MarkdownPdfPaperFormat.A5)]
        [InlineData(MarkdownPdfPaperFormat.Legal)]
        [InlineData(MarkdownPdfPaperFormat.Letter)]
        [InlineData(MarkdownPdfPaperFormat.Tabloid)]
        public void WithPaperFormat_Settings_Should_Use_Correct_Argument_Provided_In_MarkdownPdfRunnerSettings(MarkdownPdfPaperFormat paperFormat)
        {
            fixture.RunnerSettings = s => s.WithPaperFormat(paperFormat);
            var result = fixture.Run();
            result.Args.ShouldBe($"--paper-format {paperFormat}");
        }

        [Fact]
        public void WithPaperFormat_None_Settings_Should_Ignore_PaperFormat_Argument_Provided_In_MarkdownPdfRunnerSettings()
        {
            fixture.RunnerSettings = s => s.WithPaperFormat(MarkdownPdfPaperFormat.None);
            var result = fixture.Run();
            result.Args.ShouldBe($"");
        }

        [Theory]
        [InlineData(MarkdownPdfOrientation.Portrait)]
        [InlineData(MarkdownPdfOrientation.Landscape)]
        public void WithOrientation_Settings_Should_Use_Correct_Argument_Provided_In_MarkdownPdfRunnerSettings(MarkdownPdfOrientation orientation)
        {
            fixture.RunnerSettings = s => s.WithOrientation(orientation);
            var result = fixture.Run();
            result.Args.ShouldBe($"--paper-orientation {orientation}");
        }

        [Fact]
        public void WithOrientation_None_Settings_Should_Ignore_PaperFormat_Argument_Provided_In_MarkdownPdfRunnerSettings()
        {
            fixture.RunnerSettings = s => s.WithOrientation(MarkdownPdfOrientation.None);
            var result = fixture.Run();
            result.Args.ShouldBe($"");
        }

        [Fact]
        public void WithPaperBorder_Settings_Should_Use_Correct_Argument_Provided_In_MarkdownPdfRunnerSettings()
        {
            fixture.RunnerSettings = s => s.WithPaperBorder(TestPaperBorder);
            var result = fixture.Run();
            result.Args.ShouldBe($"--paper-border {TestPaperBorder}");
        }

        [Fact]
        public void WithRenderDelay_Settings_Should_Use_Correct_Argument_Provided_In_MarkdownPdfRunnerSettings()
        {
            fixture.RunnerSettings = s => s.WithRenderDelay(1);
            var result = fixture.Run();
            result.Args.ShouldBe($"--render-delay 1");
        }

        [Fact]
        public void WithLoadTimeout_Settings_Should_Use_Correct_Argument_Provided_In_MarkdownPdfRunnerSettings()
        {
            fixture.RunnerSettings = s => s.WithLoadTimeout(2);
            var result = fixture.Run();
            result.Args.ShouldBe($"--load-timeout 2");
        }

        [Fact]
        public void WithOutFilePath_Settings_Should_Use_Correct_Argument_Provided_In_MarkdownPdfRunnerSettings()
        {
            fixture.RunnerSettings = s => s.WithOutFilePath(TestOutFilePath);
            var result = fixture.Run();
            result.Args.ShouldBe($"--out {TestOutFilePath}");
        }
    }
}