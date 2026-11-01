namespace Microsoft.Office.Core;

public enum MsoSyncEventType
{
	msoSyncEventDownloadInitiated,
	msoSyncEventDownloadSucceeded,
	msoSyncEventDownloadFailed,
	msoSyncEventUploadInitiated,
	msoSyncEventUploadSucceeded,
	msoSyncEventUploadFailed,
	msoSyncEventDownloadNoChange,
	msoSyncEventOffline
}
