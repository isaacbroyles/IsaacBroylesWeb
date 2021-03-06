﻿using MarkdownSharp;

namespace IsaacBroylesWeb.Utilities
{
    public class MarkdownUtility
    {
        public MarkdownUtility()
        {
            markdown = new Markdown();
        }

        public string Transform(string mdText)
        {
            return markdown.Transform(mdText);
        }

        private Markdown markdown;
    }
}