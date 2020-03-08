using ZXing.Common;

namespace ZXing.Mobile
{
    internal class BarcodeWriter
    {
        public BarcodeFormat Format { get; set; }
        public EncodingOptions Options { get; set; }
    }
}