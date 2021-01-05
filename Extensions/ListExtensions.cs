using System;
using System.Collections.Generic;

namespace Common
{
	public static class ListExtensions
	{
		public static bool IsNullOrEmpty<T>(this List<T> list)
		{
			return list == null || list.Count == 0;
		}

		public static int GetCountSafely<T>(this List<T> list)
		{
			if (list == null)
				return 0;
			return list.Count;
		}

		public static T First<T>(this List<T> list)
		{
			return list[0];
		}

		public static T Last<T>(this List<T> list)
		{
			return list[list.Count - 1];
		}

		public static void RemoveLast<T>(this List<T> list)
		{
			list.RemoveAt(list.Count - 1);
		}

		public static void RemoveLast<T>(this List<T> list, int count)
		{
			list.RemoveRange(list.Count - 1 - count, count);
		}

		public static T Revoke<T>(this List<T> list, int index)
		{
			var result = list[index];
			list.RemoveAt(index);
			return result;
		}

		public static T RevokeLast<T>(this List<T> list)
		{
			var last = list.Last();
			list.RemoveLast();
			return last;
		}

		public static T[] RevokeLast<T>(this List<T> list, int count)
		{
			var last = new T[count];
			list.CopyTo(list.Count - 1 - count, last, 0, count);
			list.RemoveLast(count);
			return last;
		}

		public static void Shuffle<T>(this List<T> list, int seed = default)
		{
			var random = new Random(seed);
			int n = list.Count;
			while (n-- > 1)
			{
				int k = random.Next(0, n);
				T value = list[k];
				list[k] = list[n];
				list[n] = value;
			}
		}

		public static List<T> Populate<T>(this List<T> list, T value)
		{
			for (int i = 0; i < list.Count; ++i)
				list[i] = value;
			return list;
		}
	}
}