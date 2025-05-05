using DonaBookClient.Models;
using DonaBookClient.Services;
using DonaBookClient.Dashboards;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("📚 SELAMAT DATANG DI DONA BOOK📚");

Console.Write("Email: ");
string email = Console.ReadLine() ?? "";

Console.Write("Password: ");
string password = Console.ReadLine() ?? "";

var userService = new UserApiService();
var user = await     userService.LoginAsync(email, password);

if (user == null)
{
    Console.WriteLine(" Login gagal. Cek email/password kamu.");
    return;
}

Console.WriteLine($"\n Login sebagai: {user.Name} ({user.Role!.ToUpper()})");

switch (user.Role.ToLower())
{
    case "donatur":
        await DonaturDashboard.ShowAsync(user);
        break;

    case "penerima":
        await PenerimaDashboard.ShowAsync(user);  // ← implementasi selanjutnya
        break;

    case "volunteer":
        await VolunteerDashboard.ShowAsync(user); // ← implementasi selanjutnya
        break;

    default:
        Console.WriteLine("⚠️ Role tidak dikenali.");
        break;
}
