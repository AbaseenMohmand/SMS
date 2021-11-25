using SchoolManagementSystem2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Repository.Fees
{
    public interface IFeesRep
    {
        List<FeeViewModel> GetAllFee();
        void DeleteFee(int? id);
        FeeViewModel GetFee(int id);
        FeeViewModel AddOrEditFee(FeeViewModel feeViewModel);
    }
}
