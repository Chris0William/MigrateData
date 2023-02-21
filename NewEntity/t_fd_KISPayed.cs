using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace MigrateData.NewEntity
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("t_fd_KISPayed")]
	[Tenant("newDb")]
    public partial class t_fd_KISPayed
    {
           public t_fd_KISPayed(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:单据状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string billState {get;set;}

           /// <summary>
           /// Desc:付款日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime PayDate {get;set;}

           /// <summary>
           /// Desc:金蝶系统审核人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string KisOperator {get;set;}

           /// <summary>
           /// Desc:单据号码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string billNo {get;set;}

           /// <summary>
           /// Desc:核算类别
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string accountCategory {get;set;}

           /// <summary>
           /// Desc:核算项目
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string accountProject {get;set;}

           /// <summary>
           /// Desc:实付金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal PayAmount {get;set;}

           /// <summary>
           /// Desc:导入日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? InputDate {get;set;}

           /// <summary>
           /// Desc:导入人 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string InputMan {get;set;}

           /// <summary>
           /// Desc:修改日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? EditDate {get;set;}

           /// <summary>
           /// Desc:修改人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EditMan {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark {get;set;}

    }
}
