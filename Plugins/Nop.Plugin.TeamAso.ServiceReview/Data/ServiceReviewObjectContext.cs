using Nop.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Core;
using Nop.Plugin.TeamAso.ServiceReview.Domain;
using System.Data.Entity.Infrastructure;

namespace Nop.Plugin.TeamAso.ServiceReview.Data
{
    class ServiceReviewObjectContext : DbContext, IDbContext
    {
        public ServiceReviewObjectContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ServiceReviewRecordMap());
            base.OnModelCreating(modelBuilder);
        }

        public void Install()
        {
            //create the table
            var dbScript = CreateDatabaseScript();
            Database.ExecuteSqlCommand(dbScript);
            SaveChanges();
        }

        /// <summary>
        /// Uninstall
        /// </summary>
        public void Uninstall()
        {
            //drop the table
            var tableName = this.GetTableName<ServiceReviewRecord>();
            this.DropPluginTable(tableName);
        }

        public string CreateDatabaseScript()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateDatabaseScript();
        }

        public bool AutoDetectChangesEnabled
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool ProxyCreationEnabled
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Detach(object entity)
        {
            throw new NotImplementedException();
        }

        public int ExecuteSqlCommand(string sql, bool doNotEnsureTransaction = false, int? timeout = default(int?), params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> ExecuteStoredProcedureList<TEntity>(string commandText, params object[] parameters) where TEntity : BaseEntity, new()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TElement> SqlQuery<TElement>(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        IDbSet<TEntity> IDbContext.Set<TEntity>()
        {
            throw new NotImplementedException();
        }
    }
}
