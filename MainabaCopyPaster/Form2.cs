using System.Diagnostics;
using System.Xml;

namespace MainabaCopyPaster
{
	public partial class Form2 : Form
	{
		public Form2(string currentRootPath, string updateRootPath, string manualMargePath, XmlDocument xmlDocument)
		{
			InitializeComponent();
			this.CurrentRootPath = currentRootPath;
			this.UpdateRootPath = updateRootPath;
			this.ManualMargePath = manualMargePath;
			this.XmlDocument = xmlDocument;
			label1.Text = currentRootPath;
			label2.Text = updateRootPath;

			// ���V
			// xml�Ɋe�����̒l��ۑ�
		}

		/// <summary>
		/// �t�@�C���ǂݍ���
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e)
		{
			this.CurrentFilePath = this.CurrentRootPath + textBox1.Text;
			this.UpdateFilePath = this.UpdateRootPath + textBox1.Text;
			textBox3.Text = this.CurrentFilePath;
		}

		/// <summary>
		/// �X�V�p�t�@�C���쐬
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button2_Click(object sender, EventArgs e)
		{
			if (File.Exists(CurrentFilePath))
			{
				textBox2.Text = "�t�@�C���p�X���m�F���܂����B";
			}
			else
			{
				textBox2.Text = "�����ȃt�@�C���p�X�ł��B";
				return;
			}

			textBox2.Text += "\r\n" + this.UpdateFilePath;

			if (File.Exists(UpdateFilePath))
			{
				textBox2.Text += "\r\n���ɍX�V�p�t�@�C�����쐬���Ă��܂��B";
			}
			else
			{
				textBox2.Text += "\r\n�X�V�p�t�@�C�����쐬���܂��B";
				var directoryPath = Path.GetDirectoryName(this.UpdateFilePath);
				if (Directory.Exists(directoryPath) == false)
				{
					Directory.CreateDirectory(directoryPath);
				}
				File.Copy(CurrentFilePath, this.UpdateFilePath, false);
				textBox2.Text += "\r\n�쐬���������܂����B";
			}

			if (this.checkBox1.Checked == true)
			{
				textBox2.Text += "\r\n�G�f�B�^�ŊJ���܂��B";
				OpenEditor(this.UpdateFilePath);
				return;
			}

		}

		/// <summary>
		/// �w��G�f�B�^�ŊJ��
		/// </summary>
		/// <param name="filePath"></param>
		private void OpenEditor(string filePath)
		{
			Process process = new Process();
			process.StartInfo.FileName = this.XmlDocument.SelectSingleNode("/Settings/EditorFilePath").InnerText;
			process.StartInfo.Arguments = filePath;
			process.Start();
		}

		/// <summary>
		/// �蓮�}�[�W�t�@�C���o��
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button3_Click(object sender, EventArgs e)
		{
			textBox2.Text = string.Empty;
			var path = this.ManualMargePath;
			if (string.IsNullOrEmpty(path))
			{
				textBox2.Text = "�����ȃt�@�C���p�X�ł��B";
				return;
			}
			else
			{
				var margeFileList = GetMargeFileList(path);

				foreach (var filePath in margeFileList)
				{
					textBox2.Text += (filePath + "\r\n");
				}
			}
		}

		/// <summary>
		/// �e�L�X�g�R�s�[
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button4_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(textBox2.Text);
		}

		/// <summary>
		/// �蓮�}�[�W�t�@�C���擾
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		private List<string> GetMargeFileList(string path)
		{
			List<string> filePaths = new List<string>();

			var pathNodes = this.XmlDocument.SelectNodes("/Settings/Manual/Path");
			if (pathNodes != null)
			{
				foreach (XmlNode pathNode in pathNodes)
				{
					string relativePath = pathNode.InnerText;
					string fullPath = Path.Combine(path, relativePath);

					foreach (var filePath in GetAllFiles(fullPath))
					{
						filePaths.Add(filePath);
					}
				}
			}

			return filePaths.Distinct().ToList(); ;
		}

		/// <summary>
		/// �蓮�}�[�W�t�@�C���擾
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		private static List<string> GetAllFiles(string path)
		{
			List<string> files = new List<string>();

			if (Directory.Exists(path) || File.Exists(path))
			{
				if (File.Exists(path))
				{
					files.Add(path);
				}
				else if (Directory.Exists(path))
				{
					files.AddRange(Directory.GetFiles(path));

					string[] subDirectories = Directory.GetDirectories(path);

					foreach (string subDirectory in subDirectories)
					{
						List<string> subFiles = GetAllFiles(subDirectory);
						files.AddRange(subFiles);
					}
				}
			}

			return files;
		}

		/// <summary>
		/// �p�X�N���A
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button5_Click(object sender, EventArgs e)
		{
			textBox1.Text = string.Empty;
		}

		/// <summary>
		/// WinMerge
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void button6_Click(object sender, EventArgs e)
		{
			var winMergePath = this.XmlDocument.SelectSingleNode("/Settings/WinMergeFilePath").InnerText;

			var arguments = $@"""{this.CurrentFilePath}"" ""{this.UpdateFilePath}"" /e /s /u /wl";

			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				FileName = winMergePath,
				Arguments = arguments,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				CreateNoWindow = true
			};

			using (Process process = new Process { StartInfo = startInfo })
			{
				process.Start();

				await Task.Run(() => process.WaitForExit());
			}
		}
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			this.TopMost = (checkBox2.Checked == true);
		}

		public string CurrentRootPath { get; set; }
		public string UpdateRootPath { get; set; }
		public string CurrentFilePath { get; set; }
		public string UpdateFilePath { get; set; }
		public string ManualMargePath { get; set; }
		public XmlDocument XmlDocument { get; set; }
	}
}
