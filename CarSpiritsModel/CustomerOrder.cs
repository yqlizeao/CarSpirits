using System;
namespace CarSpirits.Model
{
	/// <summary>
	/// CustomerOrder:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public partial class CustomerOrder
	{
		public CustomerOrder()
		{}
		#region Model
		private string _������;
		private string _�û���;
		private string _�û�����;
		private string _�ֻ���;
		private string _���ƺ�;
		private string _����վ;
		private string _�ͺ�;
		private decimal? _���;
		private DateTime? _�µ�ʱ��;
		/// <summary>
		/// 
		/// </summary>
		public string ������
		{
			set{ _������=value;}
			get{return _������;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string �û���
		{
			set{ _�û���=value;}
			get{return _�û���;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string �û�����
		{
			set{ _�û�����=value;}
			get{return _�û�����;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string �ֻ���
		{
			set{ _�ֻ���=value;}
			get{return _�ֻ���;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ���ƺ�
		{
			set{ _���ƺ�=value;}
			get{return _���ƺ�;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ����վ
		{
			set{ _����վ=value;}
			get{return _����վ;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string �ͺ�
		{
			set{ _�ͺ�=value;}
			get{return _�ͺ�;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ���
		{
			set{ _���=value;}
			get{return _���;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? �µ�ʱ��
		{
			set{ _�µ�ʱ��=value;}
			get{return _�µ�ʱ��;}
		}
		#endregion Model

	}
}

