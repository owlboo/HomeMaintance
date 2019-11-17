using HomeMaintance.Data;
using HomeMaintance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeMaintance.Ultilities
{
    public class LogHelpers
    {
        private readonly ApplicationDbContext _db;
        public LogHelpers()
        {
            
        }
        public LogHelpers(ApplicationDbContext db)
        {
            _db = db;
        }
        public void WriteLogToDb(string path ,string ex)
        {
            ErrorLog err = new ErrorLog
            {
                Path = path,
                Exception = ex
            };
            _db.ErrorLogs.Add(err);
            _db.SaveChanges();
        }
    }
}
