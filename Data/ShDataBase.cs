using Shhh.Extensions;
using Shhh.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shhh.Data
{
    public class ShDataBase
    {
        static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() =>
        {
            return new SQLiteAsyncConnection(DataConstants.DatabasePath, DataConstants.Flags);
        });

        static SQLiteAsyncConnection Database => lazyInitializer.Value;
        static bool initialized = false;

        public ShDataBase()
        {
            InitializeAsync().SafeFireAndForget(false);
        }

        async Task InitializeAsync()
        {
            if (!initialized)
            {
                if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(Silensor).Name))
                {
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(Silensor)).ConfigureAwait(false);
                }
                initialized = true;
            }
        }

        public async Task<List<T>> GetDataAsync<T>() where T : new()
        {
            return await Database.Table<T>().ToListAsync();
        }

        public async Task<int> SaveData(object data)
        {
            return await Database.InsertAsync(data);
        }

        public async Task<int> UpdateDataAsync(object data)
        {
            return await Database.UpdateAsync(data);
        }
    }
}
