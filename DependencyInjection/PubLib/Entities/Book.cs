using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Book : IPublication
    {
        public int id { get; set };
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PubDate { get; set; }
        public string GetFullName()
        {
            return $"Book - Title: {Title} Author: {Author}";
        }
    }
}
