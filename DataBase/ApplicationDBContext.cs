using Microsoft.EntityFrameworkCore;
using api.Models;

namespace api.DataBase
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

        public DbSet<Stock> Stock { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                // Set table name to lowercase feature/controllers
                entity.SetTableName(ToSnakeCase(entity.GetTableName()!));

                foreach (var property in entity.GetProperties())
                {
                    // Convert column names to snake_case
                    property.SetColumnName(ToSnakeCase(property.Name));
                }
            }

            base.OnModelCreating(modelBuilder);
        }

        // Helper method to convert PascalCase to snake_case
        private static string ToSnakeCase(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input;

            var builder = new System.Text.StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                var c = input[i];
                if (char.IsUpper(c))
                {
                    if (i > 0)
                        builder.Append('_');
                    builder.Append(char.ToLowerInvariant(c));
                }
                else
                {
                    builder.Append(c);
                }
            }

            return builder.ToString();
        }
    }
}
