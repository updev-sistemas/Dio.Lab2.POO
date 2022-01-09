using Dio.Lab2.POO.Domain;

namespace Dio.Lab2.POO.Views
{
    public class CategoryView
    {
        private readonly CategoryEntity _entity;
        public CategoryView(CategoryEntity entity)
            => _entity = entity;

        public void Show()
        {
            Console.WriteLine($"ID: {_entity.Id}");
            Console.WriteLine($"Nome: {_entity.Name}");
            Console.WriteLine($"Registrado em: {_entity.CreatedAt:dd/MM/yyyy HH:mm:ss}");
            Console.WriteLine($"Atualizado em: {_entity.UpdatedAt:dd/MM/yyyy HH:mm:ss}");
        }
    }
}
