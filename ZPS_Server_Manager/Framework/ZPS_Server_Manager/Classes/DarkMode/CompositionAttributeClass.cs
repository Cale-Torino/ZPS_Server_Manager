using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ZPS_Server_Manager
{
    internal class CompositionAttributeClass
    {
		[DllImport("user32.dll")]
		internal static extern int SetWindowCompositionAttribute(IntPtr hwnd, ref WindowCompositionAttributeData data);

		[StructLayout(LayoutKind.Sequential)]
		internal struct WindowCompositionAttributeData
		{
			public WindowCompositionAttribute Attribute;
			public IntPtr Data;
			public int SizeOfData;
		}

		internal enum WindowCompositionAttribute
		{
			// ...
			WCA_ACCENT_POLICY = 19
			// ...
		}

		internal enum AccentState
		{
			ACCENT_DISABLED = 0,
			ACCENT_ENABLE_GRADIENT = 1,
			ACCENT_ENABLE_TRANSPARENTGRADIENT = 2,
			ACCENT_ENABLE_BLURBEHIND = 3,
			ACCENT_INVALID_STATE = 4
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct AccentPolicy
		{
			public AccentState AccentState;
			public int AccentFlags;
			public int GradientColor;
			public int AnimationId;
		}
		internal static void EnableBlur(IntPtr HWnd, bool hasFrame = true)
		{

			CompositionAttributeClass.AccentPolicy accent = new CompositionAttributeClass.AccentPolicy();
			accent.AccentState = CompositionAttributeClass.AccentState.ACCENT_ENABLE_BLURBEHIND;
			if (hasFrame)
				accent.AccentFlags = 0x20 | 0x40 | 0x80 | 0x100;

			int accentStructSize = Marshal.SizeOf(accent);

			IntPtr accentPtr = Marshal.AllocHGlobal(accentStructSize);
			Marshal.StructureToPtr(accent, accentPtr, false);

			CompositionAttributeClass.WindowCompositionAttributeData data = new CompositionAttributeClass.WindowCompositionAttributeData();
			data.Attribute = CompositionAttributeClass.WindowCompositionAttribute.WCA_ACCENT_POLICY;
			data.SizeOfData = accentStructSize;
			data.Data = accentPtr;

			CompositionAttributeClass.SetWindowCompositionAttribute(HWnd, ref data);

			Marshal.FreeHGlobal(accentPtr);
		}
	}
}
