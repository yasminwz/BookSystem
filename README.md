# BookSystem
Este é um sistema de cadastro de livros que envolvem
- Listagem de livros /Books
- Cadastro de livros /Books/Create
- Exclusão de livros /Books/Delete/{id}
- Edição de livros /Books/Edit/{id}

 Para poder rodar o projeto você deve ter o banco de dados PostgreSQL, e editar a string
 de conexão em Program.cs, de acordo com o nome do seu usuário e senha.

      Host=localhost;Port=5432;Pooling=true;Database=BOOK_SYSTEM;User Id={usuário};Password={senha};

Também você deve instalar os pacotes: nugget:
1. Entity Framework Core
2. EntityFrameworkNpgsql

Em seguida, deve rodar os seguintes comando no console do nugget:


    Add-Migration {nome-da-migration} -Context Context

O nome da migration pode ser qualquer um...

Em seguida rode o seguinte comando para criar o banco


    Update-database -Context Context


