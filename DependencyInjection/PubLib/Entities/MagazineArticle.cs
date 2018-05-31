using ApplicationCore.Interfaces;
using System;

namespace ApplicationCore.Entities
{
    public class MagazineArticle : IPublication, IPeriodical
    {
        public int id { get; set }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PubDate { get; set; }
        public int IssueNum { get; set; }

        public string GetFullName()
        {
            return $"Magazine - Title: {Title} Author: {Author} IssueNumber: {IssueNum}";
        }
    }
}
