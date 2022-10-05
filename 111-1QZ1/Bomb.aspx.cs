using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1QZ1
{
    public partial class Bomb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 宣告1D array (int) & 2Darray (char), 並給予初始值
            int[] ia_MIndex = new int[10] { 0, 7, 13, 28, 44, 62, 74, 75, 87, 90 };
            char[,] ia_Map = new char[10, 10];

            for (int i_row = 0; i_row < 10; i_row++)
            {
                for (int i_col = 0; i_col < 10; i_col++)
                {
                    ia_Map[i_row, i_col] = 'o';
                }
            }

            // 尋找炸彈位置
            for (int i_ct = 0; i_ct < 10; i_ct++)
            {
                int i_row = ia_MIndex[i_ct] / 10;
                int i_col = ia_MIndex[i_ct] % 10;
                ia_Map[i_row, i_col] = '*';
            }

            // 將結果列印出來
            for (int i_row = 0; i_row < 10; i_row++)
            {
                for (int i_col = 0; i_col < 10; i_col++)
                {
                    Response.Write(ia_Map[i_row, i_col]);
                }
                Response.Write("<br />");
            }
            
        }
    }
}