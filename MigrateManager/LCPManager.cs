using MigrateData.NewEntity;
using MigrateData.OldEntity;
using MigrateData.Utils;
using Newtonsoft.Json;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MigrateData.MigrateManager
{
    /// <summary>
    /// sys_user
    /// sys_emp
    /// sys_org
    /// sys_role
    /// </summary>
    public class LCPManager
    {
        /// <summary>
        /// 迁移组织、员工、用户
        /// </summary>
        public void MigrateOrgAndUserAndEmp()
        {
            try
            {

                SqlSugarUtils.db.Ado.BeginTran();
                Console.WriteLine("开始迁移sysOrg、sysEmp、sysUser表...");
                //清除新库组织表数据
                SqlSugarUtils.db.Deleteable<sys_org>().ExecuteCommandAsync();
                //清除新库员工表数据
                SqlSugarUtils.db.Deleteable<sys_emp>().Where(it => it.JobNum != 0).ExecuteCommandAsync();
                ////清除新库用户表数据
                SqlSugarUtils.db.Deleteable<sys_user>().Where(it => it.JobNum != 0).ExecuteCommandAsync();

                //查询旧库组织表数据
                var department1 = SqlSugarUtils.db.QueryableWithAttr<T_HR_Department1>()
                    .AsNavQueryable()
                    .Includes(it => it.Department2, it => it.Department3)
                    .ToList();

                long departmentId = LCPUtils.AddOrgInNewDB();
                //从组织根部向下建立结构插入数据
                foreach (var item in department1)
                {
                    //查询一级组织底下的员工信息
                    item.staffEntities = SqlSugarUtils.db.QueryableWithAttr<T_HR_Staff>().Includes(it => it.userEntity).Where(it => it.StaffID != "0" && it.ID1 == item.ID1 && string.IsNullOrWhiteSpace(it.ID2) && string.IsNullOrWhiteSpace(it.ID3)).ToList();
                    //新增组织
                    long departmentId1 = LCPUtils.AddOrgInNewDB(item, departmentId);
                    //新增员工
                    LCPUtils.AddEmpInNewDB(item.staffEntities, departmentId1, item.Department1Name);
                    foreach (var item2 in item.Department2)
                    {
                        //查询二级组织底下的员工信息
                        item2.staffEntities = SqlSugarUtils.db.QueryableWithAttr<T_HR_Staff>().Includes(it => it.userEntity).Where(it => it.StaffID != "0" && it.ID2 == item2.ID2 && string.IsNullOrWhiteSpace(it.ID3)).ToList();
                        //新增组织
                        long departmentId2 = LCPUtils.AddOrgInNewDB(item2, departmentId, departmentId1);
                        //新增员工
                        LCPUtils.AddEmpInNewDB(item2.staffEntities, departmentId2, item2.Department2Name);
                        foreach (var item3 in item2.Department3)
                        {
                            //查询三级组织底下的员工信息
                            item3.staffEntities = SqlSugarUtils.db.QueryableWithAttr<T_HR_Staff>().Includes(it => it.userEntity).Where(it => it.StaffID != "0" && it.ID3 == item3.ID3).ToList();
                            //新增组织
                            long departmentId3 = LCPUtils.AddOrgInNewDB(item3, departmentId, departmentId1, departmentId2);
                            //新增员工
                            LCPUtils.AddEmpInNewDB(item3.staffEntities, departmentId3, item3.Department3Name);
                        }
                    }
                }

                //将旧库中所有无组织的员工单独添加
                var NoOrgEmpList = SqlSugarUtils.db.QueryableWithAttr<T_HR_Staff>()
                    .Includes(it => it.userEntity)
                    .Where(it => string.IsNullOrWhiteSpace(it.ID1) && string.IsNullOrWhiteSpace(it.ID2) && string.IsNullOrWhiteSpace(it.ID3))
                    .ToList();
                //新增员工
                LCPUtils.AddEmpInNewDB(NoOrgEmpList);

                Console.WriteLine("完成");
                SqlSugarUtils.db.Ado.CommitTran();
            }
            catch (Exception)
            {
                SqlSugarUtils.db.Ado.RollbackTran();
                Console.WriteLine("迁移sysOrg、sysEmp、sysUser表失败");
                throw;
            }
        }

        /// <summary>
        /// 迁移审核功能、审核流程、审核人
        /// </summary>
        public void MigragteCheckfuncAndCheckflowAndChecker()
        {
            Console.WriteLine("开始迁移t_sys_checkfunc、t_sys_checkflow、t_sys_Checkfunc_Checkflow_relation、t_sys_checker表...");
            try
            {
                SqlSugarUtils.db.Ado.BeginTran();
                //删除新库的审核功能
                var newCheckFunkAfterTaskList = SqlSugarUtils.db.Queryable<t_sys_checkfunc>().ToList();
                SqlSugarUtils.db.Deleteable<t_sys_checkfunc>().ExecuteCommand();
                //获取旧库审核功能
                var checkfuncList = SqlSugarUtils.db.QueryableWithAttr<T_CH_Checkfunc>().ToList();
                //新增新库的审核功能
                LCPUtils.AddCheckFuncInNewDB(checkfuncList, newCheckFunkAfterTaskList);

                SqlSugarUtils.db.Ado.CommitTran();
            }
            catch (Exception)
            {

                SqlSugarUtils.db.Ado.RollbackTran();
                Console.WriteLine("迁移sysOrg、sysEmp、sysUser表失败");
                throw;
            }


        }

        /// <summary>
        /// 校验哪些数据没有迁移过来
        /// </summary>
        public void VerifyOrgAndUserAndEmp()
        {
            var newData = SqlSugarUtils.db.Queryable<sys_user>().Select(it => it.JobNum.ToString()).ToList();
            var oldData = SqlSugarUtils.db.QueryableWithAttr<T_PE_Users>().Select(it => it.EmployeeID).ToList();

            var chayi = oldData.Except(newData);
            foreach (var item in chayi)
            {
                Console.WriteLine(item);
            }
        }

    }
}
