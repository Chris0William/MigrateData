using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MigrateData.Utils
{
    public static class SqlSugarUtils
    {
        /// <summary>
        /// 声明链接(新旧库)
        /// </summary>
        public static SqlSugarClient db = new SqlSugarClient(new List<ConnectionConfig>()
        {
          new ConnectionConfig(){ConfigId="newDb",DbType=DbType.SqlServer,
          ConnectionString="Server=localhost;Database=DeerMIS;User=sa;Password=123456;MultipleActiveResultSets=True;"},

          new ConnectionConfig(){ConfigId="oldDb",DbType=DbType.SqlServer,
          ConnectionString="Server=localhost;Database=Deer_MIS;User=sa;Password=123456;MultipleActiveResultSets=True;" }
        });

        /// <summary>
        /// 生成实体类
        /// </summary>
        public static void GenderEntity()
        {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            Console.WriteLine("开始生成New库实体类...");
            db.GetConnection("newDb").DbFirst
                 .IsCreateAttribute()
                 .SettingClassTemplate(old =>
                 {
                     return old.Replace("{SugarTable}", "{SugarTable}\r\n\t[Tenant(\"newDb\")]");
                 })
                 .CreateClassFile($@"{projectDirectory}\NewEntity", "MigrateData.NewEntity");
            Console.WriteLine("New库生成实体类成功!");

            Console.WriteLine("开始生成Old库实体类...");
            db.GetConnection("oldDb").DbFirst
                .IsCreateAttribute()
                .SettingClassTemplate(old =>
                {
                    return old.Replace("{SugarTable}", "{SugarTable}\r\n\t[Tenant(\"oldDb\")]");
                })
                .CreateClassFile($@"{projectDirectory}\OldEntity", "MigrateData.OldEntity");
            Console.WriteLine("Old库生成实体类成功!");
        }
    }
}
