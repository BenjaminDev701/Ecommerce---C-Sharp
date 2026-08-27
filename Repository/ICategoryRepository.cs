using System;

namespace API_Ecommerce.Repository;

//*Esto es el contrato del Repositorio 
public interface ICategoryRepository
{

//Trae la coleccion de todas las categorias
    ICollection<Category>GetCategories();
//Busca por id
    Category GetCategory(int Id);

//Verifica si existe la categoria por id
    bool CategoryExists(int Id);

//Verifica si existe la categoria por nombre
    bool CategoryExists(string name);

//*Crea una categoria
    bool CreateCategory(Category category);

//Actualiza una categoria
    bool UpdateCategory(Category category);

//Elimina una categoria
    bool DeleteCategory(Category category);

//Guarda los cambios en la bd
    bool Save();

}
