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
        #region 静态变量
        private static DateTime now = DateTime.Now;
        private static long createUserId = 142307070910551;
        private static string createUserName = "超级管理员";
        private static long tenantId = 142307070918780;
        #endregion

        #region 迁移组织、员工、用户

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

        #endregion


        #region 迁移审核功能、审核流程、审核人

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
                    newCCPeoples += string.IsNullOrWhiteSpace(jobNum) ? "" : "," + jobNum;
                }
                checkFunkInfo.CcPeople = newCCPeoples;
                checkFunkInfo.CreatedTime = now;
                checkFunkInfo.CreatedUserId = createUserId;
                checkFunkInfo.CreatedUserName = createUserName;
                checkFunkInfo.IsDeleted = false;
                checkFuncList.Add(checkFunkInfo);
            }
            SqlSugarUtils.db.Insertable(checkFuncList).ExecuteCommand();
            Console.WriteLine("审核功能成功条数：" + checkFuncList.Count);
        }

        /// <summary>
        /// 将审核流程添加到新库中
        /// </summary>
        /// <param name="StaffInfo"></param>
        public static void AddCheckFlowInNewDB(List<T_CH_Checkflow> oldCheckFlowList)
        {
            List<t_sys_checkflow> checkFlowList = new();
            foreach (var item in oldCheckFlowList)
            {
                t_sys_checkflow checkFlowInfo = new();
                checkFlowInfo.Id = item.ID;
                checkFlowInfo.name = item.Name;
                checkFlowInfo.Time_limit = item.Time_limit;
                checkFlowInfo.disable = item.Disable;
                checkFlowInfo.description = item.Description;
                checkFlowInfo.CreatedTime = item.CreatorTime;
                checkFlowInfo.CreatedUserId = createUserId;
                checkFlowInfo.CreatedUserName = createUserName;
                checkFlowInfo.IsDeleted = false;
                checkFlowList.Add(checkFlowInfo);
            }
            SqlSugarUtils.db.Insertable(checkFlowList).ExecuteCommand();
            Console.WriteLine("审核流程成功条数：" + checkFlowList.Count);
        }

        /// <summary>
        /// 将审核流程与审核关系添加到新库中
        /// </summary>
        /// <param name="StaffInfo"></param>
        public static void AddCheckfuncAndCheckflowInNewDB(List<T_CH_Checkfunc_Checkflow_relation> oldCheckfuncAndCheckflowList)
        {
            List<t_sys_Checkfunc_Checkflow_relation> checkfuncAndCheckflowList = new();
            foreach (var item in oldCheckfuncAndCheckflowList)
            {
                t_sys_Checkfunc_Checkflow_relation checkfuncAndCheckflowInfo = new();
                checkfuncAndCheckflowInfo.Id = item.ID;
                checkfuncAndCheckflowInfo.Check_funcID = item.Check_funcID;
                checkfuncAndCheckflowInfo.Check_flowID = item.Check_flowID;
                checkfuncAndCheckflowList.Add(checkfuncAndCheckflowInfo);
            }
            SqlSugarUtils.db.Insertable(checkfuncAndCheckflowList).ExecuteCommand();
            Console.WriteLine("审核流程与审核关系成功条数：" + checkfuncAndCheckflowList.Count);
        }

        /// <summary>
        /// 将审核人添加到新库中
        /// </summary>
        /// <param name="StaffInfo"></param>
        public static void AddCheckerInNewDB(List<T_CH_Checker> oldCheckerList)
        {
            List<t_sys_checker> checkerList = new();
            foreach (var item in oldCheckerList)
            {
                t_sys_checker checkerInfo = new();
                checkerInfo.Id = item.ID;
                checkerInfo.CheckerID = item.CheckerID;
                checkerInfo.CheckFlowID = item.CheckFlowID;
                checkerInfo.lvl1 = item.lvl1;
                checkerInfo.lvl2 = item.lvl2;
                checkerList.Add(checkerInfo);
            }
            SqlSugarUtils.db.Insertable(checkerList).ExecuteCommand();
            Console.WriteLine("审核人成功条数：" + checkerList.Count);
        }

        #endregion


        #region 迁移资产申请、资产采购、资产入库、物料明细

        /// <summary>
        /// 将资产申请添加到新库中
        /// </summary>
        /// <param name="StaffInfo"></param>
        public static void AddApplyFixedAsseInNewDB(List<T_GM_ApplyFixedAsset> oldApplyFixedAssetList, List<T_GM_ApplyIndirect> oldApplyIndirectList)
        {
            List<t_cg_ApplyFixedAsset> applyFixedAssetList = new();
            foreach (var item in oldApplyFixedAssetList)
            {
                if (long.TryParse(item.Operator, out _))
                {
                    var empInfo = SqlSugarUtils.db.Queryable<sys_emp>().Where(it => it.JobNum == long.Parse(item.Operator)).First();
                    if (empInfo != null)
                    {
                        t_cg_ApplyFixedAsset applyFixedAssetInfo = new();
                        applyFixedAssetInfo.Id = item.GID;
                        applyFixedAssetInfo.ApplyNo = item.ApplyNo;
                        applyFixedAssetInfo.ApplicantName = item.Applicant;
                        applyFixedAssetInfo.ApplicantSector = item.ApplicantSector;
                        applyFixedAssetInfo.No_Date = item.No_Date;
                        applyFixedAssetInfo.AuditProcess = item.AuditProcess;
                        applyFixedAssetInfo.Company = item.Company;
                        applyFixedAssetInfo.status = item.Status;
                        applyFixedAssetInfo.description = item.Remark;
                        applyFixedAssetInfo.UseMan = item.UseMan;
                        applyFixedAssetInfo.ApplyType = "固定资产申请";
                        applyFixedAssetInfo.ApplicantId = item.Operator;
                        applyFixedAssetInfo.ProjectNo = item.ProjectNo;
                        applyFixedAssetInfo.CreatedTime = item.OperateTime;
                        applyFixedAssetInfo.CreatedUserId = empInfo.Id;
                        applyFixedAssetInfo.CreatedUserName = empInfo.StaffName;
                        applyFixedAssetInfo.IsDeleted = false;
                        applyFixedAssetList.Add(applyFixedAssetInfo);
                    }
                }
            }

            foreach (var item in oldApplyIndirectList)
            {
                if (long.TryParse(item.Operator, out _))
                {
                    var empInfo = SqlSugarUtils.db.Queryable<sys_emp>().Where(it => it.JobNum == long.Parse(item.Operator)).First();
                    if (empInfo != null)
                    {
                        t_cg_ApplyFixedAsset applyFixedAssetInfo = new();
                        applyFixedAssetInfo.Id = item.GID;
                        applyFixedAssetInfo.ApplyNo = item.ApplyIndirNo;
                        applyFixedAssetInfo.ApplicantName = item.ApplyMan;
                        applyFixedAssetInfo.ApplicantSector = item.ApplySector;
                        applyFixedAssetInfo.No_Date = item.OperateTime;
                        applyFixedAssetInfo.AuditProcess = item.CheckProcess;
                        applyFixedAssetInfo.status = item.ApplyMstate;
                        applyFixedAssetInfo.PurchaseType = item.PurchaseType;
                        applyFixedAssetInfo.description = item.Remark;
                        applyFixedAssetInfo.UseMan = item.ReceiveMan;
                        applyFixedAssetInfo.ApplyType = "间接资产申请";
                        applyFixedAssetInfo.ApplicantId = item.Operator;
                        applyFixedAssetInfo.CreatedTime = item.OperateTime;
                        applyFixedAssetInfo.CreatedUserId = empInfo.Id;
                        applyFixedAssetInfo.CreatedUserName = empInfo.StaffName;
                        applyFixedAssetInfo.IsDeleted = false;
                        applyFixedAssetList.Add(applyFixedAssetInfo);
                    }
                }
            }
            SqlSugarUtils.db.Insertable(applyFixedAssetList).ExecuteCommand();
            Console.WriteLine("资产申请成功条数：" + applyFixedAssetList.Count);
        }

        /// <summary>
        /// 将资产采购添加到新库中
        /// </summary>
        /// <param name="StaffInfo"></param>
        public static void AddPurchaseFixedAssetInNewDB(List<T_GM_PurchaseFixedAsset> oldPurchaseFixedAssetList, List<T_GM_PurchaseIndirect> oldPurchaseIndirectList)
        {
            List<t_cg_PurchaseFixedAsset> purchaseFixedAssetList = new();
            foreach (var item in oldPurchaseFixedAssetList)
            {
                if (long.TryParse(item.Operator, out _))
                {
                    var empInfo = SqlSugarUtils.db.Queryable<sys_emp>().Where(it => it.JobNum == long.Parse(item.Operator)).First();
                    if (empInfo != null)
                    {
                        t_cg_PurchaseFixedAsset purchaseFixedAssetInfo = new();
                        purchaseFixedAssetInfo.Id = item.GID;
                        purchaseFixedAssetInfo.PurchaseFNo = item.PurchaseFNo;
                        purchaseFixedAssetInfo.ApplyId = item.ApplyNo;
                        purchaseFixedAssetInfo.SupplierID = item.SupplierID;
                        purchaseFixedAssetInfo.PurchasePrice = item.PurchasePrice;
                        purchaseFixedAssetInfo.OrderType = item.OrderType;
                        purchaseFixedAssetInfo.No_Date = item.No_Date;
                        purchaseFixedAssetInfo.AuditProcess = item.AuditProcess;
                        purchaseFixedAssetInfo.Status = item.Status;
                        purchaseFixedAssetInfo.PurchaseType = "固定资产采购";
                        purchaseFixedAssetInfo.description = item.Remark;
                        purchaseFixedAssetInfo.Address = item.Address;
                        purchaseFixedAssetInfo.Tax = item.Tax;
                        purchaseFixedAssetInfo.Company = item.Company;
                        purchaseFixedAssetInfo.Id = item.GID;
                        purchaseFixedAssetInfo.CreatedTime = item.OperateTime;
                        purchaseFixedAssetInfo.CreatedUserId = empInfo.Id;
                        purchaseFixedAssetInfo.CreatedUserName = empInfo.StaffName;
                        purchaseFixedAssetInfo.IsDeleted = false;
                        purchaseFixedAssetList.Add(purchaseFixedAssetInfo);
                    }
                }
            }

            foreach (var item in oldPurchaseIndirectList)
            {
                if (long.TryParse(item.Operator, out _))
                {
                    var empInfo = SqlSugarUtils.db.Queryable<sys_emp>().Where(it => it.JobNum == long.Parse(item.Operator)).First();
                    if (empInfo != null)
                    {
                        t_cg_PurchaseFixedAsset purchaseFixedAssetInfo = new();
                        purchaseFixedAssetInfo.Id = item.GID;
                        purchaseFixedAssetInfo.PurchaseFNo = item.PurchaseINo;
                        purchaseFixedAssetInfo.ApplyId = item.ApplyNo;
                        purchaseFixedAssetInfo.SupplierID = "00000";
                        purchaseFixedAssetInfo.PurchasePrice = item.PurchasePrice;
                        purchaseFixedAssetInfo.No_Date = item.OperateTime;
                        purchaseFixedAssetInfo.AuditProcess = item.AuditProcess;
                        purchaseFixedAssetInfo.Status = item.Status;
                        purchaseFixedAssetInfo.PurchaseType = "间接资产采购";
                        purchaseFixedAssetInfo.description = item.Remark;
                        purchaseFixedAssetInfo.Tax = item.Tax;
                        purchaseFixedAssetInfo.Id = item.GID;
                        purchaseFixedAssetInfo.CreatedTime = item.OperateTime;
                        purchaseFixedAssetInfo.CreatedUserId = empInfo.Id;
                        purchaseFixedAssetInfo.CreatedUserName = empInfo.StaffName;
                        purchaseFixedAssetInfo.IsDeleted = false;
                        purchaseFixedAssetList.Add(purchaseFixedAssetInfo);
                    }
                }
            }
            SqlSugarUtils.db.Insertable(purchaseFixedAssetList).ExecuteCommand();
            Console.WriteLine("资产采购成功条数：" + purchaseFixedAssetList.Count);
        }

        /// <summary>
        /// 将资产入库添加到新库中
        /// </summary>
        /// <param name="StaffInfo"></param>
        public static void AddStorageFixedAssetInNewDB(List<T_GM_StorageFixedAsset> oldStorageFixedAssetList)
        {
            List<t_cg_StorageFixedAsset> storageFixedAssetList = new();
            foreach (var item in oldStorageFixedAssetList)
            {
                if (long.TryParse(item.Operator, out _))
                {
                    var empInfo = SqlSugarUtils.db.Queryable<sys_emp>().Where(it => it.JobNum == long.Parse(item.Operator)).First();
                    if (empInfo != null)
                    {
                        t_cg_StorageFixedAsset storageFixedAssetInfo = new();
                        storageFixedAssetInfo.Id = item.GID;
                        storageFixedAssetInfo.StorageNo = item.StorageNo;
                        storageFixedAssetInfo.PFAGID = item.PFAGID;
                        storageFixedAssetInfo.WarehouseID = item.WarehouseID;
                        storageFixedAssetInfo.StorageType = item.StorageType;
                        storageFixedAssetInfo.No_Date = item.No_Date;
                        storageFixedAssetInfo.AuditProcess = item.AuditProcess;
                        storageFixedAssetInfo.Status = item.Status;
                        storageFixedAssetInfo.description = item.Remark;
                        storageFixedAssetInfo.Enclosure = item.Enclosure;
                        storageFixedAssetInfo.CreatedTime = item.OperateTime;
                        storageFixedAssetInfo.CreatedUserId = empInfo.Id;
                        storageFixedAssetInfo.CreatedUserName = empInfo.StaffName;
                        storageFixedAssetInfo.IsDeleted = false;
                        storageFixedAssetList.Add(storageFixedAssetInfo);
                    }
                }
            }
            SqlSugarUtils.db.Insertable(storageFixedAssetList).ExecuteCommand();
            Console.WriteLine("资产入库成功条数：" + storageFixedAssetList.Count);
        }

        /// <summary>
        /// 将物料明细添加到新库中
        /// </summary>
        /// <param name="StaffInfo"></param>
        public static void AddJMInNewDB(List<T_GM_JM> oldJMList)
        {
            List<t_cg_jm> jmList = new();
            foreach (var item in oldJMList)
            {

                t_cg_jm jmInfo = new();
                jmInfo.Id = (int)item.UID;
                jmInfo.Name = item.Name;
                jmInfo.Type = item.Type;
                jmInfo.Price = item.Price;
                jmInfo.Size = item.Size;
                jmInfo.Num = item.Num;
                jmInfo.CurrentNum = SqlSugarUtils.db.QueryableWithAttr<T_GM_JMTemp>().Where(it => it.IdentifyID == item.IdentifyID && it.Remark == item.Remark).Select(it => it.Num).First();
                jmInfo.FinalNum = SqlSugarUtils.db.QueryableWithAttr<T_GM_JMBackup>().Where(it => it.IdentifyID == item.IdentifyID && it.Remark == item.Remark).Select(it => it.Num).First();
                jmInfo.Unit = item.Unit;
                jmInfo.Remark = item.Remark;
                jmInfo.Extra = item.Extra;
                jmInfo.Number = item.Number;
                jmInfo.Brand = item.Brand;
                jmInfo.IsDeleted = false;
                jmInfo.IdentifyID = item.IdentifyID;
                jmList.Add(jmInfo);

            }
            SqlSugarUtils.db.Insertable(jmList).ExecuteCommand();
            Console.WriteLine("物料明细成功条数：" + jmList.Count);
        }
        #endregion


    }
}
