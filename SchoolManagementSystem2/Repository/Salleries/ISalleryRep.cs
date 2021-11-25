using SchoolManagementSystem2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem2.Repository.Salleries
{
    public interface ISalleryRep
    {
        List<SalleryViewModel> GetAllSallery();
        void DeleteSallery(int? id);
        SalleryViewModel GetSallery(int id);
        SalleryViewModel AddOrEditSallery(SalleryViewModel SalleryViewModel);
    }
}
