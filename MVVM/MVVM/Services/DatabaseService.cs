using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.IO;
using System.Threading.Tasks;
using MVVM.Models;


namespace MVVM.Services
{
    class DatabaseService
    {
        private readonly SQLiteAsyncConnection _database;

        public DatabaseService()
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ClienteDB.db3");
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Cliente>().Wait(); 
        }

        public Task<int> InsertClienteAsync(Cliente cliente)
        {
            return _database.InsertAsync(cliente);
        }

        public Task<Cliente> GetClienteAsync(string correo, string contraseña)
        {
            return _database.Table<Cliente>()
                            .Where(c => c.Correo == correo && c.Contraseña == contraseña)
                            .FirstOrDefaultAsync();
        }

    }
}
