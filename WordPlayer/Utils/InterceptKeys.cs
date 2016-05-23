using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;
using System.Threading;
using WordPlayer.AudioPlayer;

namespace WordPlayer.Utils
{
    public class InterceptKeys
    {
        public delegate int LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;
        private const int WH_KEYBOARD = 2;
        private const int HC_ACTION = 0;
        
        public static void SetHook()
        {    
            _hookID = SetWindowsHookEx(WH_KEYBOARD, _proc, IntPtr.Zero, (uint) AppDomain.GetCurrentThreadId());
        }

        public static void ReleaseHook()
        {
            UnhookWindowsHookEx(_hookID);
        }

        private static int HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            int PreviousStateBit = 31;
            bool KeyWasAlreadyPressed = false;
            Int64 bitmask = (Int64) Math.Pow(2, (PreviousStateBit - 1));
            try
            {
                if (nCode < 0)
                {
                    return (int) CallNextHookEx(_hookID, nCode, wParam, lParam);
                }
                else
                {
                    if (nCode == HC_ACTION)
                    {
                        Keys keyData = (Keys) wParam;
                        KeyWasAlreadyPressed = ((Int64) lParam & bitmask) > 0;

                        if (Functions.IsKeyDown(Keys.ControlKey) && KeyWasAlreadyPressed == false)
                        {
                            switch (keyData)
                            {
                                case Keys.D1:
                                    MessageBox.Show("Key press 1 as shortcut"+ (uint) Thread.CurrentThread.ManagedThreadId + " " + (int) Thread.CurrentThread.ManagedThreadId);
                                    break;
                                case Keys.D:
                                    MessageBox.Show("Key press D as shortcut");
                                    break;
                                case Keys.D2:
                                    MessageBox.Show("Key press 2 as shortcut");
                                    break;
                            }
                        }
                    }
                    return (int) CallNextHookEx(_hookID, nCode, wParam, lParam);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return (int) CallNextHookEx(_hookID, nCode, wParam, lParam);
            }
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);
    }

    public class Functions
    {
        public static bool IsKeyDown(Keys keys)
        {
            return (GetKeyState((int)keys) & 0x8000) == 0x8000;
        }

        [DllImport("user32.dll")]
        static extern short GetKeyState(int nVirtKey);

    }
}
