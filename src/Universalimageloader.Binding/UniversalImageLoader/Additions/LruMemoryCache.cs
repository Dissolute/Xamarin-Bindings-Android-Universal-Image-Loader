namespace Com.Nostra13.Universalimageloader.Cache.Memory.Impl
{
    public partial class LruMemoryCache
    {
        global::System.Collections.ICollection Com.Nostra13.Universalimageloader.Cache.Memory.IMemoryCacheAware.Keys()
        {
            return (global::System.Collections.ICollection)Keys();
        }

        public global::Java.Lang.Object Get(global::Java.Lang.Object p0)
        {
            return Get((string)p0);
        }

        public void Remove(global::Java.Lang.Object p0)
        {
            Remove((string)p0);
        }

        public bool Put(global::Java.Lang.Object p0, global::Java.Lang.Object p1)
        {
            return Put((string)p0, (global::Android.Graphics.Bitmap)p1);
        }
    }
}
