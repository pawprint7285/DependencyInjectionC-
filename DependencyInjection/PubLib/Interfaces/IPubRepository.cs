using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    public interface IPubRepository
    {
        IPublication GetById(int id);

        List<IPublication> ListAll();

        IPublication Add(IPublication publication);
    }
}
