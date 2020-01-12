using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace BYTAGE
{
	public static class ProcessExtension
	{
		[DllImport("kernel32.dll")]
		private static extern IntPtr OpenThread(ProcessExtension.ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

		[DllImport("kernel32.dll")]
		private static extern uint SuspendThread(IntPtr hThread);

		[DllImport("kernel32.dll")]
		private static extern int ResumeThread(IntPtr hThread);

		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool CloseHandle(IntPtr handle);

		public static void SuspendProcess(int pid)
		{
			Process processById = Process.GetProcessById(pid);
			bool flag = processById.ProcessName == string.Empty;
			if (!flag) {
				foreach (object obj in processById.Threads) {
					ProcessThread processThread = (ProcessThread)obj;
					IntPtr intPtr = ProcessExtension.OpenThread(ProcessExtension.ThreadAccess.SUSPEND_RESUME, false, (uint)processThread.Id);
					bool flag2 = intPtr == IntPtr.Zero;
					if (!flag2) {
						ProcessExtension.SuspendThread(intPtr);
						ProcessExtension.CloseHandle(intPtr);
					}
				}
			}
		}

		public static void ResumeProcess(int pid)
		{
			Process processById = Process.GetProcessById(pid);
			bool flag = processById.ProcessName == string.Empty;
			if (!flag) {
				foreach (object obj in processById.Threads) {
					ProcessThread processThread = (ProcessThread)obj;
					IntPtr intPtr = ProcessExtension.OpenThread(ProcessExtension.ThreadAccess.SUSPEND_RESUME, false, (uint)processThread.Id);
					bool flag2 = intPtr == IntPtr.Zero;
					if (!flag2) {
						int num;
						do {
							num = ProcessExtension.ResumeThread(intPtr);
						}
						while (num > 0);
						ProcessExtension.CloseHandle(intPtr);
					}
				}
			}
		}

		[Flags]
		public enum ThreadAccess
		{
			TERMINATE = 1,
			SUSPEND_RESUME = 2,
			GET_CONTEXT = 8,
			SET_CONTEXT = 16,
			SET_INFORMATION = 32,
			QUERY_INFORMATION = 64,
			SET_THREAD_TOKEN = 128,
			IMPERSONATE = 256,
			DIRECT_IMPERSONATION = 512
		}
	}
}