// Lokasi: DonaBookGui/Services/Session.cs (atau di mana pun Anda menyimpannya)
using DonaBookApi.Model; // <-- Pastikan menggunakan ini

namespace DonaBookGui.Services
{
    public static class Session
    {
        public static User CurrentUser { get; set; }

        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}