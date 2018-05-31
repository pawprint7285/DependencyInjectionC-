using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Infrastructure
{
    public class PublicationRepositoryMemory : IPubRepository
    {
        private readonly List<IPublication> _pubList;
        private readonly int _nextId = 1;

        public PublicationRepositoryMemory()
        {
            if(_pubList == null)
            {
                _pubList = new List<IPublication>();
            }
        }

        public IPublication Add(IPublication publication)
        {
            publication.Id = _nextId++;
            _pubList.Add(publication);

            return publication;
        }

        public IPublication GetById(int id)
        {
            return _pubList.Find(p => p.Id == id);
        }

        public List<IPublication> ListAll()
        {
            return _pubList.OrderByDescending(p => p.PubDate).ToList();
        }
    }
}
