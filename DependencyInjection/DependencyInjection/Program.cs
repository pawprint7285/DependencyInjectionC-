using System;
using DependencyInjectionCli;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {

            var myBook = new Book
            {
                Title = "All About Stuff",
                Author = "Paul Wallace",
                PubDate = DateTime.Now
            };

            //PrintPublicationFullName(myBook);

            var myMagazine = new MagazineArticle
            {
                Title = " A Review Of All About Stuff",
                Author = "Bill Chandler",
                PubDate = DateTime.Now,
                IssueNum = 21
            };

            //PrintPublicationFullName(myMagazine);
            //PrintPublicationFullName(myBook);
            //PublicationHandler pubHandler1 = new PublicationHandler();
            //pubHandler1._localPub = myMagazine;

            //PublicationHandler pubHandler = new PublicationHandler
            //{
            //    _localPub = myMagazine
            //};

            PublicationHandler pubHandler = new PublicationHandler(myMagazine);
            PublicationHandler pubHandler2 = new PublicationHandler(myBook);

            Console.WriteLine(pubHandler.GetFullName());
            Console.WriteLine(pubHandler2.GetFullName()); 
        

        //static void PrintPublicationFullName(IPublication pub)
        //{
         //   // Danger! This will worf for a magazinearticle but not a book!
          //  //var issueNum = ((MagazineArticle)pub).IssueNum;
          //
            ////var issueNum = (pub as MagazineArticle).IssueNum;

            //var myMag2 = pub as MagazineArticle;
            //IPeriodical myMag2 = pub as MagazineArticle;
            
            //if(myMag2 != null)
            //{
            //    Console.WriteLine($"IssueNumber: {myMag2.IssueNum}");
            //}
            
            //if(pub is IPeriodical)
            //{
              //  var myMag3 = pub as IPeriodical;
                //Console.WriteLine($"IssueNumber: {myMag3.IssueNum}");
            //}

            //var myMag = (MagazineArticle)pub;

            //Console.WriteLine($"Our Book is: {pub.GetFullName()}");
        //}
    //}
//}


