using Microsoft.EntityFrameworkCore;
namespace csharp_asp_net_core_mvc_menu.Data
{
    public class MenuContext : DbContext
    {
        public MenuContext( DbContextOptions<MenuContext> options ) : base(options)
        {

        }
    }
}
