using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wishApp.DAO;
using wishApp.Model;

namespace wishApp.Controller
{
    public class WishController
    {
        private IWishDAO wishDAO;

        public WishController(IWishDAO wishDAO)
        {
            this.wishDAO = wishDAO;
        }

        public bool AddWish(WishModel wishModel)
        {
            return wishDAO.AddWish(wishModel);
        }

        public List<WishModel> GetWishModels()
        {
            return wishDAO.GetWishModels().OrderByDescending(x => x.Amount).ToList();
        }

        public WishModel GetWish(int id)
        {
            return wishDAO.GetWish(id);
        }
    }
}
