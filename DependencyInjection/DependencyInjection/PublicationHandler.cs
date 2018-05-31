using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionCli
{
    public class PublicationHandler
    {
        private readonly IPublication _localPub;

        public PublicationHandler()
        {

        }

        public PublicationHandler(IPublication localPub)
        {
            _localPub = localPub;
        }

        public string GetFullName()
        {
            return _localPub.GetFullName();
        }
    }
}
