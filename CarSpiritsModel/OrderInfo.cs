using System;
namespace CarSpirits.Model
{
	/// <summary>
	/// OrderInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class OrderInfo
	{
		public OrderInfo()
		{}
		#region Model
		private int _id;
		private string _customerid;
		private string _orderid;
		private string _platenumber;
		private string _gasstation;
		private string _gasoline;
		private decimal? _price;
		private DateTime? _ordertime= DateTime.Now;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CustomerID
		{
			set{ _customerid=value;}
			get{return _customerid;}
		}
		/// <summary>
		/// 订单编号
		/// </summary>
		public string OrderID
		{
			set{ _orderid=value;}
			get{return _orderid;}
		}
		/// <summary>
		/// 车牌号
		/// </summary>
		public string PlateNumber
		{
			set{ _platenumber=value;}
			get{return _platenumber;}
		}
		/// <summary>
		/// 加油站
		/// </summary>
		public string GasStation
		{
			set{ _gasstation=value;}
			get{return _gasstation;}
		}
		/// <summary>
		/// 油号
		/// </summary>
		public string GasOline
		{
			set{ _gasoline=value;}
			get{return _gasoline;}
		}
		/// <summary>
		/// 总价
		/// </summary>
		public decimal? Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 下单时间
		/// </summary>
		public DateTime? OrderTime
		{
			set{ _ordertime=value;}
			get{return _ordertime;}
		}
		#endregion Model

	}
}

