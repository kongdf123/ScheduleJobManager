using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace JobMonitor.Utility
{
	public class CacheHelper
	{
		static System.Web.Caching.Cache cache = HttpRuntime.Cache;

		public static CacheHelper CreateInstance() {
			return new CacheHelper();
		}

		public T GetCache<T>(string cacheKey) where T : class {
			if ( cache[cacheKey] != null ) {
				return (T)cache[cacheKey];
			}
			return default(T);
		}
		public void SetCache<T>(T value, string cacheKey) where T : class {
			cache.Insert(cacheKey, value, null, DateTime.Now.AddMinutes(10), System.Web.Caching.Cache.NoSlidingExpiration);
		}
		public void SetCache<T>(T value, string cacheKey, DateTime expireTime) where T : class {
			cache.Insert(cacheKey, value, null, expireTime, System.Web.Caching.Cache.NoSlidingExpiration);
		}
		public void RemoveCache(string cacheKey) {
			cache.Remove(cacheKey);
		}
		public void RemoveCache() {
			IDictionaryEnumerator CacheEnum = cache.GetEnumerator();
			while ( CacheEnum.MoveNext() ) {
				cache.Remove(CacheEnum.Key.ToString());
			}
		}
	}
}
