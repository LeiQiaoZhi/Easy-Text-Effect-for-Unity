﻿#if UNITY_EDITOR
using System;
using UnityEngine;

namespace EasyTextEffects.Editor.MyBoxCopy.Types.EditorTypes
{
	public class ConditionallyColoredGUIBlock : IDisposable
	{
		private readonly Color _originalColor;

		public ConditionallyColoredGUIBlock(bool condition, Color color)
		{
			_originalColor = GUI.color;

			if (condition) GUI.color = color;
		}

		public void Dispose()
		{
			GUI.color = _originalColor;
		}
	}
}
#endif