using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodsAccountingPractice1
{
    class Helper
    {
        private static GoodsAccountingEntities goodsAccountingEntities;

        public static GoodsAccountingEntities GetContex()
        {
            if (goodsAccountingEntities == null)
            {
                goodsAccountingEntities = new GoodsAccountingEntities();
            }
            return goodsAccountingEntities;
        }
    }
}
