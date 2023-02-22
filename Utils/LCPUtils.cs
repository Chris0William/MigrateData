using MigrateData.Extension;
using MigrateData.NewEntity;
using MigrateData.OldEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrateData.Utils
{
    public static class LCPUtils
    {

        private static DateTime now = DateTime.Now;
        private static long createUserId = 142307070910551;
        private static string createUserName = "超级管理员";
        private static long tenantId = 142307070918780;


        /// <summary>
        /// 将组织数据添加到新库中
        /// </summary>
        /// <param name="StaffInfo"></param>
        public static long AddOrgInNewDB()
        {

            long org1Id = Yitter.IdGenerator.YitIdHelper.NextId();
            //新增一级组织
            sys_org orgInfo = new()
            {
                Id = org1Id,
                Pid = 0,
                Pids = "[0]",
                Name = "德尔集团",
                Code = "Deer",
                CreatedTime = now,
                CreatedUserId = createUserId,
                CreatedUserName = createUserName,
                IsDeleted = false,
                TenantId = tenantId,
            };
            SqlSugarUtils.db.Insertable(orgInfo).ExecuteCommand();
            return org1Id;
        }
        /// <summary>
        /// 将组织数据添加到新库中
        /// </summary>
        /// <param name="StaffInfo"></param>
        public static long AddOrgInNewDB(T_HR_Department1 department, long departmentId)
        {

            long org1Id = Yitter.IdGenerator.YitIdHelper.NextId();
            //新增一级组织
            sys_org orgInfo = new()
            {
                Id = org1Id,
                Pid = departmentId,
                Pids = $"[0],[{departmentId}]",
                Name = department.Department1Name,
                Code = department.Department1No ?? "",
                CreatedTime = now,
                CreatedUserId = createUserId,
                CreatedUserName = createUserName,
                IsDeleted = false,
                TenantId = tenantId,
            };
            SqlSugarUtils.db.Insertable(orgInfo).ExecuteCommand();
            return org1Id;
        }
        /// <summary>
        /// 将组织数据添加到新库中
        /// </summary>
        /// <param name="StaffInfo"></param>
        public static long AddOrgInNewDB(T_HR_Department2 department, long departmentId, long departmentId1)
        {
            long org1Id = Yitter.IdGenerator.YitIdHelper.NextId();
            //新增一级组织
            sys_org orgInfo = new()
            {
                Id = org1Id,
                Pid = departmentId1,
                Pids = $"[0],[{departmentId}],[{departmentId1}]",
                Name = department.Department2Name,
                Code = department.Department2No ?? "",
                CreatedTime = now,
                CreatedUserId = createUserId,
                CreatedUserName = createUserName,
                IsDeleted = false,
                TenantId = tenantId,
            };
            SqlSugarUtils.db.Insertable(orgInfo).ExecuteCommand();
            return org1Id;
        }
        /// <summary>
        /// 将组织数据添加到新库中
        /// </summary>
        /// <param name="StaffInfo"></param>
        public static long AddOrgInNewDB(T_HR_Department3 department, long departmentId, long departmentId1, long departmentId2)
        {
            long org1Id = Yitter.IdGenerator.YitIdHelper.NextId();
            //新增一级组织
            sys_org orgInfo = new()
            {
                Id = org1Id,
                Pid = departmentId2,
                Pids = $"[0],[{departmentId}],[{departmentId1}],[{departmentId2}]",
                Name = department.Department3Name,
                Code = department.Department3No ?? "",
                CreatedTime = now,
                CreatedUserId = createUserId,
                CreatedUserName = createUserName,
                IsDeleted = false,
                TenantId = tenantId,
            };
            SqlSugarUtils.db.Insertable(orgInfo).ExecuteCommand();
            return org1Id;
        }
        /// <summary>
        /// 将员工数据添加到新库中
        /// </summary>
        /// <param name="StaffInfo"></param>
        public static void AddEmpInNewDB(List<T_HR_Staff> StaffInfo, long? orgId = null, string? orgName = null)
        {
            List<sys_emp> empEntities = new();
            foreach (var item in StaffInfo)
            {
                long empId = Yitter.IdGenerator.YitIdHelper.NextId();
                sys_emp empEntity = new();
                empEntity.Id = empId;
                empEntity.JobNum = item.StaffID.ParseToLong();
                empEntity.OrgId = orgId;
                empEntity.OrgName = orgName;
                empEntity.StaffName = item.Name;
                empEntity.TelNum = item.TelNum;
                empEntity.Urgencyperson = item.Urgencyperson;
                empEntity.UPRelationship = item.UPRelationship;
                empEntity.UPTelNum = item.UPTelNum;
                empEntity.Email = item.Email;
                empEntity.Nation = item.Nation;
                empEntity.Nativeplace = item.Nativeplace;
                empEntity.HireDate = item.Hiredate;
                empEntity.HireState = item.HireState;
                empEntity.CertificateType = item.CertificateType;
                empEntity.CertificateNum = item.CertificateNum;
                empEntity.IDNumberPath = !string.IsNullOrWhiteSpace(item.IDNumberPath) ? item.IDNumberPath.Replace("~", "File") : null;
                empEntity.IdCardAddress = item.IdCardAddress;
                empEntity.Birthday = item.Birthday != null ? item.Birthday.Value.ToString("yyyy-MM-dd") : null;
                empEntity.Sex = item.Sex == "男" ? 1 : 0;
                empEntity.MaritalStatus = item.MaritalStatus;
                empEntity.StaffType = item.StaffType;
                empEntity.WorkAddress = item.WorkAddress;
                empEntity.Area = item.Area;
                empEntity.BankAccount = item.BankAccount;
                empEntity.BankType = item.BankType;
                empEntity.Craft = item.Craft;
                empEntity.Education = item.Education;
                empEntity.EducationProperty = item.EducationProperty;
                empEntity.GraduateTime = item.GraduateTime;
                empEntity.GraduationSchool = item.GraduationSchool;
                empEntity.FundValid = item.FundValid;
                empEntity.JobList = item.JobList;
                empEntity.Job = item.Job;
                empEntity.JobDuty = item.JobDuty;
                empEntity.JobLevel = item.JobLevel;
                empEntity.Major = item.Major;
                empEntity.description = item.Remark;
                empEntity.Department = item.OwnCompany;
                empEntity.ImagePath = !string.IsNullOrWhiteSpace(item.ImagePath) ? item.ImagePath.Replace("~", "File") : null;
                empEntity.SocialInsuranceType = item.SocialInsuranceType;
                empEntity.SSStartdate = item.SSStartdate;
                empEntity.SSEnddate = item.SSEnddate;
                empEntity.NoAttend = item.NoAttend;
                empEntity.PreDimissionDate = item.PreDimissionDate;
                empEntity.DimissionType = item.DimissionType;
                empEntity.DimissionReason = item.DimissionReason;
                empEntity.Probation = item.Probation;
                empEntity.ProbationDate = item.ProbationDate != null ? item.ProbationDate.Value.ToString("yyyy-MM-dd") : null;
                empEntity.ProbationValid = item.ProbationValid;
                empEntity.Director = item.Director;
                empEntity.CreatedTime = now;
                empEntity.CreatedUserId = createUserId;
                empEntity.CreatedUserName = createUserName;
                empEntity.IsDeleted = false;
                empEntities.Add(empEntity);
                //添加对应的用户
                if (item.userEntity != null) AddUserInNewDB(item.userEntity, empId);
            }
            SqlSugarUtils.db.Insertable(empEntities).ExecuteCommand();
        }
        /// <summary>
        /// 将用户数据添加到新库中
        /// </summary>
        /// <param name="StaffInfo"></param>
        public static void AddUserInNewDB(T_PE_Users staffInfo, long empId)
        {
            sys_user userEntity = new();
            userEntity.Id = empId;
            userEntity.JobNum = staffInfo.EmployeeID.ParseToLong();
            userEntity.Account = staffInfo.UserName;
            userEntity.Password = StringUtils.ComputeMD5Hash(staffInfo.Password);
            userEntity.NickName = staffInfo.Name;
            userEntity.Name = staffInfo.Name;
            userEntity.Birthday = staffInfo.Birthday;
            userEntity.Email = staffInfo.Email;
            userEntity.AdminType = 3;
            userEntity.Status = staffInfo.Activity.Value ? 0 : 1;
            userEntity.CreatedTime = now;
            userEntity.CreatedUserId = createUserId;
            userEntity.CreatedUserName = createUserName;
            userEntity.IsDeleted = false;
            userEntity.TenantId = tenantId;
            SqlSugarUtils.db.Insertable(userEntity).ExecuteCommand();
        }


        /// <summary>
        /// 将审核功能添加到新库中
        /// </summary>
        /// <param name="StaffInfo"></param>
        public static void AddCheckFuncInNewDB(List<T_CH_Checkfunc> oldCheckFuncList, List<t_sys_checkfunc> newCheckFunkAfterTaskList)
        {
            List<t_sys_checkfunc> checkFuncList = new();
            foreach (var item in oldCheckFuncList)
            {
                t_sys_checkfunc checkFunkInfo = new();
                checkFunkInfo.Id = item.ID;
                checkFunkInfo.name = item.Name;
                checkFunkInfo.description = item.Description;
                checkFunkInfo.disable = item.Disable;
                checkFunkInfo.AfterTask = newCheckFunkAfterTaskList.Where(it => it.name == item.Name).Select(it => it.AfterTask).First();

                string[] oldCCPeoples = item.CcPeople != null ? item.CcPeople.Split(",") : new string[] { };
                string newCCPeoples = null;
                foreach (var ccpeople in oldCCPeoples)
                {
                    var jobNum = SqlSugarUtils.db.QueryableWithAttr<T_PE_Users>().Where(it => it.UserID == ccpeople).Select(it => it.EmployeeID).First();
                    newCCPeoples += string.IsNullOrWhiteSpace(jobNum) ? "" : ","+jobNum ;
                }
                checkFunkInfo.CcPeople = newCCPeoples;
                checkFuncList.Add(checkFunkInfo);
            }
            SqlSugarUtils.db.Insertable(checkFuncList).ExecuteCommand();
            Console.WriteLine("成功条数：" + checkFuncList.Count);
        }
    }
}
