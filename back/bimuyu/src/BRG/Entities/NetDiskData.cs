namespace BRG.Entities
{
	public class NetDiskData : INetDiskData
	{
		/// <summary>
		/// ��ַ
		/// </summary>
		public string Url { get; set; }

		/// <summary>
		/// ����
		/// </summary>
		public string Pwd { get; set; }

		/// <summary>
		/// �����������
		/// </summary>
		public NetDiskType NetDiskType { get; set; }
	}
}