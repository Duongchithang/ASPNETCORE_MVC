using WebApplication4.Models;

namespace WebApplication4.Services
{
    public class UserService
    {
        public List<User> Users = new List<User>();
        public UserService()
        {
            AddUser();
        }
        public List<User> GetUser() => Users;
        public void AddUser()
        {
            Users.Clear();
            Users.Add(new User()
            {
                Id = 1,
                FullName = "Duong Chi Thang",
                Email = "ChiThang0210@gmail.com",
                Phone_Number = "0373728765",
                Address = "Vinh An, Hue"
            });
            Users.Add(new User()
            {
                Id = 2,
                FullName = "Hoang Binh An",
                Email = "HoangBinhan@gmail.com",
                Phone_Number = "0373728765",
                Address = "Vinh An, Hue"
            });
            Users.Add(new User()
            {
                Id = 1,
                FullName = "Hồ Văn Quốc",
                Email = "Vanquoc@gmail.com",
                Phone_Number = "0373728765",
                Address = "Vinh An, Hue"
            });
            Users.Add(new User()
            {
                Id = 1,
                FullName = "Lê Hoàng Vũ",
                Email = "HoangVu@gmail.com",
                Phone_Number = "0373728765",
                Address = "Vinh An, Hue"
            });
            Users.Add(new User()
            {
                Id = 1,
                FullName = "Phạm Trương Gia Khánh",
                Email = "GiaKhanh@gmail.com",
                Phone_Number = "0373728765",
                Address = "Vinh An, Hue"
            });
        }
    }
}
