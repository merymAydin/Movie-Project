using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Business;
using ymypMovieProjectEntity.Entities;

namespace Ymypprojects.Business.Abstract
{
    public interface IDirectorService : IGenericService<Director>
    {
        List<Director> GetByFirstname(string firstname);
        List<Director> GetBylastname(string lastname);
        List<Director> GetImageUrl(string url);
    }
}