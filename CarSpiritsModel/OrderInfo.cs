using System;
namespace CarSpirits.Model
{
	/// <summary>
	/// OrderInfo:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
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
		/// �������
		/// </summary>
		public string OrderID
		{
			set{ _orderid=value;}
			get{return _orderid;}
		}
		/// <summary>
		/// ���ƺ�
		/// </summary>
		public string PlateNumber
		{
			set{ _platenumber=value;}
			get{return _platenumber;}
		}
		/// <summary>
		/// ����վ
		/// </summary>
		public string GasStation
		{
			set{ _gasstation=value;}
			get{return _gasstation;}
		}
		/// <summary>
		/// �ͺ�
		/// </summary>
		public string GasOline
		{
			set{ _gasoline=value;}
			get{return _gasoline;}
		}
		/// <summary>
		/// �ܼ�
		/// </summary>
		public decimal? Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// �µ�ʱ��
		/// </summary>
		public DateTime? OrderTime
		{
			set{ _ordertime=value;}
			get{return _ordertime;}
		}
		#endregion Model

	}
}

