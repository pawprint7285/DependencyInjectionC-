using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    public interface IPublication
    {
        int Id { get; set;  }
        string Title { get; set; }
        string Author { get; set; }
        DateTime PubDate { get; set; }
        string GetFullName();
    }
}
