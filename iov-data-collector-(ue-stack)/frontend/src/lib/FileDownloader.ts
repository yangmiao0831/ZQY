export class FileDownloader {
  async downloadFile(
    url: string,
    filename: string,
    onProgress?: (progress: { percentage: number; loaded: number; total: number }) => void,
    signal?: AbortSignal
  ): Promise<{ success: boolean; cancelled?: boolean; message?: string }> {
    try {
      const response = await fetch(url, { signal });
      if (!response.ok) {
        return { success: false, message: `HTTP Error ${response.status}` };
      }

      const contentLength = response.headers.get('content-length');
      const total = contentLength ? parseInt(contentLength, 10) : 0;
      
      let loaded = 0;
      
      const reader = response.body?.getReader();
      if (!reader) {
        // Fallback for browsers that don't support ReadableStream
        const blob = await response.blob();
        if (onProgress) {
          onProgress({ loaded: blob.size, total: blob.size, percentage: 100 });
        }
        this.saveBlob(blob, filename);
        return { success: true };
      }

      const chunks: Uint8Array[] = [];

      while (true) {
        const { done, value } = await reader.read();
        if (done) break;

        if (value) {
          chunks.push(value);
          loaded += value.length;
          
          if (onProgress) {
              onProgress({ 
                loaded, 
                total, 
                percentage: total ? Math.min(100, Math.round((loaded / total) * 100)) : 100 
              });
          }
        }
      }

      if (signal?.aborted) {
        return { success: false, cancelled: true, message: 'Download cancelled' };
      }

      const blob = new Blob(chunks);
      this.saveBlob(blob, filename);

      return { success: true };
    } catch (error: any) {
      if (error?.name === 'AbortError' || signal?.aborted) {
        return { success: false, cancelled: true, message: 'Download cancelled' };
      }
      return { success: false, message: error.message || 'Network request failed' };
    }
  }

  private saveBlob(blob: Blob, filename: string) {
    const blobUrl = URL.createObjectURL(blob);
    const a = document.createElement('a');
    a.href = blobUrl;
    a.download = filename;
    document.body.appendChild(a);
    a.click();
    document.body.removeChild(a);
    URL.revokeObjectURL(blobUrl);
  }
}
