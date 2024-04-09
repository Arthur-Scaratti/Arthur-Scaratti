
using Microsoft.EntityFrameworkCore;
using .Modelos;

namespace MyNovelAPI.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<ALL_PLUGINS> ALL_PLUGINS { get; set; }

        public DbSet<APPLICABLE_ROLES> APPLICABLE_ROLES { get; set; }

        public DbSet<CHARACTER_SETS> CHARACTER_SETS { get; set; }

        public DbSet<CHECK_CONSTRAINTS> CHECK_CONSTRAINTS { get; set; }

        public DbSet<COLLATIONS> COLLATIONS { get; set; }

        public DbSet<COLLATION_CHARACTER_SET_APPLICABILITY> COLLATION_CHARACTER_SET_APPLICABILITY { get; set; }

        public DbSet<COLUMNS> COLUMNS { get; set; }

        public DbSet<COLUMN_PRIVILEGES> COLUMN_PRIVILEGES { get; set; }

        public DbSet<ENABLED_ROLES> ENABLED_ROLES { get; set; }

        public DbSet<ENGINES> ENGINES { get; set; }

        public DbSet<EVENTS> EVENTS { get; set; }

        public DbSet<FILES> FILES { get; set; }

        public DbSet<GLOBAL_STATUS> GLOBAL_STATUS { get; set; }

        public DbSet<GLOBAL_VARIABLES> GLOBAL_VARIABLES { get; set; }

        public DbSet<KEYWORDS> KEYWORDS { get; set; }

        public DbSet<KEY_CACHES> KEY_CACHES { get; set; }

        public DbSet<KEY_COLUMN_USAGE> KEY_COLUMN_USAGE { get; set; }

        public DbSet<OPTIMIZER_COSTS> OPTIMIZER_COSTS { get; set; }

        public DbSet<OPTIMIZER_TRACE> OPTIMIZER_TRACE { get; set; }

        public DbSet<PARAMETERS> PARAMETERS { get; set; }

        public DbSet<PARTITIONS> PARTITIONS { get; set; }

        public DbSet<PLUGINS> PLUGINS { get; set; }

        public DbSet<PROCESSLIST> PROCESSLIST { get; set; }

        public DbSet<PROFILING> PROFILING { get; set; }

        public DbSet<REFERENTIAL_CONSTRAINTS> REFERENTIAL_CONSTRAINTS { get; set; }

        public DbSet<ROUTINES> ROUTINES { get; set; }

        public DbSet<SCHEMATA> SCHEMATA { get; set; }

        public DbSet<SCHEMA_PRIVILEGES> SCHEMA_PRIVILEGES { get; set; }

        public DbSet<SESSION_STATUS> SESSION_STATUS { get; set; }

        public DbSet<SESSION_VARIABLES> SESSION_VARIABLES { get; set; }

        public DbSet<STATISTICS> STATISTICS { get; set; }

        public DbSet<SQL_FUNCTIONS> SQL_FUNCTIONS { get; set; }

        public DbSet<SYSTEM_VARIABLES> SYSTEM_VARIABLES { get; set; }

        public DbSet<TABLES> TABLES { get; set; }

        public DbSet<TABLESPACES> TABLESPACES { get; set; }

        public DbSet<TABLE_CONSTRAINTS> TABLE_CONSTRAINTS { get; set; }

        public DbSet<TABLE_PRIVILEGES> TABLE_PRIVILEGES { get; set; }

        public DbSet<TRIGGERS> TRIGGERS { get; set; }

        public DbSet<USER_PRIVILEGES> USER_PRIVILEGES { get; set; }

        public DbSet<VIEWS> VIEWS { get; set; }

        public DbSet<CLIENT_STATISTICS> CLIENT_STATISTICS { get; set; }

        public DbSet<INDEX_STATISTICS> INDEX_STATISTICS { get; set; }

        public DbSet<INNODB_FT_CONFIG> INNODB_FT_CONFIG { get; set; }

        public DbSet<GEOMETRY_COLUMNS> GEOMETRY_COLUMNS { get; set; }

        public DbSet<INNODB_SYS_TABLESTATS> INNODB_SYS_TABLESTATS { get; set; }

        public DbSet<SPATIAL_REF_SYS> SPATIAL_REF_SYS { get; set; }

        public DbSet<USER_STATISTICS> USER_STATISTICS { get; set; }

        public DbSet<INNODB_TRX> INNODB_TRX { get; set; }

        public DbSet<INNODB_CMP_PER_INDEX> INNODB_CMP_PER_INDEX { get; set; }

        public DbSet<INNODB_METRICS> INNODB_METRICS { get; set; }

        public DbSet<INNODB_FT_DELETED> INNODB_FT_DELETED { get; set; }

        public DbSet<INNODB_CMP> INNODB_CMP { get; set; }

        public DbSet<THREAD_POOL_WAITS> THREAD_POOL_WAITS { get; set; }

        public DbSet<INNODB_CMP_RESET> INNODB_CMP_RESET { get; set; }

        public DbSet<THREAD_POOL_QUEUES> THREAD_POOL_QUEUES { get; set; }

        public DbSet<TABLE_STATISTICS> TABLE_STATISTICS { get; set; }

        public DbSet<INNODB_SYS_FIELDS> INNODB_SYS_FIELDS { get; set; }

        public DbSet<INNODB_BUFFER_PAGE_LRU> INNODB_BUFFER_PAGE_LRU { get; set; }

        public DbSet<INNODB_LOCKS> INNODB_LOCKS { get; set; }

        public DbSet<INNODB_FT_INDEX_TABLE> INNODB_FT_INDEX_TABLE { get; set; }

        public DbSet<INNODB_CMPMEM> INNODB_CMPMEM { get; set; }

        public DbSet<THREAD_POOL_GROUPS> THREAD_POOL_GROUPS { get; set; }

        public DbSet<INNODB_CMP_PER_INDEX_RESET> INNODB_CMP_PER_INDEX_RESET { get; set; }

        public DbSet<INNODB_SYS_FOREIGN_COLS> INNODB_SYS_FOREIGN_COLS { get; set; }

        public DbSet<INNODB_FT_INDEX_CACHE> INNODB_FT_INDEX_CACHE { get; set; }

        public DbSet<INNODB_BUFFER_POOL_STATS> INNODB_BUFFER_POOL_STATS { get; set; }

        public DbSet<INNODB_FT_BEING_DELETED> INNODB_FT_BEING_DELETED { get; set; }

        public DbSet<INNODB_SYS_FOREIGN> INNODB_SYS_FOREIGN { get; set; }

        public DbSet<INNODB_CMPMEM_RESET> INNODB_CMPMEM_RESET { get; set; }

        public DbSet<INNODB_FT_DEFAULT_STOPWORD> INNODB_FT_DEFAULT_STOPWORD { get; set; }

        public DbSet<INNODB_SYS_TABLES> INNODB_SYS_TABLES { get; set; }

        public DbSet<INNODB_SYS_COLUMNS> INNODB_SYS_COLUMNS { get; set; }

        public DbSet<INNODB_SYS_TABLESPACES> INNODB_SYS_TABLESPACES { get; set; }

        public DbSet<INNODB_SYS_INDEXES> INNODB_SYS_INDEXES { get; set; }

        public DbSet<INNODB_BUFFER_PAGE> INNODB_BUFFER_PAGE { get; set; }

        public DbSet<INNODB_SYS_VIRTUAL> INNODB_SYS_VIRTUAL { get; set; }

        public DbSet<user_variables> user_variables { get; set; }

        public DbSet<INNODB_TABLESPACES_ENCRYPTION> INNODB_TABLESPACES_ENCRYPTION { get; set; }

        public DbSet<INNODB_LOCK_WAITS> INNODB_LOCK_WAITS { get; set; }

        public DbSet<THREAD_POOL_STATS> THREAD_POOL_STATS { get; set; }

    }
}
