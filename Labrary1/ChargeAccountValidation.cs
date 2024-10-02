using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrary1
{
    public static class ChargeAccountValidation
    {
        // Phương thức kiểm tra tính hợp lệ của số tài khoản
        public static bool AccountValidation(int accountNumber)
        {
            // Mảng chứa các số tài khoản hợp lệ
            int[] validAccounts = { 5658845, 4520125, 7895122, 8777541, 8451277, 1302850,
                                    8080152, 4562555, 5552012, 5050552, 7825877, 1250255,
                                    1005231, 6545231, 3852085, 7576651, 7881200, 4581002 };

            //// Sử dụng vòng lặp để kiểm tra xem số tài khoản có trong mảng hay không
            //foreach (int account in validAccounts)
            //{
            //    if (account == accountNumber)
            //    {
            //        // Nếu tìm thấy, trả về true
            //        return true;
            //    }
            //}
            for (int i = 0; i < validAccounts.Length; i++)
            {
                if (validAccounts[i] == accountNumber)
                {
                    // Nếu tìm thấy, trả về true
                    return true;
                }
            }
            // Nếu không tìm thấy, trả về false
            return false;
        }
    }
}
