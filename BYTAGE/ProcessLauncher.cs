using System;

namespace BYTAGE
{
    class ProcessLauncher
    {
        IntPtr ThreadHandle = IntPtr.Zero;

        public bool LaunchProcessSuspended(string processpath, int initialResumeTime, out uint PID)
        {
            STARTUPINFO si = new STARTUPINFO();
            PROCESS_INFORMATION pi = new PROCESS_INFORMATION();
            bool success = NativeMethods.CreateProcess(processpath, null, IntPtr.Zero, IntPtr.Zero, false, ProcessCreationFlags.CREATE_SUSPENDED, IntPtr.Zero, null, ref si, out pi);
            ThreadHandle = pi.hThread;
            PID = pi.dwProcessId;

            if (initialResumeTime > 0) {
                NativeMethods.ResumeThread(ThreadHandle);
                System.Threading.Thread.Sleep(initialResumeTime);
                NativeMethods.SuspendThread(ThreadHandle);
            }

            return success;
        }

        public void ResumeProcess()
        {
            NativeMethods.ResumeThread(ThreadHandle);
        }
    }
}