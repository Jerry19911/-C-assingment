using Business.Services;


class Program
{
    static void Main(string[] args)
    {
        var menuService = new MenuService();
        menuService.CreateUserDialog();
    }
}