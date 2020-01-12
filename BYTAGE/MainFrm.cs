using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace BYTAGE
{
    public partial class MainFrm : Form
    {
        string targetPath, targetName, targetProcess;
        string originalPath, originalName;
        string replacementPath, replacementName;

        ProcessLauncher p = new ProcessLauncher();

        public MainFrm()
        {
            InitializeComponent();
        }

        private void BtnTarget_Click(object sender, EventArgs e)
        {
            ofd.Title = "Target";
            ofd.Filter = "Target|*.exe";

            DialogResult result;

            result = ofd.ShowDialog();

            if (result == DialogResult.OK && ofd.SafeFileName.EndsWith(".exe")) {
                targetPath = ofd.FileName;
                targetName = ofd.SafeFileName;
                targetProcess = ofd.SafeFileName.Remove(ofd.SafeFileName.Length - 4);

                targetTB.Text = targetName;
            }
            else {
                MessageBox.Show("Please select the target application.", "BYTAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnOriginal_Click(object sender, EventArgs e)
        {
            ofd.Title = "Original .dll";
            ofd.Filter = "DLL|*.dll";

            DialogResult result;

            result = ofd.ShowDialog();

            if (result == DialogResult.OK && ofd.SafeFileName.EndsWith(".dll")) {
                originalPath = ofd.FileName;
                originalName = ofd.SafeFileName;

                originalTB.Text = originalName;
            }
            else {
                MessageBox.Show("Please select the original DLL file.", "BYTAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnReplacement_Click(object sender, EventArgs e)
        {
            ofd.Title = "Replacement .dll";
            ofd.Filter = "DLL|*.dll";

            DialogResult result;

            result = ofd.ShowDialog();

            if (result == DialogResult.OK && ofd.SafeFileName.EndsWith(".dll")) {
                replacementPath = ofd.FileName;
                replacementName = ofd.SafeFileName;

                replacementTB.Text = replacementName;
            }
            else {
                MessageBox.Show("Please select the replacement DLL file.", "BYTAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnReplaceOnly_Click(object sender, EventArgs e)
        {
            // Check for empty textboxes
            if (string.IsNullOrEmpty(targetTB.Text) || string.IsNullOrEmpty(originalTB.Text) || string.IsNullOrEmpty(replacementTB.Text)) {
                MessageBox.Show("Please select all files before replacing.", "BYTAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Try to kill already running process
            foreach (Process p in Process.GetProcesses()) {
                if (p.ProcessName.ToLower().Contains(targetProcess.ToLower())) {
                    try {
                        p.Kill();
                    }
                    catch {
                        MessageBox.Show("Could not kill target process, please check permissions and make sure that the target process isn't already running.", "BYTAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            // Rename original DLL
            try {
                File.Move(Application.StartupPath + originalName, Application.StartupPath + originalName + ".BAK");
                File.Move(targetPath.Replace(targetName, string.Empty) + originalName, targetPath.Replace(targetName, string.Empty) + originalName + ".BAK");
            }
            catch {
                MessageBox.Show("Could not rename DLL, please check permissions.", "BYTAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Replace Custom DLL
            try {
                File.Copy(replacementPath, Application.StartupPath + originalName, true);
                File.Copy(replacementPath, targetPath.Replace(targetName, string.Empty) + originalName, true);
            }
            catch {
                MessageBox.Show("Could not copy DLL, please check permissions.", "BYTAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Successfully replaced DLL.", "BYTAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnNoBypass_Click(object sender, EventArgs e)
        {
            // Check for empty textboxes
            if (string.IsNullOrEmpty(targetTB.Text) || string.IsNullOrEmpty(originalTB.Text) || string.IsNullOrEmpty(replacementTB.Text)) {
                MessageBox.Show("Please select all files before bypassing.", "BYTAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Try to kill already running process
            foreach (Process p in Process.GetProcesses()) {
                if (p.ProcessName.ToLower().Contains(targetProcess.ToLower())) {
                    try {
                        p.Kill();
                    }
                    catch {
                        MessageBox.Show("Could not kill target process, please check permissions and make sure that the target process isn't already running.", "BYTAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            // Launch Process without Bypass
            try {
                Process.Start(targetPath);
            }
            catch {
                MessageBox.Show($"Could not launch \"{targetName}\", please check permissions.", "BYTAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private uint LaunchProcessInteractively(string filename, int delay)
        {
            uint processId;
            bool started = p.LaunchProcessSuspended(filename, delay, out processId);

            if (!started) {
                MessageBox.Show($"Could not launch \"{targetName}\", please check permissions.", "BYTAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return processId;
        }

        private void BtnBypass_Click(object sender, EventArgs e)
        {
            // Check for empty textboxes
            if (string.IsNullOrEmpty(targetTB.Text) || string.IsNullOrEmpty(originalTB.Text) || string.IsNullOrEmpty(replacementTB.Text)) {
                MessageBox.Show("Please select all files before bypassing.", "BYTAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Try to kill already running process
            foreach (Process p in Process.GetProcesses()) {
                if (p.ProcessName.ToLower().Contains(targetProcess.ToLower())) {
                    try {
                        p.Kill();
                    }
                    catch {
                        MessageBox.Show("Could not kill target process, please check permissions and make sure that the target process isn't already running.", "BYTAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            // Start Process suspended
            uint pid = LaunchProcessInteractively(targetPath, (int)BdelayUD.Value);

            Thread.Sleep(100);

            // Rename original DLL
            try {
                File.Move(Application.StartupPath + originalName, Application.StartupPath + originalName + ".BAK");
                File.Move(targetPath.Replace(targetName, string.Empty) + originalName, targetPath.Replace(targetName, string.Empty) + originalName + ".BAK");
            }
            catch {
                MessageBox.Show("Could not rename DLL, please check permissions.", "BYTAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Replace Custom DLL
            try {
                File.Copy(replacementPath, Application.StartupPath + originalName, true);
                File.Copy(replacementPath, targetPath.Replace(targetName, string.Empty) + originalName, true);
            }
            catch {
                MessageBox.Show("Could not copy DLL, please check permissions.", "BYTAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Wait before suspension
            Thread.Sleep((int)AdelayUD.Value);

            // Resume Process
            p.ResumeProcess();

            #if DEBUG
                MessageBox.Show("Successfully replaced DLL.", "BYTAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            #endif
        }

        private void BtnRevert_Click(object sender, EventArgs e)
        {
            // Check for empty textboxes
            if (string.IsNullOrEmpty(targetTB.Text) || string.IsNullOrEmpty(originalTB.Text) || string.IsNullOrEmpty(replacementTB.Text)) {
                MessageBox.Show("Please select all files before reverting.", "BYTAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Try to kill already running process
            foreach (Process p in Process.GetProcesses()) {
                if (p.ProcessName.ToLower().Contains(targetProcess.ToLower())) {
                    try {
                        p.Kill();
                    }
                    catch {
                        MessageBox.Show("Could not kill target process, please check permissions and make sure that the target process isn't already running.", "BYTAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (!File.Exists(Application.StartupPath + replacementName + ".BAK") && !File.Exists(targetPath.Replace(targetName, string.Empty) + replacementName + ".BAK")) {
                MessageBox.Show("Already reverted.", "BYTAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Delete replaced DLL
            try {
                File.Delete(Application.StartupPath + replacementName);
                File.Delete(targetPath.Replace(targetName, string.Empty) + replacementName);
            }
            catch {
                MessageBox.Show("Could not delete replaced DLL, please check permissions.", "BYTAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Rename original DLL
            try {
                File.Move(Application.StartupPath + originalName + ".BAK", Application.StartupPath + originalName);
                File.Move(targetPath.Replace(targetName, string.Empty) + originalName + ".BAK", targetPath.Replace(targetName, string.Empty) + originalName);
            }
            catch {
                MessageBox.Show("Could not rename DLL, please check permissions.", "BYTAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Successfully reverted DLL to the original.", "BYTAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /*----------------------------------------------------------------------------------------------PROCESS-HACKER--------------------------------------------------------------------------------------------------------------*/

        string PHtargetPath, PHtargetName = "", PHtargetProcess;

        private void SametargetashashCB_CheckedChanged(object sender, EventArgs e)
        {
            if (sametargetashashCB.Checked) {
                PHtargetTB.Text = targetTB.Text;
                PHtargetBTN.Enabled = false;

                PHtargetPath = targetPath;
                PHtargetName = targetName;
                PHtargetProcess = targetProcess;
            }
            else {
                PHtargetTB.Text = PHtargetName;
                PHtargetBTN.Enabled = true;
            }
        }

        private void PHtargetBTN_Click(object sender, EventArgs e)
        {
            ofd.Title = "Target";
            ofd.Filter = "Target|*.exe";

            DialogResult result;

            result = ofd.ShowDialog();

            if (result == DialogResult.OK && ofd.SafeFileName.EndsWith(".exe")) {
                PHtargetPath = ofd.FileName;
                PHtargetName = ofd.SafeFileName;
                PHtargetProcess = ofd.SafeFileName.Remove(ofd.SafeFileName.Length - 4);

                PHtargetTB.Text = PHtargetName;
            }
            else {
                MessageBox.Show("Please select the target application.", "BYTAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void StartSuspendedCB_CheckedChanged(object sender, EventArgs e)
        {
            if (startSuspendedCB.Checked) {
                PHdelayAfterUD.Enabled = true;
                PHdelayBeforeUD.Enabled = true;
            }
            else {
                PHdelayAfterUD.Enabled = false;
                PHdelayBeforeUD.Enabled = false;
            }
        }

        Process tProc;
        bool running = false;
        int procID;
        private void PHstartBTN_Click(object sender, EventArgs e)
        {
            // Check for empty textboxes
            if (string.IsNullOrEmpty(PHtargetTB.Text)) {
                MessageBox.Show("Please select a target before starting.", "BYTAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Start
            if (startSuspendedCB.Checked) {
                // Start suspended
                try {
                    running = true;

                    // Try to kill already running process
                    foreach (Process p in Process.GetProcesses()) {
                        if (p.ProcessName.ToLower().Contains(PHtargetProcess.ToLower())) {
                            try {
                                p.Kill();
                            }
                            catch {
                                MessageBox.Show("Could not kill target process, please check permissions and make sure that the target process isn't already running.", "BYTAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    // Start Process suspended with Delay before
                    procID = (int)LaunchProcessInteractively(PHtargetPath, (int)PHdelayBeforeUD.Value);

                    // Delay after
                    Thread.Sleep((int)PHdelayAfterUD.Value);

                    // Resume Process
                    p.ResumeProcess();

                    updateStatus();
                }
                catch {
                    MessageBox.Show("Could not start target.", "BYTAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                // Start directly
                try {
                    running = true;
                    tProc = Process.Start(PHtargetPath);
                    updateStatus();
                }
                catch {
                    MessageBox.Show("Could not start target.", "BYTAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PHkillBTN_Click(object sender, EventArgs e)
        {
            // Check for running process
            if (!running || string.IsNullOrEmpty(PHtargetTB.Text)) {
                MessageBox.Show("Please start the process before killing it.", "BYTAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kill
            try {
                if (!startSuspendedCB.Checked)
                    tProc.Kill();
                else
                    Process.GetProcessById(procID).Kill();

                updateStatus();
                running = false;
            }
            catch {
                MessageBox.Show("Could not kill target process.", "BYTAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PHsuspendBTN_Click(object sender, EventArgs e)
        {
            // Check for running process
            if (!running || string.IsNullOrEmpty(PHtargetTB.Text)) {
                MessageBox.Show("Please start the process before suspending it.", "BYTAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Suspend
            try {
                if (!startSuspendedCB.Checked)
                    ProcessExtension.SuspendProcess(tProc.Id);
                else
                    ProcessExtension.SuspendProcess(procID);

                updateStatus();
                running = true;
            }
            catch {
                MessageBox.Show("Could not suspend target process.", "BYTAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PHresumeBTN_Click(object sender, EventArgs e)
        {
            // Check for running process
            if (!running || string.IsNullOrEmpty(PHtargetTB.Text)) {
                MessageBox.Show("Please start the process before resuming it.", "BYTAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Resume
            try {
                if (!startSuspendedCB.Checked)
                    ProcessExtension.ResumeProcess(tProc.Id);
                else
                    ProcessExtension.ResumeProcess(procID);

                updateStatus();
                running = true;
            }
            catch {
                MessageBox.Show("Could not resume target process.", "BYTAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateStatus()
        {
            if (!running || startSuspendedCB.Checked)
                return;

            if (!startSuspendedCB.Checked)
                tProc.Refresh();

            string status = "Undefined";
            if (tProc.HasExited || tProc.Threads[0].ThreadState == System.Diagnostics.ThreadState.Terminated) {
                status = "Killed";
                pidLBL.Text = $"Process ID: Undefined";
                statusLBL.Text = $"Status: {status}";
                adminLBL.Text = $"Admin: Undefined";
                threadsLBL.Text = $"Threads: 0";
                memusgLBL.Text = $"Memory usage: 0 Bytes";
                running = false;
                tmr.Stop();
                updateBTN.Text = "Refresh ON";
                return;
            }
            else {
                if (!tProc.Responding || tProc.Threads[0].ThreadState == System.Diagnostics.ThreadState.Wait && tProc.Threads[0].WaitReason == ThreadWaitReason.Suspended) {
                    status = "Suspended";
                }
                else {
                    if (tProc.Threads[0].ThreadState == System.Diagnostics.ThreadState.Running || tProc.Threads[0].ThreadState == System.Diagnostics.ThreadState.Wait && tProc.Threads[0].WaitReason != ThreadWaitReason.Suspended) {
                        status = "Running";
                    }
                }
            }

            #if DEBUG
                Console.WriteLine("ThreadState: " + tProc.Threads[0].ThreadState);
                Console.WriteLine("Status: " + status);
            #endif

            string admin;
            switch (UacHelper.IsProcessElevated_ID(tProc.Id)) {
                case 0: admin = "No";  break;
                case 1: admin = "Yes";  break;
                default: admin = "Undefined"; break;
            }

            string shrounkenMWT = "Undefined";
            if (tProc.MainWindowTitle.Length > 10) {
                shrounkenMWT = tProc.MainWindowTitle.Substring(0, tProc.MainWindowTitle.Length - (tProc.MainWindowTitle.Length - 10));
            }

            pidLBL.Text = $"Process ID: {tProc.Id.ToString()}";
            statusLBL.Text = $"Status: {status}";
            adminLBL.Text = $"Admin: {admin}";
            procnameLBL.Text = $"Processname: {tProc.ProcessName}";
            mwtitleLBL.Text = $"MainWindowTitle: {shrounkenMWT}";
            threadsLBL.Text = $"Threads: {tProc.Threads.Count.ToString()}";
            memusgLBL.Text = $"Memory usage: {tProc.WorkingSet64.ToString()} Bytes";
            mempeakLBL.Text = $"Memory Peak: {tProc.PeakWorkingSet64.ToString()} Bytes";
        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            if (!running) {
                MessageBox.Show("Please start the process before updating.", "BYTAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tmr.Enabled) {
                tmr.Stop();
                updateBTN.Text = "Refresh ON";
            }
            else {
                tmr.Start();
                updateBTN.Text = "Refresh OFF";
            }
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            updateStatus();
        }
    }
}