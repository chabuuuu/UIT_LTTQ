using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form1 : Form
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WH_MOUSE_LL = 14;

        private const int WM_KEYDOWN = 0x0100;
        private const int WM_MOUSEMOVE = 0x0200;
        private const int WM_LBUTTONDOWN = 0x0201;
        private const int WM_RBUTTONDOWN = 0x0204;

        private delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);
        private static HookProc keyboardHookCallback;
        private static HookProc mouseHookCallback;
        private static IntPtr keyboardHookId = IntPtr.Zero;
        private static IntPtr mouseHookId = IntPtr.Zero;
        public Form1()
        {
            InitializeComponent();
            InitializeKeyboardHook();
            InitializeMouseHook();
        }
        private void InitializeKeyboardHook()
        {
            keyboardHookCallback = KeyboardHookCallback;
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                keyboardHookId = SetWindowsHookEx(WH_KEYBOARD_LL, keyboardHookCallback, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private void InitializeMouseHook()
        {
            mouseHookCallback = MouseHookCallback;
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                mouseHookId = SetWindowsHookEx(WH_MOUSE_LL, mouseHookCallback, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private IntPtr KeyboardHookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                // Hiển thị thông tin về phím được nhấn
                label1.Text = $"Key Pressed: ASCII: {vkCode}, Key Code: {Enum.GetName(typeof(Keys), vkCode)}";
            }

            // Gọi hook tiếp theo trong chuỗi
            return CallNextHookEx(keyboardHookId, nCode, wParam, lParam);
        }

        private IntPtr MouseHookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                if (wParam == (IntPtr)WM_LBUTTONDOWN)
                {
                    MSLLHOOKSTRUCT hookStruct = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));
                    // Hiển thị thông tin về nút chuột và tọa độ chuột
                    label1.Text = $"Left Mouse Button Pressed at X: {hookStruct.pt.x}, Y: {hookStruct.pt.y}";
                }
                else if (wParam == (IntPtr)WM_RBUTTONDOWN)
                {
                    MSLLHOOKSTRUCT hookStruct = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));
                    // Hiển thị thông tin về nút chuột và tọa độ chuột
                    label1.Text = $"Right Mouse Button Pressed at X: {hookStruct.pt.x}, Y: {hookStruct.pt.y}";
                }
            }

            // Gọi hook tiếp theo trong chuỗi
            return CallNextHookEx(mouseHookId, nCode, wParam, lParam);
        }

        #region API Functions

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        #endregion

        #region Structures

        [StructLayout(LayoutKind.Sequential)]
        private struct MSLLHOOKSTRUCT
        {
            public POINT pt;
            public uint mouseData;
            public uint flags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct POINT
        {
            public int x;
            public int y;
        }

        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Hủy bỏ hook trước khi đóng form
            UnhookWindowsHookEx(keyboardHookId);
            UnhookWindowsHookEx(mouseHookId);
        }
    }
}
