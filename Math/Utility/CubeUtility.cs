using UnityEngine;

namespace Common
{
	public static class CubeUtility
	{
		public const float SIDE_LENGTH = 1.0f;
		public const float CENTER_TO_SIDE = SIDE_LENGTH * 0.5f;

		public static readonly Vector3[] Vertices = new Vector3[]
		{
			new Vector3(-CENTER_TO_SIDE, -CENTER_TO_SIDE, -CENTER_TO_SIDE),
			new Vector3(-CENTER_TO_SIDE, +CENTER_TO_SIDE, -CENTER_TO_SIDE),
			new Vector3(+CENTER_TO_SIDE, +CENTER_TO_SIDE, -CENTER_TO_SIDE),
			new Vector3(+CENTER_TO_SIDE, -CENTER_TO_SIDE, -CENTER_TO_SIDE),
			new Vector3(-CENTER_TO_SIDE, -CENTER_TO_SIDE, +CENTER_TO_SIDE),
			new Vector3(-CENTER_TO_SIDE, +CENTER_TO_SIDE, +CENTER_TO_SIDE),
			new Vector3(+CENTER_TO_SIDE, +CENTER_TO_SIDE, +CENTER_TO_SIDE),
			new Vector3(+CENTER_TO_SIDE, -CENTER_TO_SIDE, +CENTER_TO_SIDE)
		};
		
		public static readonly int[][] Triangles = new int[][]
		{
			new int[] { 4, 5, 1, 4, 1, 0, -1 },
			new int[] { 3, 2, 6, 3, 6, 7, -1 },
			new int[] { 4, 0, 3, 4, 3, 7, -1 },
			new int[] { 1, 5, 6, 1, 6, 2, -1 },
			new int[] { 0, 1, 2, 0, 2, 3, -1 },
			new int[] { 7, 6, 5, 7, 5, 4, -1 }
		};
	}
}