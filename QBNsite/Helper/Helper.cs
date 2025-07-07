
using System.IO;

namespace QBNsite.Helper
{
    public class PortfolioItem
    {
        public string title = "title";
        public string description = "description";
        public string gameEngine = "game engine";
        public string imagePathGif = "";
        public string imagePathAvif = "";
        public string imagePathPng = "";
        public string imagePathWebP = "";
        public string hrefLink = "https://www.google.com";
    }

    public class CardInfo
    {
        public string id = "card id";
        public string Title = "Card Title";
    }

    public class JobExperience
    {
        public string jobtitle = "JobTitle";
        public string description = "JobDescription";
        public string entrepriseName = "EnterpriseName";
        public string hrefLink = "https://www.google.com";
        public string dates = "1997-now";
    }
}
