namespace Exercism_markdown
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Linq;

    public static class Markdown
    {
        public const string HtmlHeaderTag = "h";
        public const string HtmlUnorderedListTag = "ul";
        public const string HtmlListItemTag = "li";
        public const string HtmlParagraphTag = "p";
        public const string HtmlItalicTag = "em";
        public const string HtmlBoldTag = "strong";

        public const char MarkdownHeader = '#';
        public const char MarkdownUnorderedListItem = '*';
        public const string MarkdownItalic = "_";
        public const string MarkdownBold = "__";

        public static string Parse(string markdown)
        {
            var html = new StringBuilder();
            var markdownLines = markdown.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < markdownLines.Length; i++)
            {
                var line = markdownLines[i];

                if (line.IsMarkdownHeader())
                {
                    html.Append(ConvertMarkdownHeaderToHtml(line));
                }
                else if (line.IsMarkdownUnorderedListItem())
                {
                    var listItems = new List<string>();
                    do
                    {
                        listItems.Add(line);

                        if (++i >= markdownLines.Length)
                        {
                            break;
                        }

                        line = markdownLines[i];
                    } while (line.IsMarkdownUnorderedListItem());

                    html.Append(ConvertMarkdownUnorderedListToHtml(listItems));
                    i--;
                }
                else
                {
                    html.Append(ConvertMarkdownTextToHtml(line));
                }
            }

            return html.ToString();
        }

        private static string ConvertMarkdownHeaderToHtml(string line)
        {
            var htmlHeaderTagType = line.TakeWhile(e => e == MarkdownHeader).Count();

            return line.Substring(htmlHeaderTagType + 1)
                       .WrapWithHtmlTag($"{HtmlHeaderTag}{htmlHeaderTagType}");
        }

        private static string ConvertMarkdownTextToHtml(string line)
        {
            return line.ReplaceMarkdownEmphasisWithHtmlTag()
                       .WrapWithHtmlTag(HtmlParagraphTag);
        }

        private static string ConvertMarkdownUnorderedListToHtml(IEnumerable<string> listItems)
        {
            var unorderedList = new StringBuilder();

            foreach (var listItem in listItems)
            {
                unorderedList.Append(
                    listItem.Substring(2)
                            .ReplaceMarkdownEmphasisWithHtmlTag()
                            .WrapWithHtmlTag(HtmlListItemTag));
            }

            return unorderedList.ToString()
                                .WrapWithHtmlTag(HtmlUnorderedListTag);
        }
    }

    public static class StringExtenstions
    {
        public static bool IsMarkdownHeader(this string text)
        {
            return Regex.IsMatch(text, $"^\\{Markdown.MarkdownHeader}{{1,6}} .*");
        }

        public static bool IsMarkdownUnorderedListItem(this string text)
        {
            return Regex.IsMatch(text, $"^\\{Markdown.MarkdownUnorderedListItem} .*");
        }

        public static string WrapWithHtmlTag(this string text, string htmlTag)
        {
            return $"<{htmlTag}>{text}</{htmlTag}>";
        }

        public static string ReplaceMarkdownEmphasisWithHtmlTag(this string text)
        {
            var pattern = $"{Markdown.MarkdownBold}(.+){Markdown.MarkdownBold}";
            var replacement = $"<{Markdown.HtmlBoldTag}>$1</{Markdown.HtmlBoldTag}>";
            text = Regex.Replace(text, pattern, replacement);

            pattern = $"{Markdown.MarkdownItalic}(.+){Markdown.MarkdownItalic}";
            replacement = $"<{Markdown.HtmlItalicTag}>$1</{Markdown.HtmlItalicTag}>";
            text = Regex.Replace(text, pattern, replacement);

            return text;
        }
    }
}
