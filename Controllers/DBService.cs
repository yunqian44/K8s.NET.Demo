using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace k8s.net.demo.Controllers
{
    public class DBService
    {
        protected IDbConnection conn;

        public DBService()
        {
            conn = new MySqlConnection("server=mysql_dc;User Id=root;password=qwer1234!;Database=blogdb");
        }

        public async Task<T> Single<T>(string sql, object paramPairs = null)
        {
            return await conn.QuerySingleOrDefaultAsync<T>(sql, paramPairs);
        }

        public async Task<int> Count(string sql, object paramPairs = null)
        {
            return await conn.QuerySingleOrDefaultAsync<int>(sql, paramPairs);
        }
    }
}
