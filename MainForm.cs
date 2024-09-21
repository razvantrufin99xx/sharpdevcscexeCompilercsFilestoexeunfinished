/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/21/2024
 * Time: 5:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace compiler
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		string csc = "C:\\Windows\\Microsoft.NET\\Framework64\\v4.0.30319\\csc.exe";
		
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
		// Path to the C# source file
		string sourceFile = "helloworld.cs";
        
        // Path to the C# compiler
        string cscPath = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe";
        
        // Arguments for the compiler
        string arguments = "-out:helloworld.exe {sourceFile}";
        
        // Create a process to run the compiler
        ProcessStartInfo processInfo = new ProcessStartInfo(cscPath, arguments);
        processInfo.RedirectStandardOutput = true;
        processInfo.UseShellExecute = false;
        processInfo.CreateNoWindow = true;

        // Start the process
        using (Process process = Process.Start(processInfo))
        {
            // Read the output from the compiler
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            
            // Display the output
            Console.WriteLine(output);
        }

        // Run the compiled executable
        Process.Start("helloworld.exe");
		}
	}
}
