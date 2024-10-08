using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;


namespace Labrary1
{
    public class PhoneNumber
    {
        // Phương thức tìm kiếm số điện thoại theo tên người dùng nhập vào
        public string PhoneNumberLookup(string input)
        {
            // Mảng chứa tên 7 người bạn
            string[] People = { "Hoa", "Thu", "Noa", "Lily", "Su", "Shi", "Duy" };

            // Mảng chứa số điện thoại của 7 người
            string[] PhoneNumbers = { "036-789-8933", "123-884-7002", "456-123-6789", "789-003-0079", "888-123-4567", "234-567-8901", "678-901-2345" };

            // Vòng lặp để tìm tên người bạn nhập vào
            for (int i = 0; i < People.Length; i++)
            {
                // Kiểm tra xem tên có khớp hoặc chứa đoạn nhập vào không (không phân biệt chữ hoa chữ thường)
                if (People[i].ToLower().Contains(input.ToLower()))
                {
                    // Nếu tìm thấy, trả về số điện thoại tương ứng
                    return $"Phone number of {People[i]}: {PhoneNumbers[i]}";
                }
            }

            // Nếu không tìm thấy, trả về thông báo không tìm thấy người dùng
            return "Person not found. Please try again.";
        }
    }
}



