using Microsoft.EntityFrameworkCore;

//DbContext es una clase que nos permite interactual con la bd y mapear las entidades de nuestro modelo
//realiza consultas y operaciones de la bd
public class AplicationDbContext:DbContext
{
    //aqui tomamos options que es para que tome la opcion de config de la bd  y se la pasemos a la clase llamda de Dbcontext
    public AplicationDbContext(DbContextOptions<AplicationDbContext> options):base(options)
    {
        
    }

    public DbSet<Category> Categories {get; set;}
}

