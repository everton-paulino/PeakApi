using PeakApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeakApi.Repository.Interface
{
    public interface ILendingRepository
    {
        List<Lending> GetLending();
        Lending GetLendingToKey(string KeyLending);
        Lending PostLending(Lending lendingPost);
        Lending UpdateLending(Lending lendingUpdate);
    }
}
