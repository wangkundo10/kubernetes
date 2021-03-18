namespace BRG.Service
{
	using BRG.Entities;

	public interface IResourceOperation
	{
		void PrepareFullDetail(params IResourceInfo[] torrents);
		/// <summary>
		/// ����������Դ
		/// </summary>
		/// <param name="torrents"></param>
		void AccquireDownloadTorrent(params IResourceInfo[] torrents);
		void CopyHash(params IResourceInfo[] torrents);
		void CopyEd2k(params IResourceInfo[] torrents);

		/// <summary>
		/// ������������
		/// </summary>
		/// <param name="resources"></param>
		void CopyDownloadLink(params IResourceInfo[] resources);


		/// <summary>
		/// ������ҳ��
		/// </summary>
		/// <param name="resources"></param>
		void OpenDownloadPage(params IResourceInfo[] resources);

		void CopyTitle(params IResourceInfo[] torrents);
		/// <summary>
		/// ����Դ���Ϊ������
		/// </summary>
		/// <param name="torrents"></param>
		void MarkDone(params IResourceInfo[] torrents);
		/// <summary>
		/// ����Դ���Ϊ������
		/// </summary>
		/// <param name="torrents"></param>
		void MarkUndone(params IResourceInfo[] torrents);
		void BaiduSearch(IResourceInfo resource);
		void GoogleSearch(IResourceInfo resource);
		void CopyMagnetLink(params IResourceInfo[] torrents);
		/// <summary>
		/// �鿴��ϸ��Ϣ
		/// </summary>
		/// <param name="provider"></param>
		/// <param name="resource"></param>
		void ViewDetail(IResourceProvider provider, IResourceInfo resource);

		/// <summary>
		/// �鿴��������
		/// </summary>
		/// <param name="provider"></param>
		/// <param name="resource"></param>
		void ViewTorrentContents(IResourceProvider provider, IResourceInfo resource);
		/// <summary>
		/// ���ñ�ע
		/// </summary>
		/// <param name="maskName"></param>
		/// <param name="resource"></param>
		void SetTorrentMask(string maskName, params IResourceInfo[] resource);

		/// <summary>
		/// ��ʾ����֪ͨ
		/// </summary>
		/// <param name="msg"></param>
		void ShowFloatTip(string msg);
	}
}