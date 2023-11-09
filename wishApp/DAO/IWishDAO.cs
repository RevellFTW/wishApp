using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wishApp.Model;

namespace wishApp.DAO
{
    public interface IWishDAO
    {
        public bool AddWish(WishModel wishModel);
        public List<WishModel> GetWishModels();
        public WishModel GetWish(int id);
    }
}
