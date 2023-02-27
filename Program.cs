using MigrateData.MigrateManager;
using MigrateData.NewEntity;
using MigrateData.OldEntity;
using MigrateData.Utils;
using System.Net;
using System.Reflection;
using Yitter.IdGenerator;

namespace MigrateData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //雪花id注册
            var workerId = ushort.Parse("1");
            YitIdHelper.SetIdGenerator(new IdGeneratorOptions { WorkerId = workerId });

            do
            {
                //生成实体类
                //SqlSugarUtils.GenderEntity();

                //单一方法执行
                new LCPManager().MigragteApplyFixedAssetAndPurchaseFixedAssetAndStorageFixedAssetAndJm();


                //执行命名空间中MigrateData.MigrateManager的所有方法
                //ExecutAllFunction();

                Console.ReadLine();
            } while (true);

        }

        public static void ExecutAllFunction()
        {
            #region 执行 MigrateData.MigrateManager(迁移管理类)中的 的所有方法
            // 指定要执行的命名空间
            string namespaceName = "MigrateData.MigrateManager";

            // 获取指定命名空间中所有的类型
            var types = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.Namespace == namespaceName);

            // 遍历每个类型，执行其中的方法
            foreach (var type in types)
            {
                // 获取类型中的所有方法
                var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
                foreach (var method in methods)
                {
                    // 执行方法
                    var instance = Activator.CreateInstance(type);
                    method.Invoke(instance, null);
                }
            }
            #endregion
        }
    }
}