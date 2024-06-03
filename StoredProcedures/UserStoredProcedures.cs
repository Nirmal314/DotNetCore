using Core2.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core2.StoredProcedures
{
    public class UserStoredProcedures
    {
        private readonly ExamContext _db;

        public UserStoredProcedures(ExamContext context)
        {
            _db = context;
        }

        public User GetUserByEmail(string email) => _db.Users.FromSqlRaw("EXEC GetUserByEmail @Email", new SqlParameter("@Email", email)).AsEnumerable().FirstOrDefault();

        public User GetUserById(int id) => _db.Users.FromSqlRaw("EXEC GetUserById @Id", new SqlParameter("@Id", id)).AsEnumerable().FirstOrDefault();

        public async Task<List<User>> GetAllUsers() => await _db.Users.FromSqlRaw("EXEC GetAllUsers").ToListAsync();
    }
}
