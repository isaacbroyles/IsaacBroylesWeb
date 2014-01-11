using System.IO;
using System.Web;
using IsaacBroylesWeb.Models;
using IsaacBroylesWeb.Utilities;

namespace IsaacBroylesWeb.Repositories
{
    public class PostsRepository
    {
        public static Post GetPostWithTitle(string title)
        {
            try
            {
                TextFile file = new TextFile(GetFilePathFromTitle(title));
                var textFromFile = file.Read();

                return new Post { Markdown = textFromFile, Content = markdown.Transform(textFromFile) };
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public static string GetFilePathFromTitle(string title)
        {
            return Path.Combine(POSTS_PATH, GetFileNameFromTitle(title));
        }

        public static string GetFileNameFromTitle(string title)
        {
            return title + ".md";
        }

        private static readonly string POSTS_PATH = HttpContext.Current.Server.MapPath("~/Content/markdown/posts");
        private static readonly MarkdownUtility markdown = new MarkdownUtility();
    }
}