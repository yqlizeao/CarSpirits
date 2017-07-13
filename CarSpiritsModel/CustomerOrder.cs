using System;
namespace CarSpirits.Model
{
	/// <summary>
	/// CustomerOrder:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CustomerOrder
	{
		public CustomerOrder()
		{}
		#region Model
		private string _订单号;
		private string _用户名;
		private string _用户姓名;
		private string _手机号;
		private string _车牌号;
		private string _加油站;
		private string _油号;
		private decimal? _金额;
		private DateTime? _下单时间;
		/// <summary>
		/// 
		/// </summary>
		public string 订单号
		{
			set{ _订单号=value;}
			get{return _订单号;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 用户名
		{
			set{ _用户名=value;}
			get{return _用户名;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 用户姓名
		{
			set{ _用户姓名=value;}
			get{return _用户姓名;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 手机号
		{
			set{ _手机号=value;}
			get{return _手机号;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 车牌号
		{
			set{ _车牌号=value;}
			get{return _车牌号;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 加油站
		{
			set{ _加油站=value;}
			get{return _加油站;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string 油号
		{
			set{ _油号=value;}
			get{return _油号;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? 金额
		{
			set{ _金额=value;}
			get{return _金额;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? 下单时间
		{
			set{ _下单时间=value;}
			get{return _下单时间;}
		}
		#endregion Model

	}
}

